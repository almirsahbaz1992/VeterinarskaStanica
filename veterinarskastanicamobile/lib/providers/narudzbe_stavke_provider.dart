import 'package:veterinarskastanicamobile/providers/base_provider.dart';

import '../model/order.dart';

class NarudzbaStavkeProvider extends BaseProvider<Order> {
  NarudzbaStavkeProvider() : super("NarudzbeStavke");

  @override
  fromJson(data) {
    // TODO: implement fromJson
    return Order();
  }
}
