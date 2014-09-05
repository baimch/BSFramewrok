using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BSFramework.Models
{
    public class BarrackModels
    {
        [Required]
        [Key]
        public string BarrackGUID { get; set; }
        [Required]
        [Display(Name = "屋舍名称")]
        public string BarrackName { get; set; }
        [Display(Name = "屋舍编号")]
        public string BarrackNumber { get; set; }

        [Required]
        [Display(Name = "屋舍面积")]
        public string BarrackArea { get; set; }
        [Display(Name = "容量")]
        public string Barrackcapacity { get; set; }
        [Display(Name = "造价")]
        public string BarrackPrice { get; set; }
        [Display(Name = "建造年份")]
        public string Barrackbirth { get; set; }

        public CompanyModels company { get; set; }
    }
}