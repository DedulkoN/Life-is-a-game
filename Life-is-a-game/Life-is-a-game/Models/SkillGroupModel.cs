using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Life_is_a_game.Models
{
    public class SkillGroup
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<Skill> Skills { get; set; }

    }
}