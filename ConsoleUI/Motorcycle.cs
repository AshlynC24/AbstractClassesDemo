using System;
namespace ConsoleUI
{
    public class Motorcycle: Vehicle
	{
		public Motorcycle()
		{
		}
        public bool HasSideCart { get; set; }
        public int HorsePower { get; set; }


        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is in drive."); 
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This motorcycle is virtually in drive");
        }
    }
}

