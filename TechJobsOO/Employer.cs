using System;
namespace TechJobsOO
{
    public class Employer
    {
        public int Id { get; }
        private readonly int nextId = 1;
        public string Value { get; set; }

        public Employer()
        {
            Id = nextId;
            nextId++;
        }

        public Employer(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}


//Drying Code comment out lines 4-37 and run this

//    public class Employer : JobField
//    {
//        public Employer(string value) : base(value)
//        { 
//        }

//    }
//}

