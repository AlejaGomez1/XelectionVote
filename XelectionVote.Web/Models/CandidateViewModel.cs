namespace XelectionVote.Web.Models
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Http;
    using Data.Entities;

    public class CandidateViewModel : Candidate
    {

        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

        public int EventId { get; set; }

        public int CandidateId { get; set; }

        [Required]
        [MaxLength(60, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public new string Name { get; set; }

        [MaxLength(300, ErrorMessage = "The {0} of the event can contain up to {1} characters")]
        [Required]
        public new string Proposal { get; set; }   
    }
}






