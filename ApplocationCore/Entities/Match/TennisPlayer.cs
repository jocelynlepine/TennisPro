using System;
using System.Collections.Generic;
using System.Text;

namespace ApplocationCore.Entities.Match
{
    public class TennisPlayer : BaseEntity
    {
        public string Name { get; set; }

        public TennisPlayer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
