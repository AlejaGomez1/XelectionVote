namespace XelectionVote.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class Candidate
    {
        public int Id { get; set; }

        [MaxLength(60, ErrorMessage = "The {0} of the event can contain up to {1} characters")]
        [Required]
        public string Name { get; set; }

        [MaxLength(300, ErrorMessage = "The {0} of the event can contain up to {1} characters")]
        [Required]
        public string Proposal { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        public User User  { get; set; }

    }
}
