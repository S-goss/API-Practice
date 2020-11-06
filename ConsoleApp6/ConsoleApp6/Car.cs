using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Car
    {
        private int speed = 0;



        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        //C# Class Methods 

            /// <summary>
            /// Starts the car driving at 10 MPH
            /// </summary>
        public void Drive()
        {
            speed = 10;
        }
        /// <summary>
        /// Drive methods takes 1 input and updates the variable speed.
        /// </summary>
        /// <param name="speed">Speed to set</param>

        public void Drive(int speed)
        {
            this.speed = speed;
        }
    }
}
