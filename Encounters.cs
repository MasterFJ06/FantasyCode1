using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantacyCode1
{
    internal class Encounters
    {
        static Random rand = new Random();
        //Encounter Generic


        //Encounters
        public static void FirstEncounter()
        {
            Console.WriteLine("You run behind a tree to take cover and there you find a LONG STICK ");
            Console.WriteLine("Now you gather up the courage to fight the monster...");
            Console.ReadKey();
            Combat(false,"A Spooky Tree",2,6);
        }


        //Encounter tools
        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {


            }
            else 
            {
                n = name;
                p = power;
                h = health;

            }
            while (h>0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine("Power = "+p +" / health = "+ h);

                Console.WriteLine("==============================");
                Console.WriteLine("|   (A)ttack      (D)fend    |");
                Console.WriteLine("|   (R)un         (H)eal     |");
                Console.WriteLine("==============================");
                Console.WriteLine("Potions :"+ Program.Player.potion + "  Health :"+ Program.Player.health);
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //attack
                    Console.WriteLine("You charge forward with courage and slash the " + n + ". and he also hits you as u pass near him");
                    int damage = p - Program.Player.armor;
                    int attack = rand.Next(0, Program.Player.weaponValue) + rand.Next(1,4);
                    Console.WriteLine("You lose "+ damage +" Health while you deal "+ attack +" damage to your enemy");
                    Program.Player.health -= damage;
                    h -= attack;

                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //defend
                    Console.WriteLine("As the " + n + " dives in to strike you, you form a defensive stance and are able to defend from enemies attack");
                    int damage = (p/4) - Program.Player.armor;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.Player.weaponValue)/2;

                    Console.WriteLine("You lose " + damage + " Health while you deal " + attack + " damage to your enemy");
                    Program.Player.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //run
                    if ( rand.Next(0,2) == 0 )
                    {
                        Console.WriteLine("As you try to RUN the "+n+" caught  you again.");
                        int damage = p - Program.Player.armor;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose "+ damage +" Health as you desperately try to escape");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You Outrun the Monster and succesfully escape.. !");
                        Console.ReadKey();
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //heal
                    if (Program.Player.potion == 0)
                    {
                        Console.WriteLine("You've got no potions noww...GET BACK !!");
                        int damage = p - Program.Player.armor;
                        if (damage < 0)
                            damage = 0;

                        Console.WriteLine("As you were trying to find a potion the " + n + " sneaked up and striked you.");
                        Console.WriteLine("And you lost " + damage + " Health.");
                    }
                    else 
                    { 
                        Console.WriteLine("You grabbed a bottle of potion and drank it..");
                        int potionvalue = 5;
                        Console.WriteLine("You gain "+potionvalue+" Health..");
                        Program.Player.health += potionvalue;
                        Console.WriteLine("As you were busy drinking the potion the "+n+" took the chance and struck.");
                        int damage = (p - Program.Player.armor) / 2;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lost "+ damage +" Health.");
                    }
                }

                Console.ReadKey();
            }

        }


    }
}
