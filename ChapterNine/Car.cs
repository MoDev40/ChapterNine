using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterNine
{
     class Car
    {
        private Boolean start;
        private string year;
        private string make;
        private int speed;

        public Car() { }

        public Car(string year, string make)
        {
            this.make = make;
            this.year = year;
        }
        public Boolean Start
        {
            get { return start; }
            set { start = value; }
        }
        public string  Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int Speed
        {
            get { return speed; }
        }

        public void accelerate()
        {
            if (start)
            {
                if (speed <= 115)
                {
                    speed += 5;
                }
            }
        }

        public void brakeCar()
        {
            if (start)
            {
                if (speed != 0)
                {
                    speed -= 5;
                }
            }
         
        }

    }
}
