using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public interface IPassageRepository
    {
        Passage AddPassage (Passage passage);
        IEnumerable<Passage> GetAllPassages();

        IEnumerable<Passage> GetUserPassages(string userId);

    }
}
