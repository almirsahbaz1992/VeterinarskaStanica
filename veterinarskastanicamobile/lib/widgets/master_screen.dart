import 'package:flutter/material.dart';
import 'package:veterinarskastanicamobile/screens/services/services_screen.dart';
import '../screens/cart/cart_screen.dart';
import '../screens/products/product_list_screen.dart';
import 'veterinarskastanica_drawer.dart';

// ignore: must_be_immutable
class MasterScreenWidget extends StatefulWidget {
  Widget? child;
  MasterScreenWidget({this.child, Key? key}) : super(key: key);

  @override
  State<MasterScreenWidget> createState() => _MasterScreenWidgetState();
}

class _MasterScreenWidgetState extends State<MasterScreenWidget> {
  int currentIndex = 0;

  void _onItemTapped(int index) {
    setState(() {
      currentIndex = index;
    });
    if (currentIndex == 0) {
      Navigator.pushNamed(context, ProductListScreen.routeName);
    } else if (currentIndex == 1) {
      Navigator.pushNamed(context, CartScreen.routeName);
    } else if (currentIndex == 2) {
      Navigator.pushNamed(context, ServiceListScreen.routeName);
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(),
      drawer: eProdajaDrawer(),
      body: SafeArea(
        child: widget.child!,
      ),
      bottomNavigationBar: BottomNavigationBar(
        items: const <BottomNavigationBarItem>[
          BottomNavigationBarItem(
            icon: Icon(Icons.home),
            label: 'Home',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.shopping_bag),
            label: 'Cart',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.medical_services),
            label: 'Usluge',
          ),
        ],
        selectedItemColor: Colors.blue[800],
        currentIndex: currentIndex,
        onTap: _onItemTapped,
      ),
    );
  }
}
