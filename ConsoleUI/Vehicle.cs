using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		//abstract class is a partial template
		public string Year { get; set; } = "2015";// three string properties 
		public string Make { get; set; } = "Ford"; //this is setting the defaults to something generic 
		public string Model { get; set; } = "F-150";

		public abstract void DriveAbstract();//stubbed out method with no implementation 

        public virtual void DriveVirtual()
        {
			//this needs implementation 
        }
    }

}

