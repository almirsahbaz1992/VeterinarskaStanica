import 'package:json_annotation/json_annotation.dart';
part 'order.g.dart';

@JsonSerializable()
class Order {
  int? narudzbaId;
  String? brojNarudzbe;
  int? korisnikId;
  String? datum;
  bool? status;
  bool? otkazano;
  String? paymentId;

  Order();

  factory Order.fromJson(Map<String, dynamic> json) => _$OrderFromJson(json);
  Map<String, dynamic> toJson() => _$OrderToJson(this);
}
