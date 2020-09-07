using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Life_is_a_game.Models
{
    public class DeltaSkill
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public Skill Skill { get; set; }
        public int Delta { get; set; }
    }
}