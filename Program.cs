using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantacyCode1
{
    internal class Program
    {
        public static Player Player = new Player();
        static void Main(string[] args)
        {
            Start();
            Encounters.FirstEncounter();
        }

        static void Start()
        {
            Console.WriteLine("Magical Forest");
            Console.WriteLine("Name:");
            Console.ReadLine();
            Player.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You wake up in a magical forest..., you feel dizzy and are having trouble remembering");
            Console.WriteLine("anything about your past.");
            if (Player.name == "")
                Console.WriteLine("You know your name is " + Player.name);
            else
                Console.WriteLine("You cant even remember your name.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You try to search for anything helpful until you see a pathway leading to something.");
            Console.WriteLine("you follow the pathway through the dark and tall forest in hopes of getting out but...");
            Console.ReadKey();
            Console.WriteLine("There you see a monstrous figure standing before you in the dark.");
        }
    }
}
