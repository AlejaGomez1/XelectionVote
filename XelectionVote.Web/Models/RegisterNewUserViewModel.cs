namespace XelectionVote.Web.Models
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class RegisterNewUserViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Occupation { get; set; }

        [Range(1, 10, ErrorMessage = "The {0} must be a value between {1} and {2}")]
        public int Stratum  { get; set; }

        public int Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime Bithdate { get; set; }

        [Display(Name = "City")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a city")]
        public int CityId { get; set; }

        public IEnumerable<SelectListItem> Cities { get; set; }

        [Display(Name = "Country")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a country")]
        public int CountryId { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string Confirm { get; set; }

    }

}

