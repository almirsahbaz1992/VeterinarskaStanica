import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:veterinarskastanicamobile/model/product.dart';
import 'package:veterinarskastanicamobile/providers/cart_provider.dart';
import 'package:veterinarskastanicamobile/providers/product_provider.dart';
import '../../utils/util.dart';
import '../../widgets/master_screen.dart';
import '../../widgets/product_details.dart';

class ProductDetailsScreen extends StatefulWidget {
  static const String routeName = "/product_details";
  final String id;

  const ProductDetailsScreen(this.id, {Key? key}) : super(key: key);

  @override
  State<ProductDetailsScreen> createState() => _ProductDetailsScreenState();
}

class _ProductDetailsScreenState extends State<ProductDetailsScreen> {
  ProductProvider _productProvider = ProductProvider();
  CartProvider _cartProvider = CartProvider();
  Product product = Product();
  List<Product> products = [];

  @override
  void initState() {
    super.initState();
    _productProvider = context.read<ProductProvider>();
    _cartProvider = context.read<CartProvider>();
    loadData(int.parse(widget.id));
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: FutureBuilder(
        future: _fetchProduct(),
        builder: (BuildContext context, AsyncSnapshot<Product> snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return const Center(
              child: CircularProgressIndicator(),
            );
          } else if (snapshot.hasError) {
            return Center(
              child: Text('Error: ${snapshot.error}'),
            );
          } else {
            final product = snapshot.data!;
            return Column(
              children: [
                const SizedBox(height: 20),
                ProductDetails(
                  imageUrl: product.slika!,
                  productName: product.naziv!,
                  productPrice: product.cijena.toString(),
                ),
                const SizedBox(height: 20),
                ElevatedButton(
                  onPressed: () {
                    _cartProvider.addToCart(product);
                  },
                  child: const Text("Add to Cart"),
                ),
                const SizedBox(height: 20),
                const Text(
                  "Related Products",
                  style: TextStyle(
                    fontSize: 18,
                    fontWeight: FontWeight.bold,
                  ),
                ),
                const SizedBox(height: 20),
                SizedBox(
                  height: 150, // adjust the height as needed
                  child: GridView(
                    gridDelegate:
                        const SliverGridDelegateWithFixedCrossAxisCount(
                      crossAxisCount: 1,
                      childAspectRatio: 5 / 6,
                      mainAxisSpacing: 5,
                    ),
                    scrollDirection: Axis.horizontal,
                    children: _buildRelatedProducts(products, context),
                  ),
                ),
              ],
            );
          }
        },
      ),
    );
  }

  List<Widget> _buildRelatedProducts(products, context) {
    //If data is empty return circular loader
    if (products.isEmpty) {
      return [
        const Center(
          child: CircularProgressIndicator(),
        )
      ];
    } else {
      return products
          .map((product) {
            return Container(
              width: 120,
              margin: const EdgeInsets.only(right: 10),
              child: Column(
                children: [
                  imageFromBase64String(
                    product.slika!,
                  ),
                  Text(product.naziv!),
                ],
              ),
            );
          })
          .cast<Widget>()
          .toList();
    }
  }

  Future<Product> _fetchProduct() async {
    final int productId = int.parse(widget.id);
    return _productProvider.getById(productId);
  }

  void loadData(int id) async {
    var tmpData = await _productProvider.getRecommendedProducts(id);
    setState(() {
      products = tmpData;
    });
  }
}
