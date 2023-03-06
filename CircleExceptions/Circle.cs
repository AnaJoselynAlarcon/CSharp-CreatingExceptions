using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CircleExceptions
{
    internal class Circle
    {

        //attribute
        public double radius;


        //get
        public double Radius 
        { 
            get;
        }

        //constructor
        public Circle(double radius)
        {
            SetRadius(radius);
        }


        //Methods
        /// <summary>
        /// SetRadius method: checks whether the radius is greater than zero. 
        /// If the radius is greater than zero, it sets it.
        /// If the radius is equal to or less than zero, the method throws the exception InvalidRadiusException
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidRadiusException"></exception>
        public void SetRadius(double radius)
        {
            //If the radius is greater than zero, it sets it
            if (radius <= 0.0)
            {
                throw new InvalidRadiusException(radius);
            }

            this.radius = radius;

        }

        public override string ToString()
        { 
            return $"This circle has a radius {radius}"; 
        }
    }
}
