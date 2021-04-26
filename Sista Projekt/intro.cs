using System;

namespace Sista_Projekt
{
    class Intro
    {
       public static void Introt()
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                 ░██╗░░░░░░░██╗███████╗██╗░░░░░░█████╗░░█████╗░███╗░░░███╗███████╗  ████████╗░█████╗░");
            Console.WriteLine("                 ░██║░░██╗░░██║██╔════╝██║░░░░░██╔══██╗██╔══██╗████╗░████║██╔════╝  ╚══██╔══╝██╔══██╗");
            Console.WriteLine("                 ░╚██╗████╗██╔╝█████╗░░██║░░░░░██║░░╚═╝██║░░██║██╔████╔██║█████╗░░  ░░░██║░░░██║░░██║");
            Console.WriteLine("                 ░░████╔═████║░██╔══╝░░██║░░░░░██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░  ░░░██║░░░██║░░██║");
            Console.WriteLine("                 ░░╚██╔╝░╚██╔╝░███████╗███████╗╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗  ░░░██║░░░╚█████╔╝");
            Console.WriteLine("                 ░░░╚═╝░░░╚═╝░░╚══════╝╚══════╝░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝  ░░░╚═╝░░░░╚════╝░");
            Console.WriteLine("                         ██████╗░██╗░░░██╗███╗░░██╗░██████╗░███████╗░█████╗░███╗░░██╗███████╗");
            Console.WriteLine("                         ██╔══██╗██║░░░██║████╗░██║██╔════╝░██╔════╝██╔══██╗████╗░██║╚════██║");
            Console.WriteLine("                         ██║░░██║██║░░░██║██╔██╗██║██║░░██╗░█████╗░░██║░░██║██╔██╗██║░░███╔═╝");
            Console.WriteLine("                         ██║░░██║██║░░░██║██║╚████║██║░░╚██╗██╔══╝░░██║░░██║██║╚████║██╔══╝░░");
            Console.WriteLine("                         ██████╔╝╚██████╔╝██║░╚███║╚██████╔╝███████╗╚█████╔╝██║░╚███║███████╗");
            Console.WriteLine("                         ╚═════╝░░╚═════╝░╚═╝░░╚══╝░╚═════╝░╚══════╝░╚════╝░╚═╝░░╚══╝╚══════╝");
            Console.WriteLine("");
            Console.WriteLine("                                                  Write your name");
            string character = Console.ReadLine();
            Console.Clear();
            
            
            Console.Write("Welcome ");
            Console.Write(character);
            Console.WriteLine(", Here the adventure begins! Good luck traveller, and may the odds be ever in your favour");
            Console.ReadLine();
            Console.Clear();

        }
    }
}