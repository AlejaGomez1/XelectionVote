namespace XelectionVote.Web.Data.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.ComponentModel.DataAnnotations;

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

        public int CityId { get; set; }

        public City City { get; set; }
    }
}

