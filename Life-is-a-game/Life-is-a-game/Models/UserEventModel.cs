using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Life_is_a_game.Models
{
    public class UserEvent
    {
        public int id { get; set; }
        public Event Event { get; set; }
        public string AspNetUsers_Id { get; set; }
        public DateTime Date { get; set; }

    }
}