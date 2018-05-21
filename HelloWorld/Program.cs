using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //part one greetings statement
            string messageOne = "hello world";
            string messageTwo = "I am Spartacus";

            //part two set initial spartacus attributes
            int ageOne = 35;
            int ageTwo = 45;
            int ageThree = 80;
            double heightOne = 72.50;
            double heightTwo = 91.45;
            float weightOne = 210.0284606f;
            float weightTwo = 331.12345678f;
            bool isGodLikeOne = true;
            bool isGodlikeTwo = false;
            char genderMale = 'M';
            char genderFemale = 'F';

            ////part three diaplay variable values
            //Console.WriteLine(messageOne);
            //Console.WriteLine(messageTwo);

            ////part four mathematical opperator, bool, and char
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(isGodLikeOne);
            //Console.WriteLine(genderMale);

            ////part five variable reassignment
            //ageTwo = 70;
            //heightTwo = 35.12345f;
            //weightTwo = -429.1234573f;

            ////part six mathematical operator systems
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);

            ////part seven increment and decrement operator examples
            //ageTwo = ageTwo + 1;
            //Console.WriteLine(ageTwo);
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);
            //Console.WriteLine( 5 <= 2);
            //"" reads as a string
            //'' reads as a character

            ////part eight cancatination example
            //Console.WriteLine(messageOne + ", " + messageTwo + ".");
            //Console.WriteLine("I am " + ageOne + " and it is " + isGodLikeOne + " I am God like." );
            //Console.WriteLine("I weigh around " + weightOne + ", and I am around " + heightOne + " inches tall.");
            //Console.WriteLine("I am {0} and it is {1} that I am god like", ageOne, isGodLikeOne );
            //Console.WriteLine("I weigh around {0}, and I am around {1} inches tall", weightOne, heightOne );
            //Console.WriteLine("My father is {0} years old, and it is {1} that he is a god", ageThree, isGodLikeOne);

            ////part nine string equality examples
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));

            ////part ten string length examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //Console.WriteLine("The length of messageTwo is " + messTwoLength);

            // //Part 11: Conditional examples
            // string cityOne = "Vesuvius";
            // string cityTwo = "Nola";
            // string cityThree = "Nuceria";
            // int cityOneDistance, cityTwoDistance, cityThreeDistance;

            // //Solicit user input
            // Console.WriteLine("What is the distance to {0}?", cityOne);
            // cityOneDistance = int.Parse(Console.ReadLine());
            // Console.WriteLine("What is the distance to " + cityTwo + "?");
            // cityTwoDistance = int.Parse(Console.ReadLine());
            // Console.WriteLine("What is the distance to Nuceria?");
            // cityThreeDistance = int.Parse(Console.ReadLine());

            // if ((cityOneDistance <= 125) && ((cityOneDistance < cityTwoDistance) && (cityOneDistance < cityThreeDistance)))
            // {
            //     Console.WriteLine("We will march to {0}", cityOne);
            // }
            // if ((cityTwoDistance <= 125) && ((cityTwoDistance < cityOneDistance) && (cityTwoDistance < cityThreeDistance)))
            // {
            //     Console.WriteLine("We will march to " + cityTwo);
            // }
            // if ((cityThreeDistance <= 125) && ((cityThreeDistance < cityOneDistance) && (cityThreeDistance < cityTwoDistance)))
            //{
            //     Console.WriteLine("We will march to {0}", cityThree);
            // }

            //string[] foodList = new string[5];
            //foodList[0] = "milk";
            //foodList[1] = "fruit";
            //foodList[2] = "meat";
            //foodList[3] = "wine";
            //foodList[4] = "bread";
            //Console.WriteLine(" {3} {1} {2} {0} {4} ",foodList[0],foodList[1],foodList[2],foodList[3],foodList[4]);

            //int[] foodAmount = new int[] { 1000, 1000, 2000, 10000, 1500 };
            //Console.WriteLine(foodAmount[0] + ", " + foodAmount[1] + ", " + foodAmount[2] + ", " + foodAmount[3] + ", " + foodAmount[4] );

            //Console.WriteLine(foodList.Length);

            //string[] element = messageTwo.Split(' ');
            //Console.WriteLine(element[0]);//prints i
            //Console.WriteLine(element[1]);//prints am
            //Console.WriteLine(element[2]);//prints spartacus

            //List<string> foodList = new List<string>();
            //foodList.Add("Milk");
            //foodList.Add("Fruit");
            //foodList.Add("Meat");
            //foodList.Add("Wine");
            //foodList.Add("Bread");
            //foodList.Add("Pepsi");

            //foodList.Add("Pepsi");
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4], foodList[5]);
            //foodList.Remove("Pepsi");
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);
            //foodList.Insert(1, "Pepsi");
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4], foodList[5]);
            //foodList.RemoveAt(1);
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);

            // Part 12 while loop example

            //string action = " ";
            //while (action != "exit")
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine();
            //}
            string action = " ";
            
            {
                Console.WriteLine("What is your rank soldier?");
                string rank = Console.ReadLine();

                Console.WriteLine("What is your age soldier?");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your job soldier?");
                string job = Console.ReadLine();

                if ((rank == "officer") || (age <= 26))
                {
                    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
                }
                else if ((job == "cook") || (age >= 26))
                {
                    Console.WriteLine("My army has to eat. Pack your pots and pans");
                }
                else
                {
                    Console.WriteLine("Sorry you are staying home.");
                }
                Console.WriteLine("Add another? Type exit to quit");
                action = Console.ReadLine();
            } while (action != "exit");
           



        }
    }
}
