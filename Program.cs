//     Mahmoud Najuib AbdEltwab     -    C42-G02-C#04
//

using System.Threading.Tasks;

namespace Assigment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 13- Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Enter a string: ");
            //string Input = Console.ReadLine();

            //char[] CharArray = Input.ToCharArray();
            //Array.Reverse(CharArray);

            //string ReversedString = new string(CharArray);

            //Console.WriteLine($"\nReversed String is: {ReversedString}");

            #endregion

            #region 14- Write a program to allow the user to enter int and print the REVERSED of it.

            //    Console.Write("Enter an Integer: ");

            //Start:
            //    string Input = Console.ReadLine();

            //    if (int.TryParse(Input, out int Number))
            //    {
            //        char[] CharArray = Input.ToCharArray();             // Reversing The Number.
            //        Array.Reverse(CharArray);

            //        string ReversedString = new string(CharArray);      // Handling Negative Numbers To Be Reversed Correctly (The Negative Sign Shouldn't Be Reversed).
            //        if (Number < 0)
            //        {
            //            ReversedString = "-" + ReversedString.TrimEnd('-');
            //        }

            //        Console.WriteLine($"\nReversed: {ReversedString}");
            //    }
            //    else
            //    {
            //        Console.Write("\nInvalid Input. Please Enter a Valid Integer: ");
            //        goto Start;
            //    }

            #endregion

            #region 15- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //    Console.Write("Enter Starting Number: ");

            //Start:
            //    if (int.TryParse(Console.ReadLine(), out int Start))
            //    {
            //        Console.Write("Enter Ending Number: ");
            //    End:
            //        if (int.TryParse(Console.ReadLine(), out int End))
            //        {
            //            if (Start <= End)
            //            {
            //                /*bool InPrime = false;*/

            //                Console.WriteLine($"\nThe Prime Numbers Between {Start} and {End} are :");
            //                for (int i = Start; i <= End; i++)
            //                {
            //                    bool IsNumPrime = true;
            //                    for (int j = 2; j < i; j++)
            //                    {
            //                        if (i % j == 0)
            //                        {
            //                            IsNumPrime = false;
            //                            break;
            //                        }

            //                        /*
            //                        else if (i % 2 != 0 && )
            //                        {
            //                            IsNumPrime = true;
            //                            Console.WriteLine("\nNo Prime Numbers Found in The Given Range.");
            //                        }
            //                        */

            //                    }
            //                    if (IsNumPrime)
            //                    {
            //                        Console.Write(i + " ");
            //                    }
            //                }
            //                Console.WriteLine("\n");

            //            }
            //            else
            //            {
            //                Console.Write("\nInvalid Input. Please Enter an Ending Integer that is Greater than the Starting Integer: ");
            //                goto End;
            //            }
            //        }

            //        else
            //        {
            //            Console.Write("\nInvalid Input. Please Enter a Valid Ending Integer: ");
            //            goto End;
            //        }

            //    }
            //    else
            //    {
            //        Console.Write("\nInvalid Input. Please Enter a Valid Starting Integer: ");
            //        goto Start;
            //    }

            /*
                if (IsPrime == false)
                {
                    Console.WriteLine("\nNo Prime Numbers Found in The Given Range.");
                }
                int End = int.Parse(Console.ReadLine());
            */

            #endregion

            #region 16- Write a program in C# Sharp to convert a decimal number into binary without using an array:

            //    Console.Write("Enter a Decimal Number: ");
            //Start:
            //    string Input = Console.ReadLine();

            //    if (int.TryParse(Input, out int Number))
            //    {
            //        Console.WriteLine($"\nThe Binary of {Number} is: {Convert.ToString(Number, 2)}");
            //    }
            //    else
            //    {
            //        Console.Write("\nInvalid Input. Please Enter a Valid Decimal Number: ");
            //        goto Start;
            //    }

            #endregion

            #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2) and(x3, y3), and determines whether these points lie on a single straight line:

            //    Console.WriteLine("Check If The Three Points Are on the Same Line or Not.   (Hint: Split Between X and Y with a Comma ',')\n\n");

            //    Console.Write("Enter the First Point X1, Y1:    ");
            //First:
            //    try
            //    {
            //        string[] point1 = Console.ReadLine().Split(',');        // To Split the Input String To Get the X and Y Co-ordinates.
            //        if (double.TryParse(point1[0], out double X1) && double.TryParse(point1[1], out double Y1) && point1.Length == 2) // To Check If the Input is Valid & To Get the X and Y Co-ordinates & To Check If the Input is 2 Co-ordinates.
            //        {
            //            X1 = double.Parse(point1[0]);                    // To Get the X Co-ordinates.
            //            Y1 = double.Parse(point1[1]);                    // To Get the Y Co-ordinates.

            //            Console.Write("Enter the Second Point X2, Y2:   ");
            //        Second:
            //            try
            //            {
            //                string[] point2 = Console.ReadLine().Split(',');
            //                if (double.TryParse(point2[0], out double X2) && double.TryParse(point2[1], out double Y2) || point2.Length > 3)
            //                {
            //                    X2 = double.Parse(point2[0]);
            //                    Y2 = double.Parse(point2[1]);

            //                    Console.Write("Enter the Third Point X3, Y3:    ");
            //                Third:
            //                    try
            //                    {
            //                        string[] point3 = Console.ReadLine().Split(',');
            //                        if (double.TryParse(point3[0], out double X3) && double.TryParse(point3[1], out double Y3) || point3.Length > 3)
            //                        {
            //                            X3 = double.Parse(point3[0]);
            //                            Y3 = double.Parse(point3[1]);

            //                            /* The Conditions:
            //                             Slope between A and B = Slope between B and C

            //                             Slope AB = (Y2 - Y1) / (X2 - X1)
            //                             Slope BC = (Y3 - Y2) / (X3 - X2)

            //                             If Slope AB = Slope BC, then the three points are on the same line.
            //                             If Slope AB != Slope BC, then the three points are not on the same line.
            //                            */

            //                            if ((Y2 - Y1) / (X2 - X1) == (Y3 - Y2) / (X3 - X2))
            //                            {
            //                                Console.WriteLine("\nAll Three Points Are on the Same Line.");
            //                            }
            //                            else
            //                            {
            //                                Console.WriteLine("\nAll Three Points Are Not on the Same Line.");
            //                            }
            //                        }
            //                        else
            //                        {
            //                            Console.Write("\nInvalid Input. Please Enter a Valid Point: ");
            //                            goto Third;
            //                        }
            //                    }
            //                    catch
            //                    {
            //                        Console.Write("\nInvalid Input. Please Enter a Valid Point: ");
            //                        goto Third;
            //                    }
            //                }
            //                else
            //                {
            //                    Console.Write("\nInvalid Input. Please Enter a Valid Point: ");
            //                    goto Second;
            //                }
            //            }
            //            catch
            //            {
            //                Console.Write("\nInvalid Input. Please Enter a Valid Point: ");
            //                goto Second;
            //            }
            //        }
            //        else
            //        {
            //            Console.Write("\nInvalid Input. Please Enter a Valid Point: ");
            //            goto First;
            //        }
            //    }
            //    catch
            //    {
            //        Console.Write("\nInvalid Input. Please Enter a Valid Point: ");
            //        goto First;
            //    }

            /*
            Console.Write("Enter the Second Point (x2, y2): ");
            Console.Write("Enter the Third Point (x3, y3): ");
            Console.WriteLine("\nAll Three Points Are on the Same Line.");
            Console.WriteLine("\nAll Three Points Are Not on the Same Line.");
            Console.Write("\nInvalid Input. Please Enter a Valid Point: ");
            */

            #endregion

            #region 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.
            /* A workers efficiency level is determined as follows:
                    -If the worker completes the job within 2 to 3 hours, they are considered
                    highly efficient.
                    - If the worker takes 3 to 4 hours, they are instructed to increase their
                    speed.
                    - If the worker takes 4 to 5 hours, they are provided with training to
                    enhance their speed.
                    - If the worker takes more than 5 hours, they are required to leave the
                    company.

                To calculate the efficiency of a worker, the time taken for the task is
                obtained via user input from the keyboard.
            */

            //    Console.Write("Enter the Time Taken to Complete the Task (in Hours): ");
            //Start:
            //    try
            //    {
            //        int Time = int.Parse(Console.ReadLine());
            //        if (Time >= 2 && Time <= 3)
            //        {
            //            Console.WriteLine("\nHighly Efficient Worker.");
            //        }
            //        else if (Time >= 3 && Time <= 4)
            //        {
            //            Console.WriteLine("\nInstructed to Increase Their Speed.");
            //        }
            //        else if (Time >= 4 && Time <= 5)
            //        {
            //            Console.WriteLine("\nProvided with Training to Enhance Their Speed.");
            //        }
            //        else if (Time > 5)
            //        {
            //            Console.WriteLine("\nRequired to Leave the Company.");
            //        }
            //        else
            //        {
            //            Console.Write("\nInvalid Input. Please Enter a Valid Time: ");
            //            goto Start;
            //        }
            //    }

            //    catch
            //    {
            //        Console.Write("\nInvalid Input. Please Enter a Valid Time: ");
            //        goto Start;
            //    }

            #endregion

            Console.ReadKey();
        }
    }
}
