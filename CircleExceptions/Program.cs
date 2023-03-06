using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double positiveRadius = 500;
            double negativeRadius = -500;
            double zeroRadius = 0;

            


            try
            {
                //wath causes the exception
                //POSITIVE
                Circle positiveCircle = new Circle(positiveRadius);

                //NEGATIVE
                Circle negativeCircle = new Circle(negativeRadius);
                negativeCircle.SetRadius(negativeRadius);

                //ZERO
                Circle zeroCircle = new Circle(zeroRadius);
                zeroCircle.SetRadius(zeroRadius);
            } 
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine("The radius " + ex.Message );
                Console.WriteLine("Something went wrong! But we can continue...");
            }



            
           
        }
    }
}
