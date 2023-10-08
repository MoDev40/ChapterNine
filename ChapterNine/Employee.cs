using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterNine
{
     class Employee
    {
        //data field attribitute 

        private string name;
        private int idNumber;
        private string department;
        private string position;


        //constructor initializer 
        public Employee() { } /*no argument or constructor parameter less */

        public Employee( string newName , int idNumber,string department , string position) /*  parameterized cons*/
        {
            name = newName;
            this.idNumber = idNumber;
            this.department = department;
            this.position = position;
        }

        //properties or accessers modifiers 

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Department
        {
            get { return department; } 
            set { department = value; }
        }
        
        public int IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value;}
        }

    }
}
