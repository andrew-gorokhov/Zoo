namespace Zoo
{
    public class Animal
    {
        public string Name {  get; set; }
       
        public string Sound {  get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} издает звук {Sound}");
        }
    }
    public class Tiger : Animal
    {
        public Tiger(string name, string sound) : base() 
        {
            Name = name;
            Sound = sound;
        }
    }

    public class Giraffe : Animal
    {
        public Giraffe(string name, string sound) : base()
        {
            Name = name;
            Sound = sound;
        }
    }

    public class Bear : Animal
    {
        public Bear(string name, string sound) : base()
        {
            Name = name;
            Sound = sound;
        }
    }

    public class Penguin : Animal
    {
        public Penguin(string name, string sound) : base()
        {
            Name = name;
            Sound = sound;
        }
    }

    public class Moose : Animal
    {
        public Moose(string name, string sound) : base()
        {
            Name = name;
            Sound = sound;
        }
    }

    public class Rabbit : Animal
    {
        public Rabbit(string name, string sound) : base()
        {
            Name = name;
            Sound = sound;
        }
    }

    public class Hippopotamus : Animal
    {
        public Hippopotamus(string name, string sound) : base()
        {
            Name = name;
            Sound = sound;
        }
    }
}