// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'order.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Order _$OrderFromJson(Map<String, dynamic> json) => Order()
  ..narudzbaId = json['narudzbaId'] as int?
  ..brojNarudzbe = json['brojNarudzbe'] as String?
  ..korisnikId = json['korisnikId'] as int?
  ..datum = json['datum'] as String?
  ..status = json['status'] as bool?
  ..otkazano = json['otkazano'] as bool?
  ..paymentId = json['paymentId'] as String?;

Map<String, dynamic> _$OrderToJson(Order instance) => <String, dynamic>{
      'narudzbaId': instance.narudzbaId,
      'brojNarudzbe': instance.brojNarudzbe,
      'korisnikId': instance.korisnikId,
      'datum': instance.datum,
      'status': instance.status,
      'otkazano': instance.otkazano,
      'paymentId': instance.paymentId,
    };
