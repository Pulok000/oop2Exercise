using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {

        private string name;
        private string id;
        private double cgpa;



        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Id
        {
            set { id = value; }
            get { return id; }
        }

        public double Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }





    }
}
