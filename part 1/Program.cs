using System;
using System.Buffers;
/// Homework 9
/// File Name: vehicles and their owners
/// @author: Dakota Durst
/// Date: November 8st, 2020
///
/// Problem Statement: 
/// create a class called Vehicle that has the Manufracturer name (enum), number of Cyclinders in the engine (int), and the owner (Person, see below). 
///
///
/// Overall Plan:
/// 1) create the 3 classes, trucks person and vehicles
/// 2) in person class create the persons name and the contructors needed
/// 3) create vehicle class (subset of person) and create the constructors in addition to using person's name
/// 4) creat truck class (subset of vehicle class) and create the constructors needed, while keeping person's name and using truck details from other class
/// 5) in main test out the code 

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
