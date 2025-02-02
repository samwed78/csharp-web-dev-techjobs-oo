﻿using System;
namespace TechJobsOO
{
    public class PositionType
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            Value = value;
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.


        public override bool Equals(object obj)
        {
            return obj is PositionType position &&
                Id == position.Id;
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

//Drying Code comment out lines 4-39 and run this

//    public class PositionType : JobField
//    {
//        public PositionType(string value) : base(value)
//        {
//        }

//    }
//}