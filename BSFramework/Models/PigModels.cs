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

    }
}