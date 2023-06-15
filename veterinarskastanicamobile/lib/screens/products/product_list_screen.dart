import 'package:veterinarskastanicamobile/providers/product_provider.dart';
import 'package:veterinarskastanicamobile/screens/products/product_details_screen.dart';
import 'package:veterinarskastanicamobile/utils/util.dart';
import 'package:veterinarskastanicamobile/widgets/master_screen.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import '../../model/product.dart';
import '../../providers/cart_provider.dart';

class ProductListScreen extends StatefulWidget {
  static const String routeName = "/product";

  const ProductListScreen({Key? key}) : super(key: key);

  @override
  State<ProductListScreen> createState() => _ProductListScreenState();
}

class _ProductListScreenState extends State<ProductListScreen> {
  ProductProvider? _productProvider;
  CartProvider? _cartProvider;
  List<Product> data = [];
  final TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _productProvider = context.read<ProductProvider>();
    _cartProvider = context.read<CartProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _productProvider?.get(null);
    setState(() {
      data = tmpData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
        child: SingleChildScrollView(
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          _buildHeader(),
          _buildProductSearch(),
          SizedBox(
            // Wrap the GridView with Container
            width: double.infinity, // Set width to expand to full width
            height: 550, // Set desired height for the GridView
            child: GridView(
              gridDelegate: const SliverGridDelegateWithFixedCrossAxisCount(
                crossAxisCount: 1,
                childAspectRatio: 3 / 1,
                mainAxisSpacing: 5,
              ),
              scrollDirection: Axis.vertical,
              children: _buildProductCardList(),
            ),
          ),
        ],
      ),
    ));
  }

  Widget _buildHeader() {
    return Container(
      padding: const EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: const Text(
        "Proizvodi",
        style: TextStyle(
            color: Colors.grey, fontSize: 40, fontWeight: FontWeight.w600),
      ),
    );
  }

  Widget _buildProductSearch() {
    return Row(
      children: [
        Expanded(
          child: Container(
            padding: const EdgeInsets.symmetric(horizontal: 20, vertical: 10),
            child: TextField(
              controller: _searchController,
              onSubmitted: (value) async {
                var tmpData = await _productProvider?.get({'naziv': value});
                setState(() {
                  data = tmpData!;
                });
              },
              decoration: InputDecoration(
                  hintText: "Pretraga",
                  prefixIcon: const Icon(Icons.search),
                  border: OutlineInputBorder(
                      borderRadius: BorderRadius.circular(10),
                      borderSide: const BorderSide(color: Colors.grey))),
            ),
          ),
        ),
        // Container(
        //   padding: const EdgeInsets.symmetric(horizontal: 20, vertical: 10),
        //   child: IconButton(
        //     icon: const Icon(Icons.filter_list),
        //     onPressed: () async {
        //       var tmpData = await _productProvider
        //           ?.get({'naziv': _searchController.text});
        //       setState(() {
        //         data = tmpData!;
        //       });
        //     },
        //   ),
        // )
      ],
    );
  }

  List<Widget> _buildProductCardList() {
    if (data.isEmpty) {
      return [const Text("Loading...")];
    }

    List<Widget> list = data
        .map(
          (x) => GestureDetector(
            onTap: () {
              Navigator.pushNamed(
                context,
                "${ProductDetailsScreen.routeName}/${x.proizvodId}",
              );
            },
            child: Container(
              padding: const EdgeInsets.all(20),
              child: Row(
                crossAxisAlignment: CrossAxisAlignment.center,
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  SizedBox(
                    height: 125,
                    width: 125,
                    child: imageFromBase64String(x.slika!),
                  ),
                  const SizedBox(
                    width: 10,
                  ), // Add spacing between the image and the text
                  Expanded(
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          x.naziv ?? "",
                          style: const TextStyle(
                            color: Colors.black,
                            fontSize: 22,
                            fontWeight: FontWeight.bold,
                          ),
                        ),
                        const SizedBox(
                          height: 10,
                        ), // Add spacing between the title and other details
                        Text(
                          formatNumber(x.cijena),
                          style: const TextStyle(
                            color: Colors.redAccent,
                            fontSize: 16,
                            fontWeight: FontWeight.bold,
                          ),
                        ),
                      ],
                    ),
                  ),
                  IconButton(
                    icon: const Icon(Icons.shopping_cart),
                    onPressed: () {
                      _cartProvider?.addToCart(x);
                    },
                  ),
                ],
              ),
            ),
          ),
        )
        .cast<Widget>()
        .toList();

    return list;
  }
}
