// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'user.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

User _$UserFromJson(Map<String, dynamic> json) => User()
  ..korisnikId = json['korisnikId'] as int?
  ..ime = json['ime'] as String?
  ..prezime = json['prezime'] as String?
  ..email = json['email'] as String?
  ..telefon = json['telefon'] as String?
  ..korisnickoIme = json['korisnickoIme'] as String?;

Map<String, dynamic> _$UserToJson(User instance) => <String, dynamic>{
      'korisnikId': instance.korisnikId,
      'ime': instance.ime,
      'prezime': instance.prezime,
      'email': instance.email,
      'telefon': instance.telefon,
      'korisnickoIme': instance.korisnickoIme,
    };
