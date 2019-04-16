namespace XelectionVote.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    
    public class User : IdentityUser
    {
        [MaxLength(60)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(60)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(60)]
        public string Occupation { get; set; }

        [Range(1, 10, ErrorMessage = "The {0} must be a value between {1} and {2}")]
        public int Stratum { get; set; }

        public int Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime Bithdate { get; set; }

        public int Ciudad { get; set; }
    }
}
