namespace XelectionVote.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Vote : IEntity
    {
        public int Id { get; set; }

        public Candidate Candidate { get; set; }

        public Event Event { get; set; }

        public User User { get; set; }
        
        //public IEnumerable<Vote>Items { get; set; }

        //public double Quantity { get { return this.Items == null ? 0 : this.Items.Sum(i => i.Quantity); } }
    }
}
