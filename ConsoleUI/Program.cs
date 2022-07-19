using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------------------
// CarLotSimulatorRevisited
//
// Name: David Zientara
// Date: 7-16-2022
// Comments: An exercise in abstract classes (exercise 1)
// Added methods per the instructions
//-----------------------------------------------------------------
namespace ConsoleUI
{
    abstract class Vehicle
    {
        // Year, Make, and Model - made them public this time:
        public string Year, Make, Model;
        // Constructor for Vehicle
        // PARAMS: year (string), make (string), model (string)
        public Vehicle(string year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"I'm driving a {Year} {Make} {Model}. This method can be overriden.");
            Console.WriteLine("==============================");
        }
        public Vehicle()
        {
            Year = "1970";
            Make = "Plymouth";
            Model = "Valiant";
        }
       
    }
    class Car: Vehicle
    {
        private bool HasTrunk { get; set; }
        public override void DriveAbstract()
        {

        }
        public void SetHasTrunk(bool val)
        {
            HasTrunk = val;
        }
       
    }
    class Motorcycle: Vehicle
    {
        private bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {

        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"I'm driving a {Year} {Make} {Model}. This method overrides the method from the base class.");
            Console.WriteLine("I don't want a pickle; I just want to ride on my motorcycle.");
            Console.WriteLine("==============================");
        }
        public void SetHasSideCart(bool val)
        {
            HasSideCart = val;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */
            // Done

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */
            // Done

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car Golf = new Car();
            Motorcycle Harley = new Motorcycle();
            Vehicle Festiva = new Car();
            Vehicle GTO = new Car();

            // Use mutators for private variables:
            Golf.SetHasTrunk(true);
            Harley.SetHasSideCart(true);
            //Use object intializer syntax for the public variables:
            Golf.Make = "Volkswagen";
            Golf.Model = "Golf";
            Golf.Year = "1992";
            Harley.Year = "2022";
            Harley.Make = "Harley Davidson";
            Harley.Model = "Fat Boy";
            Festiva.Make = "Ford";
            Festiva.Model = "Festiva";
            Festiva.Year = "2005";
            GTO.Make = "Pontiac";
            GTO.Model = "GTO";
            GTO.Year = "2018";






            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            // Call each of the drive methods for one car and one motorcycle
            // Declare a list an add to them:
            List<Vehicle> list = new List<Vehicle>();
            list.Add(Golf);
            list.Add(Harley);
            list.Add(Festiva);
            list.Add(GTO);
            // Iteration: 
            foreach (Vehicle v in list)
            {
                if (v.Equals(Golf))
                    v.DriveVirtual();
               else if (v.Equals(Harley))
                    v.DriveVirtual();
            }

            #endregion
            Console.ReadLine();
        }
    }
}