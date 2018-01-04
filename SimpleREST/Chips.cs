using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleREST
{
    public class Chips
    {
        
        //PROPERTIES
        public int Id { get; set; }
        public string Name { get; set; }

        //DEFAULT CONSTRUCTOR
        public Chips()
        {}

        //PARAMETERISED CONSTRUCTOR
        public Chips(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //TOSTRING
        public override string ToString()
        {
            return "ID: " + Id + ", Navn: " + Name;
        }

    }
}