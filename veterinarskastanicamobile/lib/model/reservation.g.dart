// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'reservation.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Reservation _$ReservationFromJson(Map<String, dynamic> json) => Reservation()
  ..rezervacijaId = json['rezervacijaId'] as int?
  ..uslugaId = json['uslugaId'] as int?
  ..korisnikId = json['korisnikId'] as int?
  ..datumRezervacije = json['datumRezervacije'] == null
      ? null
      : DateTime.parse(json['datumRezervacije'] as String)
  ..paymentId = json['paymentId'] as String?;

Map<String, dynamic> _$ReservationToJson(Reservation instance) =>
    <String, dynamic>{
      'rezervacijaId': instance.rezervacijaId,
      'uslugaId': instance.uslugaId,
      'korisnikId': instance.korisnikId,
      'datumRezervacije': instance.datumRezervacije?.toIso8601String(),
      'paymentId': instance.paymentId,
    };
