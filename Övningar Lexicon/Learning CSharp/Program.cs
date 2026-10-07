
using Learning_CSharp;

int age = 30;
int monthlyWage = 15;
int bonus = 2;

Console.WriteLine($"Månadslön: {Utilities.MultiplyNumbers(age, monthlyWage)}");
Console.WriteLine($"Månadslön med bonus: {Utilities.MultiplyNumbers(age, monthlyWage, bonus)}");

string myString = "Hello my name is Johanna";
string subString = myString.Substring(1, 4);
Console.WriteLine(subString);
