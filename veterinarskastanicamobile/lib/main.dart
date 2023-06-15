import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'package:veterinarskastanicamobile/providers/cart_provider.dart';
import 'package:veterinarskastanicamobile/providers/order_provider.dart';
import 'package:veterinarskastanicamobile/providers/product_provider.dart';
import 'package:veterinarskastanicamobile/providers/services_provider.dart';
import 'package:veterinarskastanicamobile/screens/cart/cart_screen.dart';
import 'package:veterinarskastanicamobile/screens/products/product_details_screen.dart';
import 'package:veterinarskastanicamobile/screens/products/product_list_screen.dart';
import 'package:veterinarskastanicamobile/screens/services/service_details_screen.dart';
import 'package:veterinarskastanicamobile/screens/services/services_screen.dart';
import 'package:veterinarskastanicamobile/screens/user/user_screen.dart';
import 'package:veterinarskastanicamobile/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import '.env';
import 'model/user.dart';
import 'providers/user_provider.dart';

void main() {
  WidgetsFlutterBinding.ensureInitialized();
  Stripe.publishableKey =
      stripePublishableKey; // Replace with your Stripe publishable key

  runApp(MultiProvider(
    providers: [
      ChangeNotifierProvider(create: (_) => ProductProvider()),
      ChangeNotifierProvider(create: (_) => UserProvider()),
      ChangeNotifierProvider(create: (_) => CartProvider()),
      ChangeNotifierProvider(create: (_) => OrderProvider()),
      ChangeNotifierProvider(create: (_) => ServiceProvider()),
    ],
    child: MaterialApp(
      debugShowCheckedModeBanner: true,
      theme: ThemeData(
        brightness: Brightness.light,
        primaryColor: Colors.deepPurple,
        textButtonTheme: TextButtonThemeData(
          style: TextButton.styleFrom(
            foregroundColor: Colors.deepPurple,
            textStyle: const TextStyle(
              fontSize: 24,
              fontWeight: FontWeight.bold,
              fontStyle: FontStyle.italic,
            ),
          ),
        ),
        textTheme: const TextTheme(
          displayLarge: TextStyle(fontSize: 72.0, fontWeight: FontWeight.bold),
          titleLarge: TextStyle(fontSize: 36.0, fontStyle: FontStyle.italic),
        ),
      ),
      home: HomePage(),
      onGenerateRoute: (settings) {
        if (settings.name == ProductListScreen.routeName) {
          return MaterialPageRoute(
              builder: (context) => const ProductListScreen());
        } else if (settings.name == CartScreen.routeName) {
          return MaterialPageRoute(builder: (context) => const CartScreen());
        } else if (settings.name == ServiceListScreen.routeName) {
          return MaterialPageRoute(
              builder: (context) => const ServiceListScreen());
        } else if (settings.name == UserDetailsScreen.routeName) {
          return MaterialPageRoute(
              builder: (context) => const UserDetailsScreen());
        }

        var uri = Uri.parse(settings.name!);
        if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == ProductDetailsScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => ProductDetailsScreen(id));
        } else if (uri.pathSegments.length == 2 &&
            "/${uri.pathSegments.first}" == ServiceDetailsScreen.routeName) {
          var id = uri.pathSegments[1];
          return MaterialPageRoute(
              builder: (context) => ServiceDetailsScreen(id));
        }
        return null;
      },
    ),
  ));
}

class HomePage extends StatelessWidget {
  final TextEditingController _usernameController = TextEditingController();
  final TextEditingController _passwordController = TextEditingController();

  HomePage({super.key});

  @override
  Widget build(BuildContext context) {
    final userProvider = Provider.of<UserProvider>(context, listen: false);

    return Scaffold(
      appBar: AppBar(
        title: const Text("Veterinarska stanica"),
      ),
      body: SingleChildScrollView(
        child: Column(
          children: [
            Container(
              height: 400,
              decoration: const BoxDecoration(
                image: DecorationImage(
                  image: AssetImage("assets/images/index.png"),
                  fit: BoxFit.fill,
                ),
              ),
              child: Stack(
                children: [
                  Positioned(
                    left: 120,
                    top: 0,
                    width: 80,
                    height: 120,
                    child: Container(),
                  ),
                  Positioned(
                    right: 40,
                    top: 0,
                    width: 80,
                    height: 120,
                    child: Container(),
                  ),
                ],
              ),
            ),
            Padding(
              padding: const EdgeInsets.all(40),
              child: Container(
                decoration: BoxDecoration(
                  color: Colors.white,
                  borderRadius: BorderRadius.circular(10),
                ),
                child: Column(
                  children: [
                    Container(
                      padding: const EdgeInsets.all(8),
                      decoration: const BoxDecoration(
                        border: Border(bottom: BorderSide(color: Colors.grey)),
                      ),
                      child: TextField(
                        controller: _usernameController,
                        decoration: InputDecoration(
                          border: InputBorder.none,
                          hintText: "Korisničko ime",
                          hintStyle: TextStyle(color: Colors.grey[400]),
                        ),
                      ),
                    ),
                    Container(
                      padding: const EdgeInsets.all(8),
                      child: TextField(
                        controller: _passwordController,
                        obscureText: true,
                        decoration: InputDecoration(
                          border: InputBorder.none,
                          hintText: "Lozinka",
                          hintStyle: TextStyle(color: Colors.grey[400]),
                        ),
                      ),
                    ),
                  ],
                ),
              ),
            ),
            const SizedBox(height: 2),
            Container(
              height: 50,
              margin: const EdgeInsets.fromLTRB(40, 0, 40, 0),
              decoration: BoxDecoration(
                borderRadius: BorderRadius.circular(10),
                gradient: const LinearGradient(
                  colors: [
                    Color.fromRGBO(143, 148, 251, 1),
                    Color.fromRGBO(143, 148, 251, .6)
                  ],
                ),
              ),
              child: InkWell(
                onTap: () async {
                  try {
                    Authorization.username = _usernameController.text;
                    Authorization.password = _passwordController.text;

                    var data = await userProvider.get();
                    User user = data.firstWhere(
                      (element) =>
                          element.korisnickoIme == Authorization.username,
                    );

                    SharedPreferences prefs =
                        await SharedPreferences.getInstance();
                    await prefs.setString(
                        'korisnikId', user.korisnikId!.toString());

                    Navigator.pushNamed(context, ProductListScreen.routeName);
                  } catch (e) {
                    showDialog(
                      context: context,
                      builder: (BuildContext context) => AlertDialog(
                        title: const Text("Error"),
                        content: Text(e.toString()),
                        actions: [
                          TextButton(
                            child: const Text("Ok"),
                            onPressed: () => Navigator.pop(context),
                          ),
                        ],
                      ),
                    );
                  }
                },
                child: const Center(child: Text("Pristup sistemu")),
              ),
            ),
          ],
        ),
      ),
    );
  }
}
