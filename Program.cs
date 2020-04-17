using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            String vacationType;
            int groupSize;


            Console.WriteLine("What kind of vacation are you looking for musical, tropical, or adventurous?");
            vacationType = Console.ReadLine();

            Console.WriteLine("How many people will attend 1 through 2, 3 through 5, 6 plus?");
            groupSize = int.Parse(Console.ReadLine());


            //Console.WriteLine("New Orleans, Mexico, Grand Canyon");
            //destination = Console.ReadLine();

            if (vacationType == "musical" && groupSize <= 2)
            {
                Console.WriteLine("Since you chose a musical trip with maybe 1-2 people, you should fly first class to New Orleans.");
            }
            else if (vacationType == "musical" && groupSize <= 5)
            {
                Console.WriteLine("Since you chose a musical trip with maybe 3-5 people, you should fly first class to New Orleans.");
            }
            else if (vacationType == "musical" && groupSize >= 6)
            {
                Console.WriteLine("Since you chose a musical trip with probably 6 or more people, you should fly first class to New Orleans.");
            }
            else if (vacationType == "tropical" && groupSize <= 2)
            {
                Console.WriteLine("Since you chose a tropical trip with probably 1-2 people, you should get a charter flight for a beach vaction in Mexico");
            }
            else if (vacationType == "tropical" && groupSize <= 5)
            {
                Console.WriteLine("Since you chose a tropical trip with maybe 3-5 people, you should get a charter flight for a beach vaction in Mexico");
            }
            else if (vacationType == "tropical" && groupSize >= 6)
            {
                Console.WriteLine("Since you chose a tropical trip with probably 6 or more people, you should get a charter flight for a beach vaction in Mexico");
            }
            else if (vacationType == "adventurous" && groupSize <= 2)
            {
                Console.WriteLine("Since you chose an adventurous trip with maybe 1-2 people, you should take a helicopter for whitewater rafting in the grand canyon");
            }
            else if (vacationType == "adventurous" && groupSize <= 5)
            {
                Console.WriteLine("Since you chose an adventurous trip with probably 3-5 people, you should take a helicopter for whitewater rafting in the grand canyon");
            }
            else 
            {
                Console.WriteLine("Since you chose an adventurous trip with probably 6+ people, you should take a helicopter for whitewater rafting in the grand canyon");
            }

            Console.ReadLine();

















            //{
            //    Console.WriteLine("Since you chose a musical trip with probably 6+ people, you should fly first class to New Orleans.");
            //}

          

            //if (vacationType == "tropical" && groupSize <= 2)
            //{
            //    Console.WriteLine("Since you chose a tropical trip with 1-2 people, you should get a charter flight for a beach vaction in Mexico");
            //}
            //else if (vacationType == "tropical" && groupSize <= 5)
            //{
            //    Console.WriteLine("Since you chose a tropical trip with 3-5 people, you should get a charter flight for a beach vaction in Mexico");
            //}
            //else
            //{
            //    Console.WriteLine("Since you chose a tropical trip with probably 6+ people, you should get a charter flight for a beach vaction in Mexico");
            //}

            //Console.ReadLine();











            //Console.WriteLine("What kind of vaction would you like to go on? Select one of the following");
            //Console.WriteLine("(A) Musical ");
            //Console.WriteLine("(B) Tropical ");
            //Console.WriteLine("(C) Adventurous");

            //Console.WriteLine("What is your selection?");


            //Console.ReadLine();

            //Console.WriteLine("How many people are going?");
            //Console.WriteLine("(D) 1-2" );
            //Console.WriteLine("(E) 3-5");
            //Console.WriteLine("(F) 6+");

            //char selection = Console.ReadKey().KeyChar;

            //Console.WriteLine(" new Orleans, Mexico, Grand Canyon");






            //switch (selection)
            //{
            //    case 'A':
            //    case 'D':
            //        Console.WriteLine("Since you chose a musical trip with 1-2 people, you should fly first class to New Orleans.");
            //        break;
            //    case 'a':
            //    case 'E':
            //        Console.WriteLine("Since you chose a musical trip with 3-5 people, you should fly first class to New Orleans.");
            //        break;

            //    default:
            //        Console.WriteLine("Since you chose a musical trip with probably 6+ people, you should fly first class to New Orleans.");
            //        break;                
            //}

            //Console.ReadLine();

            //switch (selection)
            //{
            //    case 'B':
            //    case 'D':
            //        Console.WriteLine("Since you chose a tropical trip with 1-2 people, you should get a charter flight for a beach vaction in Mexico");
            //         break;
            //    case 'b':
            //    case 'E':
            //        Console.WriteLine("Since you chose a tropical trip with 3-5 people, you should get a charter flight for a beach vaction in Mexico");
            //        break;
            //    default:
            //        Console.WriteLine("Since you chose a tropical trip with probably 6+ people, you should get a charter flight for a beach vaction in Mexico");
            //        break;

            //}

            //Console.ReadLine();

            //switch (selection)
            //{
            //    case'C':
            //    case'D':
            //        Console.WriteLine("Since you chose an adventurous trip with 1-2 people, you should take a helicopter for whitewater rafting in the grand canyon");
            //        break;
            //    case 'c':
            //    case 'E':
            //        Console.WriteLine("Since you chose an adventurous trip with 3-5 people, you should take a helicopter for whitewater rafting in the grand canyon");
            //        break;

            //    default:
            //        Console.WriteLine("Since you chose an adventurous trip with probably 6+ people, you should take a helicopter for whitewater rafting in the grand canyon");
            //        break;

            //        Console.ReadLine();
        }




    }
}

