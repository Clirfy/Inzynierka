using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public interface IRequestRepository
    {
        Request AddRequest(Request request);
        IEnumerable<Request> GetAllRequests();

        IEnumerable<Request> GetUserRequests(string userId);
    }
}
