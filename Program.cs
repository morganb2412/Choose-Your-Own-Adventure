using System;

namespace Choose_Your_Own_Adventure
{

      class Program
        {
            static void Main(string[] args)
            {
                /* THE MYSTERIOUS NOISE */

                // Start by asking for the user's name:
                Console.Write("What is your name?: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello, {name}! Welcome to our story.");


                Console.WriteLine("\nIt begins on a cold rainy night. \nYou're sitting in your room and hear \na noise coming from down the hall. \nDo you go investigate? ");

                Console.WriteLine("Type YES or NO: ");

                string noiseChoice = Console.ReadLine();

                string upperNoiseChoice = noiseChoice.ToUpper();


                if (upperNoiseChoice == "NO")
                {
                    Console.WriteLine("Not much of an adventure if wwe don't leave our room! \nTHE END");
                    
                    return;
                }
                else if (upperNoiseChoice == "YES")
                {
                    Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. \nYou walk towards it. Do you open it or knock? ");

                }

                Console.WriteLine("Type OPEN or KNOCK: ");

                string doorChoice = Console.ReadLine();

                string upperDoorChoice = doorChoice.ToUpper();
                if (upperDoorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle:\"  \"Poor people have it. Rich people need it. If you eat it you die. What is it?\" ");
                    Console.Write("Type your answer:");

                    string riddleAnswer = Console.ReadLine();

                     string upperRiddleAnswer = riddleAnswer.ToUpper();
                        
                   if(upperRiddleAnswer == "NOTHING ")
                {
                    Console.WriteLine("The door opens and nothing is there. You run back to your room and hide! \nTHE END.");
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect.The door doesn't open \nTHE END. ");
                }


                }

                else if (upperDoorChoice == "OPEN")
                {

                  Console.WriteLine("The door is lock!");
                   
                     Console.WriteLine("Choose as number between 1-3: ");

                  string userKey = Console.ReadLine();

                switch (userKey)
                {
                    case "1":
                        Console.WriteLine("You chose the correct key!");
                        Console.WriteLine("The door opens and NOTHING is there. You run to your room and hide. \nTHE END !");
                        break;
                    
                    case "2":
                        Console.WriteLine("You choose wrong key.\nTHE END!");
                        break;

                    case "3":
                        Console.WriteLine("You choose wrong key.\nTHE END!");
                        break;

                    default:
                        Console.WriteLine("You didn't choose anything. \nTHE END!");
                        break;


                }
                 
                   

                       


                }

            









            }
        }
    }






