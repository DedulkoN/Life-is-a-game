using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Life_is_a_game.Models
{
    /// <summary>
    /// Изменение навыков у пользователя
    /// </summary>
    public class DeltaSkill
    {
        /// <summary>
        /// ИД уникальный ключ
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Событие, вызвавшее изменение
        /// </summary>
        public Event Event { get; set; }
        /// <summary>
        /// Измененный навык
        /// </summary>
        public Skill Skill { get; set; }
        /// <summary>
        /// Размер изменения
        /// </summary>
        public int Delta { get; set; }
    }
}