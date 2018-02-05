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

            //count is a property.
            Console.WriteLine(drinkMachine.Count);

        }
    }
}
