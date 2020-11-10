using System;
using System.Collections.Generic;
using System.Text;

namespace part_1
{
	public class Truck : Vehicle
	{

		public double load;
		public int capacity;
		public Truck()
		{

			load = 0;
			capacity = 0;
		}
		public Truck(String m, int c,
				 Person p, double loads, int capc)
		{

			mf = m;
			cd = c;
			own = p.getName();
			load = loads;
			capacity = capc;
		}


		public Truck(Truck oth)
		{
			load = oth.load;
			capacity = oth.capacity;
		}
		public void setload(double newLoad)
		{
			load = newLoad;
		}
		public void setcapacity(int newCaps)
		{
			capacity = newCaps;
		}
		public double getload()
		{
			return load;
		}
		public int getcapacity()
		{
			return capacity;
		}
		public String toString()
		{
			return base.toString() + " truck has: " + load + " lbs load, with a: " + capacity + " pound tow attached";
		}
		public Boolean equals(Truck oth)
		{
			return load == oth.load && capacity == oth.capacity;
		}
	}
}


