using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
   public class HrefModels
    {
       [Required]
       [Key]
       public string ID { get; set; }
       
        [Required]
        [Display(Name = "图标")]
        public string icon { get; set; }
        [Display(Name = "链接")]
        public string link { get; set; }
        [Display(Name = "名称")]
        public string title { get; set; }
        public int iFrame { get; set; }
        public virtual AccordionModels  Accordion { get; set; }

        


       
    }
}
