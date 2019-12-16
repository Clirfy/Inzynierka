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
        Request GetRequest(string id);
        IEnumerable<Request> GetUserRequests(string userId);
        Request DeleteRequest(string requestId);
        Request UpdateRequest(Request requestChanges);
        IEnumerable<Request> RequestSearchResults(string CityFrom, string CityTo);
    }
}
