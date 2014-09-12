using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace  DatabaseModels
{
    public class CompanyModels
    {
        [Required]
        [Key]
        public string CompanyGUID { get; set; }
        [Required]
        [Display(Name = "公司名")]
        public string CompanyName { get; set; }
        [Required]
        [Display(Name = "公司编码")]
        public string CompanyCode { get; set; }
        [Required]
        [Display(Name = "公司地址")]
        public string CompanyAddress { get; set; }
    }
}