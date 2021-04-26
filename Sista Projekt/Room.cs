using System;
using System.Collections.Generic;

namespace Sista_Projekt
{
    class Room
    {
        public static void Rooms()
        {
  
            //lista med alla rum som ska gå att välja, går att addera eller ta bort rum i listan efter preferens
            List<string> rooms = new List<string>() {"Room1", "Room2", "Room3", "Room4"};

            for (int i = 0; i < rooms.Count; i++)
            {
                Console.Write(rooms[i] + " " );
            }

            Console.WriteLine("which room would you like to enter?");

            string choice = Console.ReadLine();

            // while loop som kollar om rooms innehåller choice
            while(!rooms.Contains(choice))
            {
                
                if(rooms.Contains(choice))
                {
                    Console.WriteLine("You have entered " + choice);
                }

                else
                {
                    Console.WriteLine(choice);
                    Console.WriteLine("That ain't one of the rooms, please try again");
                    choice = Console.ReadLine();
                }
                
            }

            for(int i = 0; i < rooms.Count; i++)
            {
                Console.WriteLine(rooms[i]);
                if(rooms[i] == choice)
                {
                    Console.Clear();
                    Console.WriteLine("ay gå in i: " + rooms[i]);
                    break;
                }
            } 

            switch(choice)
            {
                //typkonverterare som gör en string (måste vara ett tal) till en int som sedan testas om det är större, mindre eller like med 5. Om man inte skrivet ett tal får man försöka igen
                case "Room1":
                    Room1();
                    break;
                case "Room2":

                    break;

                case "Room3":

                    break;

                case "Room4":

                    break;
            }

            Console.ReadKey();
        }

        public static void Room1() {
            bool result = false;
                while(!result)
                {
                Console.WriteLine("Hej, vänligen skriv ett tal");
                var input = Console.ReadLine();
                int blyat;
                result = Int32.TryParse(input, out blyat);
                if(result) {
                    if(blyat < 5) {
                        Console.WriteLine( blyat + " är Mindre än 5");
                    } else if(blyat >5) {
                        Console.WriteLine( blyat + " är Större än 5");
                    } else {
                        Console.WriteLine( blyat + " är Samma som 5");
                    }
                } else {
                    Console.WriteLine("Det var inget tal, SKRIV ETT TAL!!!");
                }
                Console.ReadLine();
                Console.Clear();
                }

                public static void Room2() {

                }

                public static void Room3() {

                }

                public static void Room4() {

                }
 
        }
    }
}