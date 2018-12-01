using System;
using System.Collections.Generic;
using System.Text;

namespace ApplocationCore.Entities.Match
{
    public class Match : BaseEntity
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
    }
}
