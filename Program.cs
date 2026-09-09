//Day Two Variable Lecture

//Console.Clear clears our terminal
Console.Clear();

//Console.WriteLine Prints out to our terminal / console
Console.WriteLine("Welcome to Day 2!");

//Console.Write Prints out to our terminal / console without a line break after
Console.Write("Enter Your Name: ");

//This allows the user to type into the console
Console.ReadLine();
//string name = Console.ReadLine();

//What is a Variable

//A Variable is a Box that can store Values.
//There are several Data Types within C#

//string data types are text between double quotes "";
//To declare a string Variable, we need to type string before the Variable and then assign it a value.
string album = "Crush 40"; //We areinitializing a string with a value
//string name; //Declaring a string. We are not giving it a value

//Number Data Types
//Think of integers as whole numbers
int age = 18;

//Double can go up to 15-17 digits
double chiptoleBurrito = 14.45;

//Boolean Data Type represent
bool isItColdInHere = true; //Camel Case is when you have multiple words in a variable name. First word is lowercase

Console.WriteLine(isItColdInHere);

//Concatenation is our first way to Join Text / strings
Console.WriteLine("Isreal " + "Espinoza");

string firstName = "Zionn";
string lastName = "Showers";

Console.WriteLine(firstName + " " + lastName);

string fullName = "Jose" + " " + "Martinez";

Console.WriteLine(fullName);

//string Interpolation is combine strings, but we use $ {} to add variables within the string

Console.WriteLine("One of CodeStacks Intructors is " + fullName);
Console.WriteLine($"One of CodeStacks Instructors is {fullName}");

Console.WriteLine("Please Enter The Number 45");

//ReadLine can only be a string
//int num = Console.ReadLine();
string num = Console.ReadLine();