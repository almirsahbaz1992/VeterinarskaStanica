// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'usluge.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Service _$ServiceFromJson(Map<String, dynamic> json) => Service()
  ..uslugaId = json['uslugaId'] as int?
  ..naziv = json['naziv'] as String?
  ..sifra = json['sifra'] as String?
  ..cijena = (json['cijena'] as num?)?.toDouble()
  ..vrstaId = json['vrstaId'] as int?
  ..jedinicaMjereId = json['jedinicaMjereId'] as int?
  ..slika = json['slika'] as String?
  ..status = json['status'] as bool?;

Map<String, dynamic> _$ServiceToJson(Service instance) => <String, dynamic>{
      'uslugaId': instance.uslugaId,
      'naziv': instance.naziv,
      'sifra': instance.sifra,
      'cijena': instance.cijena,
      'vrstaId': instance.vrstaId,
      'jedinicaMjereId': instance.jedinicaMjereId,
      'slika': instance.slika,
      'status': instance.status,
    };
