using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class



            var bird1 = new Bird();
            bird1.BirdSize = "29 inches";
            bird1.Species = "Penguin";
            bird1.UsableWings = false;
            bird1.LayEggs = 4;
            bird1.Legs = "2";
            bird1.HasTail = true;
            Console.WriteLine($"This Bird is a{bird1.Species} and is {bird1.BirdSize} tall. Usually they lay {bird1.LayEggs} eggs"+
                $" and {bird1.UsableWings}");
            Console.WriteLine();

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var reptile1 = new Reptile();
            reptile1.Scales = "Green Scales";
            reptile1.Species = "Snake";
            reptile1.IsPoisonous = true;
            reptile1.IsAmphibious = false;
            reptile1.HasTail = true;
            reptile1.EnviromentType = "Rain Forest";
            Console.WriteLine($"This reptile is a {reptile1.Species} it has {reptile1.Scales} and {reptile1.IsPoisonous} but {reptile1.IsAmphibious}");
            Console.WriteLine();
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
