import 'package:veterinarskastanicamobile/model/usluge.dart';
import 'package:veterinarskastanicamobile/providers/base_provider.dart';

class ServiceProvider extends BaseProvider<Service> {
  ServiceProvider() : super("Usluge");

  @override
  Service fromJson(data) {
    return Service.fromJson(data);
  }
}
