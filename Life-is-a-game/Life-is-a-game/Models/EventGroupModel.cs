using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Life_is_a_game.Models
{

    /// <summary>
    /// Группа событий
    /// </summary>
    public class EventGroup
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название группы
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Список связанных событий
        /// </summary>
        public List<Event> Events { get; set; }
    }
}