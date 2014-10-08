using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    //导航分组实体类
   public  class AccordionModels
    {
       [Required]
       [Key]
       public string ID { get; set; }
        [Required]
        [Display(Name = "名称")]
        public string title { get; set; }
        [Display(Name = "icon")]
        public string icon { get; set; }
        [Display(Name = "顺序号")]
        public int order { get; set; }

        public virtual ICollection<HrefModels> Hrefs { get; set; }
    }
}
