using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ClassLibrary1;
namespace Lab_03_task01
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            //int n;

            double cgpa;

            Console.WriteLine("Please Enter Student Information: ");

            System.Console.Write("Name: ");

            name = System.Console.ReadLine();


            System.Console.Write("CGPA: ");

            cgpa = System.Convert.ToDouble(System.Console.ReadLine());


            /*

            Console.WriteLine("Number of users: ");

            n=System.Convert.ToInt32(System.Console.ReadLine());

            Console.WriteLine("Please Enter Student Information: ");
           // Student s[]=new Student[n];

            for (int i = 0; i < n; i++)
            {


                Student 

               Student s[i]= new Student();
                s[i].Name=name;
                s[i].Cgpa=cgpa;
            }
            */
            


            Student s1 = new Student();

           s1.Name = name;
           s1.Cgpa = cgpa;




            System.Console.WriteLine("Students Information: ");

            System.Console.WriteLine("Name: " + s1.Name);
            System.Console.WriteLine("ID: " + s1.Id);
            System.Console.WriteLine("CGPA: " + s1.Cgpa);





            System.Console.ReadKey();


        }
    }
}
