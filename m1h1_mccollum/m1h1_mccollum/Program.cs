using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//McCollum, Joseph
//Homwork M1H1
//CTS-285
//8 * 25 * 2023
//This program writes a simple console Calculator app for the user to enter a number and get either 
//Addition , Division, Multiplication, or Subtraction

namespace m1h1_mccollum
{
    //Calculator menu class
    class menuChoice
    {
        public static void menu()
        {
            Console.WriteLine("**** Welcome to the Calculator program *****");
            Console.WriteLine("1. Add ");
            Console.WriteLine("2. Subtract ");
            Console.WriteLine("3. Divide ");
            Console.WriteLine("4. Multiply ");
            Console.WriteLine("5. Exit ");
            Console.WriteLine("*********************************************");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //While loop calling the Calculator class
            while (true)
            {                                
                Console.WriteLine("Enter First Number: ");
                double userNum = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number: ");
                double userNum2 = double.Parse(Console.ReadLine());

                menuChoice.menu();
                int choice = Convert.ToInt32(Console.ReadLine());
                
                //Using a simple IF/Else statement to get info from the user to add, subtract, multiply or divide
                //The program ends if a user enters 5 when the menu shows up after the user enters their 2 numbers
                if (choice == 1)
                {
                    Console.WriteLine("Choice Additon: ");
                    Console.WriteLine(userNum + userNum2 + "\n");
                    menuChoice.menu();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Choice Subtraction: ");
                    Console.WriteLine(userNum - userNum2 + "\n");                    
                    menuChoice.menu();                
                }
                else if(choice == 3)
                {
                    Console.WriteLine("Choice Divsion: ");
                    Console.WriteLine(userNum / userNum2 + "\n");                    
                    menuChoice.menu();
                }
                else if(choice == 4)
                {
                    Console.WriteLine("Choice Multiplication: ");
                    Console.WriteLine(userNum * userNum2 + "\n");                    
                    menuChoice.menu();
                }

                //This ends the loop + the program
                else if(choice == 5)
                {
                    Console.WriteLine("Ending Program");
                    break;
                }

                //If a user enters a number other than 1 - 5 will cause the loop to rerun and start from the beginning
                else
                {
                    Console.WriteLine("Invalid Input try again" + "\n");                    
                    menuChoice.menu();
                }
            }
            Console.Read();
        }
    }
}
