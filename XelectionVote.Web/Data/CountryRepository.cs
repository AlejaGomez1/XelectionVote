using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XelectionVote.Web.Data.Entities;

namespace XelectionVote.Web.Data
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DataContext context) : base(context)
        {
        }
    }
}
