using System;

namespace CommandProccesor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            string help = "echo - print what | keytest - test keys | texttest - test the text";
            string start = "Command processor Version: [1.1.0]";

            //Costumasition
            Console.ForegroundColor = ConsoleColor.White;

            //Start Commands
            Console.WriteLine(start);

            //Console Command Input
            while (true)
            {
                Console.WriteLine(" ");
                Console.Write("Command: ");
                string inpu = Console.ReadLine();

                //commands
                if (inpu == "exit")
                {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error please exit the window manually");
                Console.ForegroundColor = ConsoleColor.White;
                }
                if (inpu == "help")
                {
                Console.WriteLine(" ");
                Console.WriteLine(help);
                Console.WriteLine(" ");
                Console.WriteLine("exit - exiting the Window | ver - current version | clear - clear the promt");
                Console.WriteLine(" ");
                Console.WriteLine("beep - see what are going to do | palle - a little easteregg from my land");
                }
                if (inpu == "echo")
                {
                Console.WriteLine(" ");
                Console.Write("   What to echo: ");
                string echo = Console.ReadLine();
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   "+ echo);
                Console.ForegroundColor = ConsoleColor.White;
                }

                if (inpu == "ver")
                {
                Console.WriteLine(" ");
                Console.WriteLine("   "+ start);
                Console.WriteLine(" ");
                Console.WriteLine("   you are a beta tester");
                }

                if (inpu == "clear")
                {
                Console.Clear();
                Console.WriteLine(start);
                Console.WriteLine("you are a beta tester");
                }

                if (inpu == "keytest")
                {
                Console.WriteLine(" ");
                Console.Write("   Keycodes:  ");
                string keycodes = Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine("   "+ keycodes);
                Console.WriteLine(" ");
                Console.Write("   is this right? y/n ");
                string yn = Console.ReadLine();
                if (yn == "y")
                {
                Console.WriteLine(" ");
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("   Correct keys");
                Console.ForegroundColor = ConsoleColor.White;
                }

                else if (yn == "n")
                {
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("   Incorrect keys");
                Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {
                        Console.WriteLine(" ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("   Please answer with y or n");
                        Console.ForegroundColor = ConsoleColor.White;
                }

                }

                if (inpu == "texttest")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" ");
                    Console.WriteLine("  text test command");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (inpu == "beep")
                {
                    Console.WriteLine(" ");
                    Console.Beep();
                    Console.WriteLine("Beep Boop Buup?");
                }

                if (inpu == "palle")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" ");
                    Console.WriteLine("Moin Leeute, ich bin Paluten!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Wie heist du?");
                    Console.WriteLine(" ");
                    Console.Write("Dein Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.WriteLine("Oh hallo "+ name +"!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Tschüss "+ name +"!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
            }
        }
    }
}