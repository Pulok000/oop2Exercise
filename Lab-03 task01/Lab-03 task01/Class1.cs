using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_task01
{
    public class Student
    {

        private string name;
        private string id="21-100";
        private double cgpa;

        int count = 0;
        //string id = "20-39100-1";

        public Student()
        {
            this.count = count + 1;
            this.id = id+count+"-1";
        
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Id
        {
           // set { id = value; }
            get { return id; }
        }

        public double Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }


    }
}
