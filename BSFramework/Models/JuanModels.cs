using DatabaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BSFramework.Models
{
    public class JuanModels
    {
        [Required]
        [Key]
        public string JuanGUID { get; set; }
        [Required]
        [Display(Name = "名称")]
        public string JuanName { get; set; }
        [Display(Name = "编号编号编号")]
        public string JuanNumber { get; set; }

        [Required]
        [Display(Name = "面积")]
        public string JuanArea { get; set; }
        [Display(Name = "容量")]
        public string Juancapacity { get; set; }
        [Display(Name = "造价")]
        public string JuanPrice { get; set; }
        [Display(Name = "建造年份")]
        public string Juanbirth { get; set; }

        public CompanyModels company { get; set; }
    }
}