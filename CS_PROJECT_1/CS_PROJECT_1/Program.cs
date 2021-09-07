using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_PROJECT_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = null;
            House house = new House(4, 1, 4);

            try
            {
                team = new Team(4);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }

            team.BuildHouse(house);


            Console.WriteLine("Строительство дома завершено.\n");
            Console.WriteLine();
            Console.WriteLine("  _____| |_________");
            Console.WriteLine(" //////////////////\\");
            Console.WriteLine("////////////////    \\");
            Console.WriteLine("|              |    |");
            Console.WriteLine("|        __    |    |"); 
            Console.WriteLine("|  []   |  |   | [] | ");
            Console.WriteLine("|       |  |   |    |");
            Console.WriteLine("|       |  |   |    |");
            Console.ReadKey();

        }
    }
}
