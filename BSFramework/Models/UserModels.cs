using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BSFramework.Models
{
    public class UserModels
    {
        [Required]
        public string UserGUID { get; set; }
        [Required]
        [Display(Name = "用户名")]
        public string  UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }
    }
}