using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism1
{
    class Program
    {


        class Car1
        {
            //using the virtual keyword on the METHOD to state that it can be overridden 
            public virtual void wheelType()
            {
                Console.WriteLine("Wheel inches: 18");
            }
        }

        class wheel1 : Car1
        {
            //used the override keyword to override the original method of "wheeltype" and change the statement to a new one for this instances
            public override void wheelType()
            {
                Console.WriteLine("wheel inches: 19");
            }
        }

        class wheel2 : Car1
        {
            //the keyword "new" in the method cannot overide the original method of "wheelType" in most cases, even though it seams legit to try
            public new void wheelType()
            {
                Console.WriteLine("wheel inches: 20");
            }
        }
        static void Main(string[] args)
        {
            //creating a list of the wheels derived from the Car1 class
            List<Car1> wheels = new List<Car1>();

            //adding members to the list
            wheels.Add(new Car1());
            wheels.Add(new wheel1());
            wheels.Add(new wheel2());

            //using a "foreach" method to list objects of Car1 added to the list named "wheels"
            //listing the objects as "w"'s in the list to itterate through them
            foreach (Car1 w in wheels)
            {
                //using the name of each w to access the method they all share
                w.wheelType();
            }

            Console.ReadLine();

        }
    }
}
