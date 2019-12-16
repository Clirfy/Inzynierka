using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOUT.Models
{
    interface IRequestRepository
    {
        Request AddRequest(Request request);
        IEnumerable<Request> GetAllRequests();
        Request GetRequest(string id);
        IEnumerable<Request> GetUserRequests(string userId);
        Request DeleteRequest(string requestId);
        Request UpdateRequest(Request requestChanges);
    }
}
