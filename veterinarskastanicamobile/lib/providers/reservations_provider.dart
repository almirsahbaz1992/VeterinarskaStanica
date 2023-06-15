import 'package:veterinarskastanicamobile/model/product.dart';
import 'package:veterinarskastanicamobile/model/reservation.dart';
import 'package:veterinarskastanicamobile/providers/base_provider.dart';

class ReservationProvider extends BaseProvider<Reservation> {
  ReservationProvider() : super("Rezervacije");

  @override
  Reservation fromJson(data) {
    return Reservation.fromJson(data);
  }
}
