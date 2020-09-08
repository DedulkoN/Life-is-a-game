using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace Life_is_a_game.Models
{
    /// <summary>
    /// Событие
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Группа
        /// </summary>
        public EventGroup EventGroup { get; set; }
        /// <summary>
        /// События с пользователями
        /// </summary>
        public List<UserEvent> UserEvents { get; set; }
        /// <summary>
        /// Изменения навыков
        /// </summary>
        public List<DeltaSkill> DeltaSkills { get; set; }


    }
}