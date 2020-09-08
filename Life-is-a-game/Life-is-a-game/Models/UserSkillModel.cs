using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Life_is_a_game.Models
{
    /// <summary>
    /// Пользовательский навык
    /// </summary>
    public class UserSkill
    {              
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }    
        /// <summary>
        /// Навык
        /// </summary>
        [Required]
        public Skill Skill { get; set; }
        /// <summary>
        /// Значение
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public string AspNetUsers_Id { get; set; }
      //  public virtual ApplicationUser User { get; set; }





    }
}