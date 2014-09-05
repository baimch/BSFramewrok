using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BSFramework.Models
{
    public class PigModels
    {
        [Required]
        [Key]
        public string PigGUID { get; set; }

        [Display(Name = "编号")]
        public string PigNumber { get; set; }
        [Display(Name = "购买日期")]
        public string PigbuyDate { get; set; }
         [Display(Name = "生产次数")]
        public string PigBornCount { get; set; }
         [Display(Name = "所在圈")]
         public BarrackModels PigJUAN { get; set; }
         [Display(Name = "现状")]
         public string PigState { get; set; }//0.带配种 1.待产 2.育仔

    }
}