import 'package:veterinarskastanicamobile/providers/base_provider.dart';

import '../model/order.dart';

class OrderProvider extends BaseProvider<Order> {
  OrderProvider() : super("Narudzbe");

  @override
  Order fromJson(data) {
    return Order.fromJson(data);
  }
}
