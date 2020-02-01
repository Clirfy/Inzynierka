using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public interface IHangfireRepository
    {
        void DeleteExpiredAdverts();
    }

    public class HangfireRepo : IHangfireRepository
    {
        private readonly AppDbContext dbContext;

        public HangfireRepo(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void DeleteExpiredAdverts()
        {
            foreach (var item in dbContext.Adverts)
            {
                if (item.ExpireDate <= DateTime.Now &&
                    item.ExpireTime.Hour <= DateTime.Now.Hour &&
                    item.ExpireTime.Minute <= DateTime.Now.Minute)
                {
                    dbContext.Adverts.Remove(item);
                }
            }
            dbContext.SaveChanges();
        }
    }
}
