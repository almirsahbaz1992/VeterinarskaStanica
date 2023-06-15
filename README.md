# VeterinarskaStanica
## Seminar work for course "Development of software 2"

### Instructions for starting the main project and desktop application:

1. Please use command prompt to position your current location to location of the folder that contains project.

2. Start your docker desktop application.

3. Enter following command: **docker-compose up --build**, and let the command prompt finish loading all the data.

4. After data loading please open project in folder **VeterinarskaStanica** by clicking on **VeterinarskaStanica.sln** file.

5. After Visual Studio load all of the data, please click on the arrow beside Start button the command ribbon and choose **"Configure Startup Projects.."**.

6. In the next window choose option **"Multiple startup projects"** and then choose Start option in Action row beside **"VeterinarskaStanica"** and **"VeterinarskaStanica.WinUI"** and then click on OK.

7. Now you can start the project by clicking on the **Start button** in command ribbon.

8. After your browser loads, please go to the folowing link **"http://localhost:5192/swagger/index.html"**.

9. Click on the authorize button and enter following credentials: **Username: admin, Password: admin**.

10. Before starting the main application, please go to the following link to activate recommenation system: **"http://localhost:5192/Proizvodi/1/Recommend"**, then reload page once more to get training data.

11. Now you can login to desktop application using credentials: **Username: admin, Password: admin**.


### Instructions for starting mobile application:

1. Open folder containtaning mobile app project via Visual Studio Code.

2. Run following command via terminal **"flutter pub get"**.

3. Start your Android emulator and when it loads, plase click on the run option in the Visual Studio ribbon menu and choose option **"Start Debugging"** of simply tap on **F5 button** on your keyboard.

4. Let the project load inside your emulator.

5. When you first start the mobile app you might get error in the terminal about some Facebook file inside the project, please ignore the message, and let the project load to your emulator.

6. Login credentials are: **Korisničko ime: admin, Lozinka: admin**.

7. Please be sure that you followed step 10 in the previous instructions before clicking on any of the products in the list.

8. Now you can buy products or make reservations.

9. You need to use test card number: **4242 4242 4242 4242, date od issuing the card and CVC number are provisional, and ZIP code is also provisional, but you need to enter 5 digits**.