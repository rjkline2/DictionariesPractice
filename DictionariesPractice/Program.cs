using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syntax - Dictionary<key data type, value data type> dictionaryName
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                {"Kerry", 90 },
                {"Barry", 85 },
                {"Michelle", 100 }
            };

            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1", "Snickers" },
                {"A2" , "Swedish Fish"},
                {"A3", "Sourpatch Kids" },
                {"A4", "Funyuns" }
            };

            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            // Empty dictionary
            //Using add method, let's add drinks to our drink machine...
            //a letter-number pair

            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Coke");
            drinkMachine.Add(12, "Pepsi");
            drinkMachine.Add(13, "Sunkist");
            drinkMachine.Add(14, "Sierra Mist");
            drinkMachine.Add(15, "LeCroix");

            //count is a property. Returns dictonary size.
            Console.WriteLine(drinkMachine.Count);

            //We have another property, called .Key
            foreach(KeyValuePair<int,string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
            }
            foreach(KeyValuePair<int,string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value);
            }

            //create a dictionary for a theater coat check with 10 elements
            //The key will be a number and the value will bethe coat style.
            //Print all vaues to the console. 
            Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            {

                { 1, "Leather Jacket"},
                { 2, "Trench Coat"},
                { 3, "Navy Peacoat"},
                { 4, "Varsity Jacket"},
                { 5, "Leather Duster"},
                { 6, "Windbreaker"},
                { 7, "Travel Jacket"},
                { 8, "Leather Jacket"},
                {9, "Fleece Jacket" },
                { 10, "Hooded Sweatshirt"}

            };
                foreach(KeyValuePair<int, string> coats in coatCheck)
                {
                    Console.WriteLine(coats.Value);
                }

            //Car valet, last name, the make of car. 10 cars. print all keys to the console
            Dictionary<string, string> carValet = new Dictionary<string, string>()
            {
                { "Kline", "Corvet"},
                { "Corbet", "Ford Truck"},
                { "Dresden", "VW Bug"},
                { "Terrpin", "Police Car"},
                { "Tomiko", "Camry"},
                { "McClintok", "Chevy Blazer"},
                { "Jones", "Packard Sedan"},
                { "King", "Hummer, Red"},
                {"Stark", "Acura, also Red" },
                { "Rogers", "Harley Motorcycle"}

            };

            foreach(KeyValuePair<string, string> cars in carValet)
            {
                Console.WriteLine(cars.Key);
            }
            //Zoo Animals, 10 of them, key is animal type, value is number of that type. Print the number of the highest quantity.

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
            {
                {"Rhino", 90 },
                {"Lions", 85 },
                {"Tigers", 10 },
                {"Bears", 10 },
                {"Crows", 85 },
                {"Ravens", 100 },
                {"Monkeys", 90 },
                {"Aligators", 58 },
                {"Snakes", 100 },
                {"Iguanas", 30 }
            };

            foreach (var item in zooAnimals.OrderByDescending(key => key.Value))
            {
                Console.WriteLine(item);
            }

            Dictionary<string, int> zoo = new Dictionary<string, int>()
            {
                {"Lion",4 },
                {"Tiger",5 },
                {"Bear, Black",3 },
                {"Bear, Grizzly",2 },
                {"Wolf",10 },
                {"Flamingo",15 },
                {"Elephant",6 },
                {"Hippo",5 },
                {"Rhino, White",4 },
                {"Gorrilla",8 }
            };
            int highest = 0;
            foreach (KeyValuePair<string, int> animal in zoo)
            {
                if (animal.Value > highest)
                {
                    highest = animal.Value;
                }
            }
            foreach (KeyValuePair<string, int> animal in zoo)
            {
                if (animal.Value == highest)
                {
                    Console.WriteLine(animal.Key);
                }
            }



        }
    }
}
