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
        [Key]
        public string UserGUID { get; set; }
        [Required]
        [Display(Name = "用户名")]
        public string  UserName { get; set; }
        [Display(Name = "用户工号")]
        public string UserNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }
        [Display(Name = "出生日期")]
        public string UserBirthDay { get; set; }
        [Display(Name = "电话号")]
        public string UserPhone { get; set; }
        [Display(Name = "邮箱")]
        public string UserMail { get; set; }
       
    }
}