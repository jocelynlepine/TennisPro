using System;
using System.Collections.Generic;
using System.Text;

namespace ApplocationCore.Entities
{
    public class Player : BaseEntity
    {
        public string Name { get; set; }

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

    
