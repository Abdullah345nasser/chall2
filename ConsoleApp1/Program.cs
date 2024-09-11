using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 5, 6, 9, 3 };



            char choice;

            /**/

            do
            {

                Console.WriteLine("============================================\n");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a numbers");
                Console.WriteLine("M - Display menu of the numbers");
                Console.WriteLine("S - Display the smallest  numbers");
                Console.WriteLine("L - Display the largest numbers");
                Console.WriteLine("F - Display the Index of the  number");
                Console.WriteLine("C - Clearing out the list");
                Console.WriteLine("Q - Quit");
                Console.WriteLine("============================================\n");
                Console.Write("Enter your choice: ");
                choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 'p':
                    case 'P':
                        {
                            if (list.Count() <= 0) { Console.WriteLine("[] - the list is empty"); }

                            else
                            {
                                Console.Write("[");

                                foreach (int i in list)

                                {
                                    Console.Write(" " + i);
                                }
                                Console.WriteLine("]");
                            }
                            break;

                        }

                    case 'a':
                    case 'A':
                        {
                            Console.Write("Enter number to add? ");

                            int add_num = int.Parse(Console.ReadLine());
                            if (list.Count() <= 0)
                            {
                                list.Insert(0, add_num);

                            }
                            else
                            {
                                int count = 0;
                                // to do not allow duplicate 
                                 foreach (int i in list)
                                {
                                    if (add_num == list[count ])
                                    {
                                        Console.Write("Enter another number to add? ");
                                        add_num = int.Parse(Console.ReadLine());
                             
                                    }
                                    count++;
                                }
                                list.Insert(list.Count(), add_num);
                            }
                            
                           
                            Console.WriteLine($"{add_num} added");
                            break;

                        }

                    case 'M':
                    case 'm':
                        {
                            if (list.Count() <= 0) { Console.WriteLine("Unable to calculate the mean - no data"); }
                            else
                            {
                                double average = 0;
                                double sum = 0;

                                foreach (int i in list) { sum += i; }
                                average = sum / list.Count();

                                Console.WriteLine($"The mean of the elements in the list =  {average }");
                            }

                            break;
                        }
                    case 'S':
                    case 's':
                        {
                            if (list.Count() <= 0) { Console.WriteLine("Unable to determine the smallest number"); }

                            else
                            {
                                int smallestNum = list[0];
                                foreach (int i in list)
                                {
                                    if (smallestNum > i) { smallestNum = i; }
                                }
                                Console.WriteLine($"The smallest number is {smallestNum} ");
                            }

                            break;
                        }

                    case 'L':
                    case 'l':
                        {
                            if (list.Count() <= 0) { Console.WriteLine("Unable to determine the Largest number"); }

                            else
                            {
                                int largeNum = list[0];
                                foreach (int i in list)
                                {
                                    if (largeNum < i) { largeNum = i; }
                                }
                                Console.WriteLine($"The large number is {largeNum} ");
                            }

                            break;
                        }

                    case 'Q':
                    case 'q':
                        {
                            Console.WriteLine("Goodbye");
                            break;
                        }

                    case 'F':
                    case 'f':
                        {
                            if (list.Count() <= 0) { Console.WriteLine("No elements in the list to search about it"); }
                            else
                            {
                                int index_num = 0;
                                Console.Write("Enter number to search? ");
                                int numToSearch= int.Parse(Console.ReadLine());
                                for (int li=0; li <list.Count();  li++) 
                                { 
                                if (numToSearch == list[li])
                                    {
                                        index_num = li;
                                        Console.WriteLine($"The index of {numToSearch} = {index_num}");
                                        break;
                                    } 

                                     }
                                Console.WriteLine("The index not found");

                            }
                            break;
                        }

                    case 'C':
                    case 'c':
                        {
                            if (list.Count() <= 0) { Console.WriteLine("No elements in the list to clear it"); }
                           else
                            {
                                list.Clear();
                                Console.WriteLine("Clearing out the list ");
                            }
                            break;
                        }


                }
            } while (choice != 'Q' && choice != 'q');

        }
    }
}
