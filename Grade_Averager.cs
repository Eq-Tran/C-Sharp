using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3fin
{
    class Program
    {


        static void _Pause()
        {

            //Function for system pause
            Console.WriteLine("\n \n Please enter any key to continue....");
            //Waits for user to press key to continue
            Console.ReadKey();

        }

        static bool _validate(String stringNumber)
        {
            double dblg = 0;
            bool result = Double.TryParse(stringNumber, out dblg);
            return result;

        }
        
        static void _addtoList(List<double>Lab1, List<double>Lab2, List<double>Lab3, List<double>Lab4, List<double>Lab5, ref double dblg1, ref double dblg2, ref double dblg3, ref double dblg4, ref double dblg5)
        {

            Lab1.Add(dblg1);
            Lab2.Add(dblg2);
            Lab3.Add(dblg3);
            Lab4.Add(dblg4);
            Lab5.Add(dblg5);

        }

       
       

       static string _letter_Grade( ref double studentAvg, ref string letterGrade)
        {
            if(studentAvg >= 90)
            {

                letterGrade = "A";
            }

           else if(studentAvg >= 80)
            {
                letterGrade = "B";
            }

            else if (studentAvg >= 70)
            {
                letterGrade = "C";
            }

            else if (studentAvg >= 60)
            {
                letterGrade = "D";
            }

            else
            {
                letterGrade = "F";
            }

            return letterGrade;
        } 
      

        static void Main(string[] args)
        {

            //Variable Declaration
            string answer, strg1, strg2, strg3, strg4, strg5,letterGrade="";
            double dblg1 = 0, dblg2 = 0, dblg3 = 0, dblg4 = 0, dblg5 = 0, studentAvg;
            Int32 counter = 0;
            Int32 i = 0;
            bool result = false;

            //Array
            Double[] labAvg = new double[5];

            //Lists
            List<string> FirstName = new List<string>();
            List<double> Lab1 = new List<double>();
            List<double> Lab2 = new List<double>();
            List<double> Lab3 = new List<double>();
            List<double> Lab4 = new List<double>();
            List<double> Lab5 = new List<double>();

            do
            {
                counter++;

                //Prompt user for name
                Console.WriteLine("Please enter your name !");
                Console.WriteLine("========================");
                //User inputs name and adds it to list FirstName
                FirstName.Add(Console.ReadLine());
                //Prompt user to enter grades
                Console.WriteLine("Enter your grades:");
                Console.WriteLine("========================");

                //HELP need to find more effiecient way 
                do
                {
                    Console.WriteLine("Lab " + (counter) + " Grade: ");
                    strg1 = Console.ReadLine();
                    
                    result = _validate(strg1);

                    if (result == false)
                    {

                        Console.WriteLine("Error: String detected, enter valid number instead.");

                    }

                    else
                    {
                        dblg1 = Double.Parse(strg1);
                        counter++;

                    }
                    
                } while (result == false);

                do
                {
                    Console.WriteLine("Lab " + (counter) + " Grade: ");
                    strg2 = Console.ReadLine();
                    result = _validate(strg2);

                    if (result == false)
                    {

                        Console.WriteLine("Error: String detected, enter valid number instead.");

                    }

                    else
                    {
                        dblg2 = Double.Parse(strg2);
                        counter++;
                    }

                } while (result == false);

                do
                {
                    Console.WriteLine("Lab " + (counter)+ " Grade: ");
                    strg3 = Console.ReadLine();
                    result = _validate(strg3);
                   
                    if (result == false)
                    {

                        Console.WriteLine("Error: String detected, enter valid number instead.");

                    }
                    else
                    {
                        dblg3 = double.Parse(strg3);
                        counter++;
                    }  
                     
                } while (result == false);

                do
                {
                    Console.WriteLine("Lab " + (counter) + " Grade: ");
                    strg4 = Console.ReadLine();
                    result = _validate(strg4);
                   
                    if (result == false)
                    {

                        Console.WriteLine("Error: String detected, enter valid number instead.");

                    }

                    else
                    {
                        dblg4 = Double.Parse(strg4);
                        counter++;
                    }

                } while (result == false);

                do
                {
                    Console.WriteLine("Lab " + (counter) + " Grade: ");
                    strg5 = Console.ReadLine();
                    result = _validate(strg5);
                    
                    if (result == false)
                    {

                        Console.WriteLine("Error: String detected, enter valid number instead.");

                    }

                    else
                    {

                        dblg5 = Double.Parse(strg5);

                    }

                } while (result == false);


                //Add to list method call
                _addtoList(Lab1, Lab2, Lab3, Lab4, Lab5, ref dblg1, ref dblg2, ref dblg3, ref dblg4, ref dblg5);

                //Prompts user to decide to add another sutdent
                Console.WriteLine("==========================================");
                Console.WriteLine("Would you like to add another student? Y/N");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
            
                //Resets lab count for next student
                counter = 0;
            } while (answer == "Y");//Main Do

          
            for (i = 0; i < FirstName.Count; i++)
            {   //Student average calculation
                studentAvg = (Lab1[i] + Lab2[i] + Lab3[i] + Lab4[i] + Lab5[i]) / 5;

                //Letter Grade initialization with method 
                letterGrade = _letter_Grade(ref studentAvg, ref letterGrade);
                
                Console.WriteLine("========================");
                Console.WriteLine("Name: " + FirstName[i]);
                Console.WriteLine("Lab 1: " + Lab1[i]);
                Console.WriteLine("Lab 2: " + Lab2[i]);
                Console.WriteLine("Lab 3: " + Lab3[i]);
                Console.WriteLine("Lab 4: " + Lab4[i]);
                Console.WriteLine("Lab 5: " + Lab5[i]);
                Console.WriteLine("Letter Grade: " + letterGrade);
                Console.WriteLine("========================");
            }

            //!!! I tried to use a foreach loop for here but was unsuccessful pls elaborate !!!!!!!
            for (i = 0; i < Lab1.Count; i++)
            {
                labAvg[0] = Lab1[i] + labAvg[0];
            }
            for (i = 0; i < Lab2.Count; i++)
            {
                labAvg[1] = Lab2[i] + labAvg[1];
            }
            for (i = 0; i < Lab3.Count; i++)
            {
                labAvg[2] = Lab3[i] + labAvg[2];
            }
            for (i = 0; i < Lab4.Count; i++)
            {
                labAvg[3] = Lab4[i] + labAvg[3];
            }
            for (i = 0; i < Lab5.Count; i++)
            {
                labAvg[4] = Lab5[i] + labAvg[4];
            }

            //Lab Average Calculation
            labAvg[0] = labAvg[0] / FirstName.Count;
            labAvg[1] = labAvg[1] / FirstName.Count;
            labAvg[2] = labAvg[2] / FirstName.Count;
            labAvg[3] = labAvg[3] / FirstName.Count;
            labAvg[4] = labAvg[4] / FirstName.Count;

            //Console output      
            Console.WriteLine("Lab Averages");
            Console.WriteLine("Lab 1 avg: " + labAvg[0]);
            Console.WriteLine("Lab 2 avg: " + labAvg[1]);
            Console.WriteLine("Lab 3 avg: " + labAvg[2]);
            Console.WriteLine("Lab 4 avg: " + labAvg[3]);
            Console.WriteLine("Lab 5 avg: " + labAvg[4]);
            
            //End Program method 
            _Pause();

        }//Main

    }//Program 

}//Namespace
