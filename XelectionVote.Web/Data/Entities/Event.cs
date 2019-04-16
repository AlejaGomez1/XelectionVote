namespace XelectionVote.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class Event
    {
        public int Id { get; set; }

        [MaxLength(60, ErrorMessage = "The {0} of the event can contain up to {1} characters")]
        [Required]
        public string Name { get; set; }

        [MaxLength(120, ErrorMessage = "The {0} of the event can contain up to {1} characters")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        public User User { get; set; }

    }
}
