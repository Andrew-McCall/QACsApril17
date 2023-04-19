using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACsApril17
{
    internal abstract class Animal: Object
    {
        public string name = "Larry";
        public string scientifcName { get; init; }
        public int age { get; private set; }

        public void SetAge(int age)
        {
            if (age > 100 || age < 0) throw new Exception("Invaild age"); 
            this.age = age;
            // age = 532; // this uses the set; 
            // this.age   // this uses the get;
        }

        public abstract void Speak();


    }

    internal abstract class Mammal : Animal
    {

        public void growHair()
        {
            Console.WriteLine("##|#|#\\|\\##/#");
        }

        public override void Speak()
        {
            Console.WriteLine("Growl!");
        }

    }

    // Visbility // Type // Name : base,interfaces
    // classes: abstract static
    // variables: final static
    
    // visibities: public, private, internal, protected, private protected 

    internal abstract class Bird : Animal
    {

        public double wingspan { get; init; }

        public Bird(double wingspan)
        {
            this.wingspan = wingspan;
        }

        public override void Speak()
        {
            Console.WriteLine("Squak!");
        }

    }

    internal class Parrot : Bird, IPetable
    {
        public Parrot(string name, string scienceName) : base(10.0) // :base is constructor of super
        {
            this.name = name;
            this.scientifcName = scienceName;
        }
        public Parrot(string name, string scienceName, double wingspan) : base(wingspan)
        {
            this.name = name;
            this.scientifcName = scienceName;
        }


        public void Sing()
        {
            Console.WriteLine("Rrrrrrrrrrrr");
        }

        public void Pet()
        {
            Console.WriteLine("*Purrr*");
        }

    }

    internal class Dog : Mammal, IPetable, ITamable
    {
        public Dog(string name, string scienceName)
        {
            this.name = name;
            this.scientifcName = scienceName;
        }

        public Dog(string name)
        {
            this.name = name;
            this.scientifcName = "Canine";
        }

        public Dog()
        {
            this.name = "Larry";
            this.scientifcName = "Canine";
        }

        public override void Speak()
        {
            Console.WriteLine("Bark!");
        }

        public void Sit()
        {
            Console.WriteLine("*Sits*");
        }

        public void Pet()
        {
            Console.WriteLine("*Purrr*");
        }

        public void Pet(string bodyPart)
        {
            Console.WriteLine($"*purr* as you pet {this.name}'s {bodyPart}");
        }

        public void Tame()
        {
            Console.WriteLine("*Roll's Over*");
        }
        
    }

    internal class WildDog : Mammal
    {
        public WildDog(string name)
        {
            this.name = name;
            this.scientifcName = "roughly doggo";
        }

    }

    internal interface IPetable
    {
        void Pet();
    }

    internal interface ITamable
    {
        void Tame();
    }

    public interface ISinger
    {
        void Sing();
    }
    public interface IWriter
    {
        void Write();
    }
    public interface ISingerSongWriter: ISinger, IWriter
    {
        double cash { set; get;  }
        void Perform();
        void MakeMoney();
    }

    
}
