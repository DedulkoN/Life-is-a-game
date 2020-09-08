using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace Life_is_a_game.Models
{
    /// <summary>
    /// Навык
    /// </summary>
    public class Skill
    {
        
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Группа навыков
        /// </summary>
        public SkillGroup SkillGroup { get; set; }
        /// <summary>
        /// Связанные пользовательские навыки
        /// </summary>
        public List<UserSkill> UserSkills { get; set; }
        /// <summary>
        /// Связанные изменения навыков
        /// </summary>
        public List<DeltaSkill> DeltaSkills { get; set; }

    }
}