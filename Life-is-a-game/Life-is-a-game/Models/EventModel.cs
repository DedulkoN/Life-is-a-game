using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace Life_is_a_game.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<UserEvent> UserEvents { get; set; }
        public List<DeltaSkill> DeltaSkills { get; set; }

    }
}