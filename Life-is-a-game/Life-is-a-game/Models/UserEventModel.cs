﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Life_is_a_game.Models
{
    /// <summary>
    /// События с пользователями
    /// </summary>
    public class UserEvent
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Событие
        /// </summary>
        public Event Event { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public string AspNetUsers_Id { get; set; }
        /// <summary>
        /// Дата произошедшего
        /// </summary>
        public DateTime Date { get; set; }

    }
}