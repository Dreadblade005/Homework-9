using System;
using System.Collections.Generic;
using System.Text;

namespace part_1
{
  public class Vehicle: Person
	{
		public String mf;//manufactor 
		public int cd; //cylinder 
		public string own;//owner 

		public Vehicle()
		{
			mf = "none";
			cd = 1;
			own = null;
		}
		public Vehicle(String themf, int numcd, Person theown)
		{
			mf = themf;
			cd = numcd;
			own = theown.getName();
		}
		public Vehicle(Vehicle other)
		{
			mf = other.mf;
			cd = other.cd;
			own = other.own;
		}
		public void setmf(String newmf)
		{
			mf = newmf;
		}
		public void setcd(int newNum)
		{
			cd = newNum;
		}
		public void setown(Person newown)
		{
			own = newown.getName();
		}
		public String getmf()
		{
			return mf;
		}
		public int getcd()
		{
			return cd;
		}
		public string getown()
		{
			return own;
		}
		public String toString()
		{
			return mf + ", " + cd + " cd, owned by " + getown();
		}
		public Boolean equals(Vehicle other)
		{
			return mf.Equals(other.mf) && cd == other.cd;
		}
	}
}
