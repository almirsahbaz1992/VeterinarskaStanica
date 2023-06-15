import 'package:veterinarskastanicamobile/providers/cart_provider.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:veterinarskastanicamobile/screens/services/services_screen.dart';
import 'package:veterinarskastanicamobile/screens/user/user_screen.dart';

import '../screens/cart/cart_screen.dart';
import '../screens/products/product_list_screen.dart';

// ignore: camel_case_types, must_be_immutable
class eProdajaDrawer extends StatelessWidget {
  eProdajaDrawer({Key? key}) : super(key: key);
  CartProvider? _cartProvider;
  @override
  Widget build(BuildContext context) {
    _cartProvider = context.watch<CartProvider>();
    print("called build drawer");
    return Drawer(
      child: ListView(
        children: [
          ListTile(
            title: const Text('Home'),
            onTap: () {
              Navigator.popAndPushNamed(context, ProductListScreen.routeName);
            },
          ),
          ListTile(
            title: Text('Cart ${_cartProvider?.cart.items.length}'),
            onTap: () {
              Navigator.pushNamed(context, CartScreen.routeName);
            },
          ),
          ListTile(
            title: const Text('Usluge'),
            onTap: () {
              Navigator.pushNamed(context, ServiceListScreen.routeName);
            },
          ),
          ListTile(
            title: const Text('Profil'),
            onTap: () {
              Navigator.pushNamed(context, UserDetailsScreen.routeName);
            },
          ),
        ],
      ),
    );
  }
}
