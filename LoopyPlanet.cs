using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mini Project #1 Toronto Class 5 2017

namespace EvanWheatleyLoopyPlanet
{
    class LoopyPlanet
    {
        static void Main(string[] args)
        {
            int planetNumber = 0; //Corresponds to the planet number shown in menu
            double weightOnEarth = 0; //weight on earth input by user in cmd prompt

        Start: //Label that holds point above menu to make rerunning program easier

            Console.WriteLine("        Menu of Planets"); //Menu title 
            Console.WriteLine("        ==== == ======="); // Menu underline
            Console.WriteLine("1. Jupiter 2. Mars  3. Mercury"); // First 3 planets and their menu #
            Console.WriteLine("4. Neptune 5. Pluto 6. Saturn"); //Second group of 3 planets and menu #
            Console.WriteLine("7. Uranus  8. Venus 9. <Quit>"); // Final planets and the quit option #9

            Console.WriteLine();//Place holder to add space between menu and inputs




            Console.WriteLine("Enter your weight on Earth"); //prompt prior to entering weight on Earth
            weightOnEarth = Convert.ToDouble(Console.ReadLine()); //input for weight on Earth

            if (weightOnEarth > 9999)// upper weight limit to eliminate bugs
            {
                Console.WriteLine("Invalid Number"); //readout telling consumer there is an invalid number
                goto Start; //return to top of menu because of invalid number

            }
            else if (weightOnEarth <= 0)// lower weight limit to avoid multiplying by zero and negative numbers
            {
                Console.WriteLine("Invalid Number");//readout telling consumer there is an invalid number
                goto Start;//return to top of menu because of invalid number

            }

            Console.WriteLine("Your weight on earth is: {0}", weightOnEarth); //Output of weight on Earth


            Console.WriteLine("Enter the number of your chosen Planet"); //After menu prompt for # selection
            planetNumber = int.Parse(Console.ReadLine()); // Input line for planet number

            if (planetNumber > 9)//condition to prevent integers higher than 9
            {
                Console.WriteLine("Invalid Number");//readout telling consumer there is an invalid number
                goto Start;//return to top of menu because of invalid number

            }
            else if (planetNumber <= 0) //lower menu limit to prevent 0 and negative numbers
            {
                Console.WriteLine("Invalid Number");//readout telling consumer there is an invalid number
                goto Start;//return to top of menu because of invalid number

            }
            else
            {
                Console.WriteLine("your Chosen Planet number is: {0} ", planetNumber);//feedback out put with planet number
            }

            switch (planetNumber)//Switch stament for the input integer planetNumber
            {
                case 1:
                    Console.WriteLine("Your weight on Jupiter is " + weightOnEarth * 2.64);
                    //above readout with the calculation for double "weightOnEarth" multiplied by the gravitational constant                    Console.WriteLine("Press any key and enter to return to menu");

                    Console.WriteLine("Press andy key and enter to return to menu"); // Program info
                    Console.ReadLine();//input option so users get the chance to read results
                    goto Start;
                    break;//case statment break (unused)

                case 2:
                    Console.WriteLine("Your weight on Mars is " + weightOnEarth * 0.38);
                    //Readout with the calculation for double "weightOnEarth" multiplied by the gravitational constant                    Console.WriteLine("Press any key and enter to return to menu");

                    Console.WriteLine("Press andy key and enter to return to menu");// Program info
                    Console.ReadLine();//input option so users get the chance to read results
                    goto Start;//return to menu so program can run again
                    break;//case statment break (unused)

                case 3:
                    Console.WriteLine("Your weight on Mercury is " + weightOnEarth * 0.37);
                    //above readout with the calculation for double "weightOnEarth" multiplied by the gravitational constant                    Console.WriteLine("Press any key and enter to return to menu");

                    Console.WriteLine("Press andy key and enter to return to menu");// Program info
                    Console.ReadLine();//input option so users get the chance to read results
                    goto Start;//return to menu so program can run again
                    break;//case statment break (unused)

                case 4:
                    Console.WriteLine("Your weight on Neptune is " + weightOnEarth * 1.12);
                    //above readout with the calculation for double "weightOnEarth" multiplied by the gravitational constant                    Console.WriteLine("Press any key and enter to return to menu");

                    Console.WriteLine("Press andy key and enter to return to menu");// Program info
                    Console.ReadLine();//input option so users get the chance to read results
                    goto Start;//return to menu so program can run again
                    break;//case statment break (unused)

                case 5:
                    Console.WriteLine("Your weight on Pluto is " + weightOnEarth * 0.04);
                    //above readout with the calculation for double "weightOnEarth" multiplied by the gravitational constant                    Console.WriteLine("Press any key and enter to return to menu");

                    Console.WriteLine("Press andy key and enter to return to menu");// Program info
                    Console.ReadLine();//input option so users get the chance to read results
                    goto Start;//return to menu so program can run again
                    break;//case statment break (unused)

                case 6:
                    Console.WriteLine("Your weight on Saturn is " + weightOnEarth * 1.15);
                    //above readout with the calculation for double "weightOnEarth" multiplied by the gravitational constant                    Console.WriteLine("Press any key and enter to return to menu");

                    Console.WriteLine("Press andy key and enter to return to menu");// Program info
                    Console.ReadLine();//input option so users get the chance to read results
                    goto Start;//return to menu so program can run again
                    break;//case statment break (unused)

                case 7:
                    Console.WriteLine("Your weight on Uranus is " + weightOnEarth * 1.15);
                    //above readout with the calculation for double "weightOnEarth" multiplied by the gravitational constant                    Console.WriteLine("Press any key and enter to return to menu");

                    Console.WriteLine("Press andy key and enter to return to menu");// Program info
                    Console.ReadLine();//input option so users get the chance to read results
                    goto Start;//return to menu so program can run again
                    break;//case statment break (unused)

                case 8:
                    Console.WriteLine("Your weight on Venus is " + weightOnEarth * 0.88);
                    //above readout with the calculation for double "weightOnEarth" multiplied by the gravitational constant

                    Console.WriteLine("Press any key and enter to return to menu");// Program info
                    Console.ReadLine();//input option so users get the chance to read results
                    goto Start;//return to menu so program can run again
                    break;//case statment break (unused)

                case 9:
                    Console.WriteLine("Quiting program have a nice day");// case for option 9 the quit function breaks menu goto loop
                    break; //case statement break when selected breaks and goes to next line of code
            }
            Console.WriteLine("Press any key and enter to quit program");//quit message that comes up when case 9 is selected
            Console.ReadLine(); //input option to slow quit function

        }
    }
}
