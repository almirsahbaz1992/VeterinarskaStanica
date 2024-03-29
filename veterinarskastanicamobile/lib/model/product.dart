import 'package:json_annotation/json_annotation.dart';
part 'product.g.dart';

@JsonSerializable()
class Product {
  int? proizvodId;
  String? naziv;
  String? slika;
  double? cijena;
  String? opis;
  int? vrstaId;
  int? jedinicaMjereId;
  String? sifra;
  Product();

  factory Product.fromJson(Map<String, dynamic> json) =>
      _$ProductFromJson(json);

  /// Connect the generated [_$ProductToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$ProductToJson(this);
}
