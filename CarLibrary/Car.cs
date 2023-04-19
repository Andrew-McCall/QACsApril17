namespace CarLibrary
{
    // Static: Tells the complier everything must be static (no constuctors)
    // Abstract: Tells the complier no-one cannot instantiate the class - allows abstract methods (no behaviour)
    public class Car
    {

        public static int id { get; set; }

        public int Speed { 

            get { 
                return _speed; 
            } 

            set {
                if (value < 0 || value > 100) throw new Exception();
                _speed = value; 
            } 

        }

        public double SpeedInKilometers { get { return _speed * 1.609344; } }
        public string? RegistrationNumber { get; set; }

        public string Make { get; set; }
        public string Model { get; set; } // readonly and only set in the constructor
        public string Colour { get; set; }

        private int _speed = 0;

        // base is super class. this is local constructors
        public Car() : this("Unknown Make", "Unknown Model") 
        {}

        public Car(string make, string model) : this(make, model, "No Colour")
        {}

        public Car(string make, string model, string colour)
        {
            this.Make = make;
            this.Model = model;
            this.Colour = colour;
        }

        public override string ToString()
        {
            return $"Car=[Make:{Make}, Model:{Model}, Colour:{Colour}, Reg:{RegistrationNumber}, Speed:{Speed}]";
        }

    }
}