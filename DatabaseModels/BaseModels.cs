using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public class BaseModels
    {
        [Required]
        [Key]
        public string ID { get; set; }
    }
}
