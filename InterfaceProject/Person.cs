using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProject
{
    public class Person : IEquatable<Person>, IComparable<Person>, ICloneable
    {
        public string Name { get; }
        public string Address { get; }
        public DateTime Dob { get; }

        public Person(string name, string address, DateTime dob)
        {
            Name = name;
            Address = address;
            Dob = dob;
        }

        public bool Equals(Person? other)
        {
            return other != null && 
                Name.Equals(other.Name) && 
                Address.Equals(other.Address) && 
                Dob.Equals(other.Dob);
        }

        public int CompareTo(Person? other)
        {
            if (other == null) return 1;

            //return this.Dob.Millisecond - other.Dob.Millisecond ;

            /*
            if (this.Dob < other.Dob) return -1;
            if (this.Dob > other.Dob) return 1;
            return 0
            */

            return this.Dob.CompareTo(other.Dob);   
        }

        public object Clone()
        {
            return new Person(Name, Address, Dob);
        }

    }

}
