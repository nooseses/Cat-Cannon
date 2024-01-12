using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Cat_Cannon_wipe_out
{

    //hello its me mink i will be commenting a little bit
    internal class Program
    {
        static void Main(string[] args)
        {
            int GunPowder = 6; //this means cats in the gun idk why my companion called it gunpowder
            int NeededPowder = 0; //this is the amount if cats you need to reload
            int PocketCats = 30; //the amount of cats in your pockets that youc an use to reload
            bool emptyPockets = false; //checks if you still have cats in your pockets
            string ui;

            Console.WriteLine("type pew to shoot and type reload to reload");
            //CatCannon();
            void CatCannon()
            {
                ui = Console.ReadLine();
                if (ui == "pew" || ui == "reload") // this means that if you type pew or reload the program will respond to these things
                {
                    if (ui == "pew")
                    {
                        if (GunPowder != 0) // if the cats in the gun
                        {
                            GunPowder--;
                            Console.WriteLine(GunPowder);
                            NeededPowder++;
                            ui = "no";
                            CatCannon(); // this shoots 1 cat out of the cat cannon, very nice
                        }
                        else if (GunPowder == 0)
                        {
                            Console.WriteLine("you need to reload, idiot"); // this insults you if you are stupid enough to try to shoot an empty cannon, reload the gun!
                            CatCannon();
                        }
                    }
                    else if (ui == "reload")
                    {
                        if (PocketCats > 6) // if its smaller than 6
                        {
                            PocketCats -= NeededPowder; //the needed cats to reload the gun are subtracted from your pocket
                            Console.WriteLine("reloading");

                            GunPowder += NeededPowder;
                            Console.WriteLine($"you now have {PocketCats} cats in your cannon");
                            Console.WriteLine($"you have {PocketCats} cats left in your pocket");
                            NeededPowder = 0;
                            ui = "no";
                            CatCannon();
                        }
                        if (PocketCats > 0)
                        {
                            GunPowder += PocketCats;
                            PocketCats = 0;
                            Console.WriteLine(GunPowder);
                            Console.WriteLine(PocketCats);
                            NeededPowder = 0;
                            ui = "no";
                            CatCannon();
                        }
                        if (PocketCats <= 0)
                        {
                            ui = "no";
                            emptyPockets = true;
                        }
                        else if (emptyPockets == true)
                            Console.WriteLine("you are out of pocket cats loser");
                        Console.WriteLine("spits on you");
                    }
                }
                else
                {
                    Console.WriteLine("type pew to shoot and type reload to reload");
                    CatCannon();
                }
            }



            Random rnd = new Random();
            int loaded = rnd.Next(1, 6);
            string player1;
            string player2;
            int turn = 1;
            string iu;
            Roullete();
            void Roullete()
            {
                Console.Write("please enter player 1's name "); player1 = Console.ReadLine();
                Console.Write("please enter player 2's name "); player2 = Console.ReadLine();
                game();
                void game()
                {
                    if (turn == 0 || turn == 2 || turn == 4)
                    {
                        Console.WriteLine(player1 + " please say bang to shoot");
                        iu = Console.ReadLine();
                        if (iu == "bang")
                        {
                            if (turn == loaded)
                            {
                                Console.WriteLine($"Welcome to heaven, {player2}. " + player1 + " won");
                            }
                            else { Console.WriteLine("nothing..."); turn++; game(); }
                        }
                        else { Console.WriteLine("that was not an option try again"); game(); }
                    }
                    else if (turn == 1 || turn == 3 || turn == 5)
                    {
                        Console.WriteLine(player2 + " please say bang to shoot");
                        iu = Console.ReadLine();
                        if (iu == "bang")
                        {
                            if (turn == loaded)
                            {
                                Console.WriteLine($"Welcome to hell, {player1}. " + player2 + " won");
                            }
                            else { Console.WriteLine("nothing..."); turn++; game(); }
                        }
                        else { Console.WriteLine("that was not an option you silly billy, you are now disqualified"); game(); }
                    }
                }
            }
        }
    }
}