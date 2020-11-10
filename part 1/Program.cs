using System;
using System.Buffers;

namespace part_1
{
	
class Program
    {
        static void Main(string[] args)
        {
			Person owner1 = new Person("Nathan Roy");
			Person owner2 = new Person("Peter England");
			Vehicle aCar = new Vehicle("Honda", 5, owner2);
			Truck aTruck = new Truck();
			aTruck.setmf("Skoda");
			aTruck.setcd(100);
			aTruck.setown(owner1);
			aTruck.setload(150.50);
			aTruck.setcapacity(3200);
			Console.WriteLine("Truck Details: ");
			Console.WriteLine(aTruck.getmf());
			Console.WriteLine(aTruck.getcd());
			Console.WriteLine(aTruck.getown());
			Console.WriteLine(aTruck.getload());
			Console.WriteLine(aTruck.getcapacity());
			Console.WriteLine();
			Console.WriteLine("Details of Vehicle 1: ");
			Console.WriteLine(aCar.toString());
			Console.WriteLine("Details of Vehicle 2: ");
			Console.WriteLine(aTruck.toString());

		}
    }
}
