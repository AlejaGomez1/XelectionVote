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

        public string Name { get; set; }

        public string Proposal { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

    }
}
