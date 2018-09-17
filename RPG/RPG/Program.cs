using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsClassLibrary;
using PlayerClassLibrary;
namespace RPG
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            List<Player> ListPlayer = new List<Player>();
            List<Weapon> ListWeapon = new List<Weapon>();
            int parseResult;
            //CreatePlayer
            DisplayMainMenu();

            void CreatePlayer()
            {
                string pName;
                string wName;
                int HP;
                int AP;
                int attack;
                string input;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter Name");
                    pName = Console.ReadLine();
                } while (pName == "");
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter Health Total");
                } while (!IntParse(Console.ReadLine()));
                HP = parseResult;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter Action Point Total");
                } while (!IntParse(Console.ReadLine()));
                AP = parseResult;
                ListPlayer.Add(new Player(pName, HP, AP));
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter Weapon Name");
                    wName = Console.ReadLine();
                } while (wName == "");

                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter Weapon Attack");
                } while (!IntParse(Console.ReadLine()));
                attack = parseResult;
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Melee");
                    Console.WriteLine("2. Ranged");
                    input = Console.ReadLine();
                } while (input != "1" && input != "2" );

                switch (input)
                {
                    case "1":
                        ListWeapon.Add(new Melee(wName, attack));
                        break;
                    case "2":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Weapon Range");
                        } while (!IntParse(Console.ReadLine()));
                        ListWeapon.Add(new Ranged(wName, parseResult, attack));
                        break;
                }
                
            }

            void DisplayMainMenu()
            {
                Console.Clear();
                Console.WriteLine("1. Create Player");
                Console.WriteLine("2. Start");
                Console.WriteLine("3. Quit");
                string menuInput = Console.ReadLine();
                switch (menuInput)
                {
                    case "1":
                        CreatePlayer();
                        break;
                    case "2":
                        //Function With Main Code
                        break;
                    case "3":
                        Console.WriteLine("Click the Cross in the top right. The red one.");
                        do
                        {
                            //stuffing
                        } while (true);
                    default:
                        DisplayMainMenu();
                        break;
                }
            }

            bool IntParse(string input)
            {
                if(int.TryParse(input, out parseResult))
                {
                    return true;
                }
                else return false;

            }
        }
    }
}
