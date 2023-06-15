import 'dart:convert';

import 'package:flutter/foundation.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'package:veterinarskastanicamobile/model/cart.dart';
import 'package:veterinarskastanicamobile/model/order.dart';
import 'package:veterinarskastanicamobile/providers/cart_provider.dart';
import 'package:veterinarskastanicamobile/providers/narudzbe_stavke_provider.dart';
import 'package:veterinarskastanicamobile/widgets/master_screen.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../../.env';
import '../../providers/order_provider.dart';
import '../../utils/util.dart';

import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:http/http.dart' as http;

class CartScreen extends StatefulWidget {
  static const String routeName = "/cart";

  const CartScreen({Key? key}) : super(key: key);

  @override
  State<CartScreen> createState() => _CartScreenState();
}

class _CartScreenState extends State<CartScreen> {
  late CartProvider _cartProvider;
  final OrderProvider _orderProvider = OrderProvider();
  Order _order = Order();
  final NarudzbaStavkeProvider _narudzbaStavkeProvider =
      NarudzbaStavkeProvider();
  Map<String, dynamic>? paymentIntentData;
  double iznos = 0;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
  }

  @override
  void didChangeDependencies() {
    // TODO: implement didChangeDependencies
    super.didChangeDependencies();
    _cartProvider = context.watch<CartProvider>();
    // _orderProvider = context.read<OrderProvider>();
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Column(
        children: [
          Expanded(child: _buildProductCardList()),
          _buildBuyButton(),
        ],
      ),
    );
  }

  Widget _buildProductCardList() {
    return ListView.builder(
      itemCount: _cartProvider.cart.items.length,
      itemBuilder: (context, index) {
        return _buildProductCard(_cartProvider.cart.items[index]);
      },
    );
  }

  Widget _buildProductCard(CartItem item) {
    return ListTile(
      leading: imageFromBase64String(item.product.slika!),
      title: Text(item.product.naziv ?? ""),
      subtitle: Text(item.product.cijena.toString()),
      trailing: Text(item.count.toString()),
    );
  }

  Widget _buildBuyButton() {
    return TextButton(
      child: const Text("Buy"),
      onPressed: () async {
        iznos = IzracunajUkupno();
        paymentIntentData =
            await createPaymentIntent((iznos * 100).round().toString(), 'bam');
        await Stripe.instance
            .initPaymentSheet(
                paymentSheetParameters: SetupPaymentSheetParameters(
                    paymentIntentClientSecret:
                        paymentIntentData!['client_secret'],
                    style: ThemeMode.dark,
                    merchantDisplayName: 'eRent'))
            .then((value) {})
            .onError((error, stackTrace) {
          if (kDebugMode) {
            print('Exception/DISPLAYPAYMENTSHEET==> $error $stackTrace');
          }
          showDialog(
              context: context,
              builder: (_) => const AlertDialog(
                    content: Text("Ponistena transakcija"),
                  ));
          throw Exception("Payment declined");
        });
        if (kDebugMode) {
          print("payment sheet created");
          print(paymentIntentData!['client_secret']);
        }
        try {
          var temp = await Stripe.instance.presentPaymentSheet();
        } catch (e) {
          if (kDebugMode) {
            print(e);
          }
        }

        SharedPreferences prefs = await SharedPreferences.getInstance();
        String? id = prefs.getString('korisnikId');
        int korisnikId = int.parse(id!);
        Map order = {
          "brojNarudzbe": "string",
          "korisnikId": korisnikId,
          "datum": DateTime.now().toUtc().toIso8601String(),
          "status": true,
          "otkazano": false,
          "paymentId": paymentIntentData!['id'],
        };

        var placedOrder = await _orderProvider.insert(order);

        List<Map> items = [];
        for (var item in _cartProvider.cart.items) {
          items.add({
            "proizvodId": item.product.proizvodId,
            "kolicina": item.count,
          });
          var narudzbaStavke = {
            "narudzbaId": placedOrder!.narudzbaId,
            "proizvodId": item.product.proizvodId,
            "kolicina": item.count,
            "proizvodIdList": [item.product.proizvodId],
            "narudzbaIdList": [placedOrder!.narudzbaId]
          };
          await _narudzbaStavkeProvider.insert(narudzbaStavke);
        }
        _cartProvider.cart.items.clear();
      },
    );
  }

  double IzracunajUkupno() {
    _cartProvider.cart.items.forEach((element) {
      iznos += (element.product.cijena! * element.count).toDouble();
    });

    return iznos;
  }

  createPaymentIntent(String amount, String currency) async {
    try {
      Map<String, dynamic> body = {
        'amount': amount,
        'currency': currency,
        'payment_method_types[]': 'card'
      };

      var response = await http.post(
          Uri.parse('https://api.stripe.com/v1/payment_intents'),
          body: body,
          headers: {
            'Authorization': 'Bearer $stripeSecretKey',
            'Content-Type': 'application/x-www-form-urlencoded'
          });
      return jsonDecode(response.body);
    } catch (err) {
      print('err charging user: ${err.toString()}');
    }
  }
}
