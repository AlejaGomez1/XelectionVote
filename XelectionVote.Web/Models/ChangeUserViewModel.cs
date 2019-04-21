namespace XelectionVote.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ChangeUserViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Occupation { get; set; }

        [Range(1, 10, ErrorMessage = "The {0} must be a value between {1} and {2}")]
        public int Stratum { get; set; }

        public int Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime Bithdate { get; set; }

        [Display(Name = "City")]
        public int City { get; set; }
    }
}

