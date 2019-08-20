using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public class SQLPassageRespository : IPassageRepository
    {
        private readonly AppDbContext dbContext;

        public SQLPassageRespository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Passage AddPassage(Passage passage)
        {
            dbContext.Passages.Add(passage);
            dbContext.SaveChanges();

            return passage;
        }

        public IEnumerable<Passage> GetAllPassages()
        {
            return dbContext.Passages;
        }

        public IEnumerable<Passage> GetUserPassages(string userId)
        {
            return dbContext.Passages.Where(n => n.UserId == userId);
        }
    }
}
