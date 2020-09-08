using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Life_is_a_game.Models
{
    /// <summary>
    /// Группы навыков
    /// </summary>
    public class SkillGroup
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Связанные навыки
        /// </summary>
        public List<Skill> Skills { get; set; }

    }
}