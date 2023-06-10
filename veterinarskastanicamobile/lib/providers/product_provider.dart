import 'package:veterinarskastanicamobile/model/product.dart';
import 'package:veterinarskastanicamobile/providers/base_provider.dart';

class ProductProvider extends BaseProvider<Product> {
  ProductProvider() : super("Proizvodi");

  @override
  Product fromJson(data) {
    return Product.fromJson(data);
  }
}
