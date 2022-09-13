using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Globalization;

namespace SortingandSearching
{
    public class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\brother\Desktop\project-3\studentdata.txt";
           
            List<string> data = new List<string>(File.ReadAllLines(file));
            bool a = false;

            do
            {


                Console.WriteLine("Enter any one option in Menu shown Below : ");
                Console.WriteLine("\nMenu \n)1)Sort  \n2)Search");
                int no = Convert.ToInt32(Console.ReadLine());

                switch (no)
                {
                    case 1:
                        sort(data);
                        break;
                    case 2:
                        search(data);
                        break;
                }
                Console.WriteLine("  ");
                Console.WriteLine("Do you want to continue or exit the process");
                Console.WriteLine("Menu: \n1)Continue the process \n2)Exit the process");
                int n=Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    a = false;

                }
                else if(n==2)
                {
                    a=true;
                }
           
            } while (!a);
            Console.WriteLine("Thankyou,you have successfully ended the process");


            Console.ReadLine();
        }

        public static void sort(List<string>data)
        {

            data.Sort();
            string sortednewfile = @"C:\Users\brother\Desktop\project-3\studentdataaftersort.txt";



            var newfile = File.Create(sortednewfile);
            newfile.Close();
            File.WriteAllLines(sortednewfile, data);

            foreach (var lines in data)
            {
                Console.WriteLine(lines);
            }

            
        }

        public static void search(List<string>data)
        {
            string studentname;
            Console.WriteLine("Enter the studentname to search");
            studentname=Console.ReadLine();
            bool namesearch = false;
             

            foreach(var line in data)
            {
                if (line.Split(',')[0].Equals(studentname))
                {
                    Console.WriteLine("Student details found : ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Name ofthe Student : " + line.Split(',')[0]);
                    Console.WriteLine("Class of the student : " + line.Split(',')[1]);
                    namesearch = true;
                    break;

                }
              
            }
            if (!namesearch)
            {
                Console.WriteLine("your entered name is not presnt in the file");
            }
        }
    }
}
