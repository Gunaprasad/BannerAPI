using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.BannerDataAccess
{

    public class BannerDataAccess : IBannerDataAccess, IDisposable
    {
        private BannerContext objcontext;
        private IEnumerable<Banner> bannerlist;

        public BannerDataAccess()
        {
            objcontext = new BannerContext();
        }

        Banner IBannerDataAccess.Add(Banner item)
        {
            Banner objBanner = new Banner();
            objBanner.Id = item.Id;
            objBanner.Html = item.Html;
            objBanner.createdOn = Convert.ToDateTime(item.createdOn.ToString("yyyy-mm-dd"));
            objBanner.ModifiedOn = Convert.ToDateTime(item.ModifiedOn.HasValue ? item.ModifiedOn.Value.ToString("yyyy-mm-dd") : null);
            objcontext.BannerItems.Add(objBanner);
            objcontext.Add(objBanner);
            return objBanner;
        }

        Banner IBannerDataAccess.Get(string bannerId)
        {
            Banner objbanner = objcontext.BannerItems.Where(x => x.Id == bannerId).First();
            return objbanner;
        }

        IEnumerable<Banner> IBannerDataAccess.GetAll()
        {
            bannerlist = objcontext.BannerItems.ToList();
            return bannerlist;
        }

        void IBannerDataAccess.Remove(string customerID)
        {
            Banner objbanner = objcontext.BannerItems.Where(x => x.Id == customerID).First();
            objcontext.BannerItems.Remove(objbanner);
        }

        bool IBannerDataAccess.Update(Banner item)
        {
            bool success = false;
            Banner objbanner = objcontext.BannerItems.Find(item);
            if (objbanner != null)
            {
                objcontext.BannerItems.Update(item);
                success = true;
            }
            return success;
        }

        public void Dispose()
        {
            objcontext.Dispose();
        }
    }

}
