using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOUT.Models
{
    public class SQLRequestRepository : IRequestRepository
    {
        private readonly AppDbContext dbContext;

        public SQLRequestRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Request AddRequest(Request request)
        {
            dbContext.Requests.Add(request);
            dbContext.SaveChanges();
            return request;
        }

        public Request DeleteRequest(string requestId)
        {
            var request = dbContext.Requests.Find(requestId);

            if (request != null)
            {
                dbContext.Requests.Remove(request);
                dbContext.SaveChanges();
            }
            return request;
        }

        public IEnumerable<Request> GetAllRequests()
        {
            return dbContext.Requests;
        }

        public Request GetRequest(string id)
        {
            return dbContext.Requests.Find(id);
        }

        public IEnumerable<Request> GetUserRequests(string userId)
        {
            return dbContext.Requests.Where(n => n.UserID == userId);
        }

        public Request UpdateRequest(Request requestChanges)
        {
            var request = dbContext.Requests.Attach(requestChanges);
            request.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();

            return requestChanges;
        }
    }
}
