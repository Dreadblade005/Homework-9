using System;
using System.Collections.Generic;
using System.Text;

namespace part_1
{
	public class Person
	{
		public string printname;
		public String name;
		public Person()
		{
			name = "none";
		}
		public Person(String theName)
		{
			name = theName;
			printname = name;
		}
		public Person(Person theObject)
		{
			name = theObject.name;
		}
		public String getName()
		{
			return name;
		}
		public void setName(String theName)
		{
			name = theName;
		}
		public String toString()
		{
			printname = name;
			return printname;
		}
		public Boolean equals(Object other)
		{
			return name.Equals(((Person)other).name);
		}
	}
}
