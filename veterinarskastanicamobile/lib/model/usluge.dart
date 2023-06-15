import 'package:json_annotation/json_annotation.dart';

part 'usluge.g.dart';

@JsonSerializable()
class Service {
  int? uslugaId;
  String? naziv;
  String? sifra;
  double? cijena;
  int? vrstaId;
  int? jedinicaMjereId;
  String? slika;
  bool? status;

  Service();

  factory Service.fromJson(Map<String, dynamic> json) =>
      _$ServiceFromJson(json);

  Map<String, dynamic> toJson() => _$ServiceToJson(this);
}
