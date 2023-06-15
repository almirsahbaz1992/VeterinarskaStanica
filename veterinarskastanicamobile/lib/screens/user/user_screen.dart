import 'package:flutter/material.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'package:veterinarskastanicamobile/model/user.dart';
import 'package:veterinarskastanicamobile/providers/user_provider.dart';

class UserDetailsScreen extends StatefulWidget {
  static const String routeName = "/user_details";

  const UserDetailsScreen({Key? key}) : super(key: key);

  @override
  _UserDetailsScreenState createState() => _UserDetailsScreenState();
}

class _UserDetailsScreenState extends State<UserDetailsScreen> {
  @override
  void initState() {
    super.initState();
    loadData();
  }

  final TextEditingController imeController = TextEditingController();
  final TextEditingController prezimeController = TextEditingController();
  final TextEditingController emailController = TextEditingController();
  final TextEditingController telefonController = TextEditingController();
  bool isEditMode = false;
  bool isPasswordMode = false;
  int korisnikId = 0;
  final TextEditingController passwordController = TextEditingController();
  final TextEditingController confirmPasswordController =
      TextEditingController();
  final UserProvider userProvider = UserProvider();
  User? user;
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('User Details'),
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            if (!isPasswordMode) ...[
              const Text(
                'First Name',
                style: TextStyle(
                  fontSize: 16,
                  fontWeight: FontWeight.bold,
                ),
              ),
              TextFormField(
                controller: imeController,
                enabled: isEditMode,
                decoration: const InputDecoration(
                  hintText: 'Enter your first name',
                ),
              ),
              const SizedBox(height: 16),
              const Text(
                'Last Name',
                style: TextStyle(
                  fontSize: 16,
                  fontWeight: FontWeight.bold,
                ),
              ),
              TextFormField(
                controller: prezimeController,
                enabled: isEditMode,
                decoration: const InputDecoration(
                  hintText: 'Enter your last name',
                ),
              ),
              const SizedBox(height: 16),
              const Text(
                'Email',
                style: TextStyle(
                  fontSize: 16,
                  fontWeight: FontWeight.bold,
                ),
              ),
              TextFormField(
                controller: emailController,
                enabled: isEditMode,
                decoration: const InputDecoration(
                  hintText: 'Enter your email',
                ),
              ),
              const SizedBox(height: 16),
              const Text(
                'Phone Number',
                style: TextStyle(
                  fontSize: 16,
                  fontWeight: FontWeight.bold,
                ),
              ),
              TextFormField(
                controller: telefonController,
                enabled: isEditMode,
                decoration: const InputDecoration(
                  hintText: 'Enter your phone number',
                ),
              ),
              const SizedBox(height: 16),
            ],
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
              children: [
                if (!isPasswordMode) ...[
                  ElevatedButton(
                    onPressed: () {
                      if (isEditMode) {
                        userProvider.update(korisnikId, {
                          "ime": imeController.text,
                          "prezime": prezimeController.text,
                          "email": emailController.text,
                          "telefon": telefonController.text,
                          "password": "string",
                          "passwordPotvrda": "string",
                          "status": true
                        });
                      }
                      setState(() {
                        isEditMode = !isEditMode;
                      });
                    },
                    child: Text(isEditMode ? 'Save' : 'Edit Details'),
                  ),
                ],
                ElevatedButton(
                  onPressed: () {
                    setState(() {
                      isPasswordMode = !isPasswordMode;
                    });
                  },
                  child: Text(isPasswordMode ? 'Cancel' : 'Change Password'),
                ),
              ],
            ),
            if (isPasswordMode) ...[
              const SizedBox(height: 16),
              const Text(
                'New Password',
                style: TextStyle(
                  fontSize: 16,
                  fontWeight: FontWeight.bold,
                ),
              ),
              TextFormField(
                controller: passwordController,
                obscureText: true,
                decoration: const InputDecoration(
                  hintText: 'Enter your new password',
                ),
              ),
              const SizedBox(height: 16),
              const Text(
                'Confirm Password',
                style: TextStyle(
                  fontSize: 16,
                  fontWeight: FontWeight.bold,
                ),
              ),
              TextFormField(
                controller: confirmPasswordController,
                obscureText: true,
                decoration: const InputDecoration(
                  hintText: 'Confirm your new password',
                ),
              ),
              const SizedBox(height: 16),
              ElevatedButton(
                onPressed: () {
                  // TODO: Implement password change logic
                  userProvider.update(korisnikId, {
                    "ime": imeController.text,
                    "prezime": prezimeController.text,
                    "email": emailController.text,
                    "telefon": telefonController.text,
                    "password": passwordController.text,
                    "passwordPotvrda": confirmPasswordController.text,
                    "status": true
                  }).then((_) {
                    // Password update successful, display a success message
                    showDialog(
                      context: context,
                      builder: (BuildContext context) {
                        return AlertDialog(
                          title: const Text('Success'),
                          content: const Text('Password changed successfully.'),
                          actions: <Widget>[
                            ElevatedButton(
                              child: const Text('OK'),
                              onPressed: () {
                                Navigator.of(context).pop();
                              },
                            ),
                          ],
                        );
                      },
                    );
                  }).catchError((error) {
                    // Password update failed, display an error message
                    showDialog(
                      context: context,
                      builder: (BuildContext context) {
                        return AlertDialog(
                          title: const Text('Error'),
                          content: const Text(
                              'Failed to change password. Please try again.'),
                          actions: <Widget>[
                            ElevatedButton(
                              child: const Text('OK'),
                              onPressed: () {
                                Navigator.of(context).pop();
                              },
                            ),
                          ],
                        );
                      },
                    );
                  });
                },
                child: const Text('Change Password'),
              ),
            ],
          ],
        ),
      ),
    );
  }

  void loadData() async {
    SharedPreferences prefs = await SharedPreferences.getInstance();
    String? id = prefs.getString('korisnikId');
    UserProvider userProvider = UserProvider();
    User? user = await userProvider.getById(int.parse(id!));
    setState(() {
      user = user;
      korisnikId = int.parse(id);
      imeController.text = user!.ime!;
      prezimeController.text = user!.prezime!;
      emailController.text = user!.email!;
      telefonController.text = user?.telefon ?? "000";
    });
  }
}
