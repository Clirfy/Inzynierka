using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportServicesApp.Models
{
    public class SQLAdvertRespository : IAdvertRepository
    {
        private readonly AppDbContext dbContext;

        public SQLAdvertRespository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Advert AddAdvert(Advert advert)
        {
            dbContext.Adverts.Add(advert);
            dbContext.SaveChanges();

            return advert;
        }

        public Advert DeleteAdvert(string advertId)
        {
            var advert = dbContext.Adverts.Find(advertId);
            if(advert != null)
            {
                dbContext.Adverts.Remove(advert);
                dbContext.SaveChanges();
            }
            return advert;
        }

        public Advert GetAdvert(string Id)
        {
            return dbContext.Adverts.Find(Id);
        }

        public IEnumerable<Advert> GetAllAdverts()
        {
            return dbContext.Adverts;
        }

        public IEnumerable<Advert> GetUserAdverts(string userId)
        {
            return dbContext.Adverts.Where(n => n.UserId == userId);
        }

        public Advert UpdateAdvert(Advert advertChanges)
        {
            var advert = dbContext.Adverts.Attach(advertChanges);
            advert.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();

            return advertChanges;
        }
    }
}
