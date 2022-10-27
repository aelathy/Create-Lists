// Lists
#nullable disable
Console.Clear();

Random rnd = new Random();


// Months that Start with J
List<string> jMonths = new List<string>() { "January", "June", "July" };
// 700 Occurences of Joy
List<string> joyList = new List<string>();
for (int i = 0; i < 700; i++)
{
    joyList.Add("joy");
}
foreach (string joy in joyList)
{
    Console.WriteLine(joy);
}
// 500 Occurences of 7
List<int> listOfSevens = new List<int>();
for (int i = 0; i < 500; i++)
{
    listOfSevens.Add(7);
}
foreach (int seven in listOfSevens)
{
    Console.WriteLine(seven);
}
// 5000 Random Integers Between 0 (inclusive) and 100 (exclusive)
List<int> zeroToHundred = new List<int>();
for (int i = 0; i < 5000; i++)
{
    zeroToHundred.Add(rnd.Next(0, 100));
}
foreach (int randInt in zeroToHundred)
{
    Console.WriteLine(randInt);
}
// 300 Random Integers Between 0 (inclusive) and 40 (exclusive)
List<int> zeroToForty = new List<int>();
for (int i = 0; i < 300; i++)
{
    zeroToForty.Add(rnd.Next(0, 40));
}
foreach (int randInt in zeroToForty)
{
    Console.WriteLine(randInt);
}
// Multiples of 4 Between 20 and 800, Inclusive
List<int> upBy4 = new List<int>() { 20 };
for (int i = 0; i < 195; i++)
{
    upBy4.Add(upBy4[i] + 4);
}
foreach (int multipleOf4 in upBy4)
{
    Console.WriteLine(multipleOf4);
}
// Even Numbers from 100 to 10, inclusive
List<int> hundredToTen = new List<int>() { 100 };
for (int i = 0; i < 45; i++)
{
    hundredToTen.Add(hundredToTen[i] - 2);
}
foreach (int evenNum in hundredToTen)
{
    Console.WriteLine(evenNum);
}
// Split String using Comma as Seperator Token
string colorsStr = "red,orange,yellow,green,blue,indigo,violet";
List<string> colors = colorsStr.Split(",").ToList<string>();
foreach (string color in colors)
{
    Console.WriteLine(color);
}
// Split String using Semicolon as Seperator
string citiesStr = "Edmonton;Calgary;Vancouver;Saskatoon;Winnipeg";
List<string> cities = citiesStr.Split(";").ToList<string>();
foreach (string city in cities)
{
    Console.WriteLine(city);
}
// Add Names to List
List<string> names = new List<string>();
bool loop = true;
while (loop)
{
    Console.Write("What would you like to add?: ");
    string nameAdded = Console.ReadLine();
    names.Add(nameAdded);
    Console.WriteLine("done");
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
    if (nameAdded == "exit")
    {
        break;
    }
}

