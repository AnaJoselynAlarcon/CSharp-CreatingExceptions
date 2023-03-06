using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleExceptions
{
    internal class InvalidRadiusException : Exception
    {

        //no argument constructor 
        public InvalidRadiusException() : base("Invalid radius")
        {
            //prints a message when the radius is greater than zero
            
        }

        public double Radius { get; set; }

        //constructor accepts the value of the radius 
        public InvalidRadiusException(double radius) : base("Invalid radius: " + radius)
        {
            //prints the raduis along with a message that it is not valid.
            this.Radius= radius;
        }
    }
}
