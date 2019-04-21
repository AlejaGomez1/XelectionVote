namespace XelectionVote.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Candidate : IEntity
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

        public User User { get; set; }

        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImageUrl))
                {
                    return null;
                }
                return $"https://xelectionvote.azurewebsites.net{this.ImageUrl.Substring(1)}";
            }
        }
    }
}
