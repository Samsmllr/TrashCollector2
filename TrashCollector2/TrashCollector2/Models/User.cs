using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector2.Models
{

public class User : IdentityUser
    {
        [Display(Name = "Name")]
        [MaxLength (50)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Address")]
        [MaxLength(100)]
        [Required]
        public string Address { get; set; }
        
        [Display(Name = "Address Two")]
        [MaxLength(100)]
        public string AddressTwo { get; set; }

        [Display(Name = "State")]
        [Required]
        public string StateIs { get; set; }

        [Display(Name = "ZipCode")]
        [Required]
        public string Zip { get; set; }

    }
}
