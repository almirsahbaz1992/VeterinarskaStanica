import 'package:veterinarskastanicamobile/model/usluge.dart';
import 'package:veterinarskastanicamobile/providers/services_provider.dart';
import 'package:veterinarskastanicamobile/screens/services/service_details_screen.dart';
import 'package:veterinarskastanicamobile/utils/util.dart';
import 'package:veterinarskastanicamobile/widgets/master_screen.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class ServiceListScreen extends StatefulWidget {
  static const String routeName = "/service";

  const ServiceListScreen({Key? key}) : super(key: key);

  @override
  State<ServiceListScreen> createState() => _ServiceListScreen();
}

class _ServiceListScreen extends State<ServiceListScreen> {
  ServiceProvider? _serviceProvider;
  List<Service> data = [];
  final TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _serviceProvider = context.read<ServiceProvider>();
    //print("called initState");
    loadData();
  }

  Future loadData() async {
    var tmpData = await _serviceProvider?.get(null);
    setState(() {
      data = tmpData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    // print("called build $data");
    return MasterScreenWidget(
        child: SingleChildScrollView(
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          _buildHeader(),
          _buildProductSearch(),
          SizedBox(
            // Wrap the GridView with Container
            width: double.infinity, // Set width to expand to full width
            height: 500, // Set desired height for the GridView
            child: GridView(
              gridDelegate: const SliverGridDelegateWithFixedCrossAxisCount(
                crossAxisCount: 1,
                childAspectRatio: 4 / 1,
                mainAxisSpacing: 5,
              ),
              scrollDirection: Axis.vertical,
              children: _buildProductCardList(),
            ),
          ),
        ],
      ),
    ));
  }

  Widget _buildHeader() {
    return Container(
      padding: const EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: const Text(
        "Usluge",
        style: TextStyle(
            color: Colors.grey, fontSize: 40, fontWeight: FontWeight.w600),
      ),
    );
  }

  Widget _buildProductSearch() {
    return Row(
      children: [
        Expanded(
          child: Container(
            padding: const EdgeInsets.symmetric(horizontal: 20, vertical: 10),
            child: TextField(
              controller: _searchController,
              onSubmitted: (value) async {
                var tmpData = await _serviceProvider?.get({'naziv': value});
                setState(() {
                  data = tmpData!;
                });
              },
              decoration: InputDecoration(
                  hintText: "Pretraga",
                  prefixIcon: const Icon(Icons.search),
                  border: OutlineInputBorder(
                      borderRadius: BorderRadius.circular(10),
                      borderSide: const BorderSide(color: Colors.grey))),
            ),
          ),
        ),
        // Container(
        //   padding: const EdgeInsets.symmetric(horizontal: 20, vertical: 10),
        //   child: IconButton(
        //     icon: const Icon(Icons.filter_list),
        //     onPressed: () async {
        //       var tmpData = await _productProvider
        //           ?.get({'naziv': _searchController.text});
        //       setState(() {
        //         data = tmpData!;
        //       });
        //     },
        //   ),
        // )
      ],
    );
  }

  List<Widget> _buildProductCardList() {
    if (data.isEmpty) {
      return [const Text("Loading...")];
    }

    List<Widget> list = data
        .map(
          (x) => GestureDetector(
            onTap: () {
              Navigator.pushNamed(
                context,
                "${ServiceDetailsScreen.routeName}/${x.uslugaId}",
              );
            },
            child: Container(
              padding: const EdgeInsets.all(20),
              child: Row(
                crossAxisAlignment: CrossAxisAlignment.center,
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  SizedBox(
                    height: 125,
                    width: 125,
                    child: imageFromBase64String(x.slika!),
                  ),
                  const SizedBox(
                    width: 10,
                  ), // Add spacing between the image and the text
                  Expanded(
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          x.naziv ?? "",
                          style: const TextStyle(
                            color: Colors.black,
                            fontSize: 22,
                            fontWeight: FontWeight.bold,
                          ),
                        ),
                        const SizedBox(
                          height: 10,
                        ), // Add spacing between the title and other details
                        Text(
                          formatNumber(x.cijena),
                          style: const TextStyle(
                            color: Colors.redAccent,
                            fontSize: 16,
                            fontWeight: FontWeight.bold,
                          ),
                        ),
                      ],
                    ),
                  ),
                  // IconButton(
                  //   icon: const Icon(Icons.shopping_cart),
                  //   onPressed: () {
                  //     _cartProvider?.addToCart(x);
                  //   },
                  // ),
                ],
              ),
            ),
          ),
        )
        .cast<Widget>()
        .toList();

    return list;
  }
}
