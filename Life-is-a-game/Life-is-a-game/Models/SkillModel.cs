using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Life_is_a_game.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<UserSkill> UserSkills;

    }
}