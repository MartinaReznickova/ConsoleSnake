# ConsoleSnake
Jeden z mých prvních "větších" projektů v C#. Klasická arkádová hra the Snake ovládaná pomocí šipek s úvodní i závěrečnou obrazovkou a hudbou na pozadí podporovanou ve Windows OS.

EN: One of my first "bigger" projects in C#. Classic arcade game the Snake controlled by arrows with opening and closing screens and background music supported on Windows OS.

# Mistakes/Failures
Tento projekt byl zpočátku jen můj pokus o vytvoření jednoduché obrazovky s pohybujícím se "hadem", a protože to neměl být žádný velký projekt, neměla jsem tento program dopředu dobře promyšlený, a tak v samotném návrhu vidím prostor pro zlepšení. :sweat_smile: Další chybou je pak používání třídy AbstractObrazovka, jakoby se jednalo o abstrakní třídu (nevytvářím z ní instance, dědičnost...), aniž by tato třída byla jako abstrakní označená a aniž by měla alespoň jednu virtuální metodu.

EN: This project was initially just my attempt to create a simple screen with a moving "snake," and because it wasn't supposed to be a big project, I didn't plan this program well in advance. So, in the design itself, I see room for improvement. 😅 Another mistake is using the AbstractScreen class as if it were an abstract class (I'm not creating instances from it, no inheritance...), without this class being marked as abstract and without it having at least one virtual method.

# Challenges
Asi největší challenge pro mě bylo vytvořit plynulou konzolovou aplikaci, která neustále neproblikává což se mi nakonec i povedlo a v tomto ohledu jsem s výsledkem spokojená. :muscle:

EN: The biggest challenge for me was to create a smooth console application that doesn't constantly flicker, and I must say that I'm satisfied with the outcome. 💪

# Screenshots
![SnakeUvodniMenu](https://github.com/MartinaReznickova/ConsoleSnake/assets/139158101/75ba6668-dd17-4309-a611-9f00b6f8825a)
![SnakeNastaveniRychlostiObrazovka](https://github.com/MartinaReznickova/ConsoleSnake/assets/139158101/b7fb8c11-2c16-4f3f-8f47-29d29775d110)
![SnakeHra2](https://github.com/MartinaReznickova/ConsoleSnake/assets/139158101/d079eb3d-8f5b-4052-b837-e93adb14632b)
![SnakeGameOverObrazovka](https://github.com/MartinaReznickova/ConsoleSnake/assets/139158101/9054dc67-e773-4d7e-b895-aa000df4ddc2)
![SnakeAboutObrazovka](https://github.com/MartinaReznickova/ConsoleSnake/assets/139158101/b4fc2f11-fa8c-4f76-b47c-2ce5668eaec6)

