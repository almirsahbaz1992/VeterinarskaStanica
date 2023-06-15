import 'dart:convert';

import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'package:veterinarskastanicamobile/model/reservation.dart';
import 'package:veterinarskastanicamobile/model/usluge.dart';
import 'package:veterinarskastanicamobile/providers/reservations_provider.dart';
import 'package:veterinarskastanicamobile/providers/services_provider.dart';
import '../../widgets/master_screen.dart';
import '../../widgets/product_details.dart';
import 'package:intl/intl.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:http/http.dart' as http;

import 'package:veterinarskastanicamobile/.env';

// ignore: must_be_immutable
class ServiceDetailsScreen extends StatefulWidget {
  static const String routeName = "/service_details";
  String id;

  ServiceDetailsScreen(this.id, {Key? key}) : super(key: key);
  //To DO
  //Get Service by id
  //Display Service details
  //Add Calendar picker

  @override
  State<ServiceDetailsScreen> createState() => _ServiceDetailsScreen();
}

class _ServiceDetailsScreen extends State<ServiceDetailsScreen> {
  ServiceProvider _serviceProvider = ServiceProvider();
  Service product = Service();
  DateTime selectedDate = DateTime.now();
  Map<String, dynamic>? paymentIntentData;
  ReservationProvider _reservationProvider = ReservationProvider();

  @override
  void initState() {
    super.initState();
    _serviceProvider = context.read<ServiceProvider>();
    loadData(int.parse(widget.id));
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Column(
        children: [
          const SizedBox(height: 20),
          if (product.naziv == null)
            const CircularProgressIndicator() // Circular loader
          else
            ProductDetails(
              imageUrl: product.slika!,
              productName: product.naziv!,
              productPrice: product.cijena.toString(),
            ),
          const SizedBox(height: 20),
          ElevatedButton(
            onPressed: () {
              // Add to cart logic
              _selectDate(context);
            },
            child: const Text("Odaberi datum"),
          ),
          Text(DateFormat('dd-MM-yyyy').format(selectedDate)),
          const Spacer(),
          ElevatedButton(
            onPressed: () async {
              paymentIntentData = await createPaymentIntent(
                  (product.cijena! * 100).round().toString(), 'bam');
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
              _saveToDatabase(
                  paymentIntentData!['id'], product.uslugaId, selectedDate);
            },
            child: const Text("Rezervisi"),
          ),
        ],
      ),
    );
  }

  void loadData(int id) {
    _serviceProvider.getById(id).then((value) {
      setState(() {
        product = value;
      });
    });
  }

  Future<void> _selectDate(BuildContext context) async {
    final DateTime? picked = await showDatePicker(
      context: context,
      initialDate: selectedDate,
      firstDate: DateTime.now(),
      lastDate: DateTime(DateTime.now().year + 1),
    );
    if (picked != null && picked != selectedDate) {
      setState(() {
        selectedDate = picked;
      });
    }
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

void _saveToDatabase(
    String paymentId, int? uslugaId, DateTime selectedDate) async {
  try {
    SharedPreferences prefs = await SharedPreferences.getInstance();
    String? id = prefs.getString('korisnikId');
    int korisnikId = int.parse(id!);

    String formattedDateTime = selectedDate.toUtc().toIso8601String();

    var rezervacija = {
      "datumRezervacije": formattedDateTime,
      "paymentId": paymentId,
      "korisnikId": korisnikId,
      "uslugaId": uslugaId
    };

    ReservationProvider _reservationProvider = ReservationProvider();
    _reservationProvider.insert(rezervacija);
  } catch (e) {
    print(e);
  }
}
