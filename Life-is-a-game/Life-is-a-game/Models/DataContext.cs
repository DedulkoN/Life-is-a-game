using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Life_is_a_game.Models
{
    /// <summary>
    /// Контекст данных
    /// </summary>
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        { }

        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillGroup> SkillGroups { get; set; }
        public DbSet<UserEvent> UserEvents { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<DeltaSkill> DeltaSkills { get; set; }
        public DbSet<EventGroup> EventGroups { get; set; }

    }
}