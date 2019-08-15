using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
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

        public IEnumerable<Request> GetAllRequests()
        {
            return dbContext.Requests;
        }

        public IEnumerable<Request> GetUserRequests(string userId)
        {
            return dbContext.Requests.Where(n => n.UserId == userId);
        }
    }
}
