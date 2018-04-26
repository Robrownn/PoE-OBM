using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PoE_OBM.Models
{
    public class ExileBuild
    {
        [Required]
        public int id { get; set; }

        public int userId { get; set; }
        public string Name { get; set; }

        [Display(Name="Class")]
        public BuildClass ExileClass { get; set; }
    }
}