using System;
namespace ConsoleUI
{
    public class Car : Vehicle // this is inheritance
    {
		public Car()
		{
		}
        public string Color { get; set; }
        public bool HasFourWheelDrive{ get; set; }


        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in Drive");
        }
    }
}

