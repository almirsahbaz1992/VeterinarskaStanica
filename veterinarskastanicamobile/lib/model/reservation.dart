import 'package:json_annotation/json_annotation.dart';

part 'reservation.g.dart';

@JsonSerializable()
class Reservation {
  int? rezervacijaId;
  int? uslugaId;
  int? korisnikId;
  DateTime? datumRezervacije;
  String? paymentId;

  Reservation();

  factory Reservation.fromJson(Map<String, dynamic> json) =>
      _$ReservationFromJson(json);

  /// Connect the generated [_$ProductToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$ReservationToJson(this);
}
