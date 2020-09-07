using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Life_is_a_game.Models
{
    public class UserSkill
    {              
        public int id { get; set; }      
        [Required]
        public Skill Skill { get; set; }

        public int value { get; set; }

        public string UserId { get; set; }
      //  public virtual ApplicationUser User { get; set; }





    }
}