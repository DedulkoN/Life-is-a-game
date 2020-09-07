using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Life_is_a_game.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        { }

        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}