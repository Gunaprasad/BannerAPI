using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;
using BusinessLayer.Model;

namespace WebApplication2.Controllers
{
    public class BannerController : ApiController
    {
        private readonly BAL_Banner objBanner = new BAL_Banner();

        [HttpGet]
        public IEnumerable<BannerModel> GetAllBanner()
        {
            var bannerresponse = objBanner.GetAll();
            if (bannerresponse == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return objBanner.GetAll();
        }

        [HttpGet]
        public HttpResponseMessage GetBanner(string bannerId)
        {
            BannerModel banner = objBanner.Get(bannerId);
            if (banner == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(banner);
        }

        [HttpPost]
        public HttpResponseMessage PostBanner(BannerModel banner)
        {
            bool customer = objBanner.Add(banner);
            var response = Request.CreateResponse
                    <BannerModel>(HttpStatusCode.Created, banner);

            string uri = Url.Link("DefaultApi",
                            new { customerID = banner.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        [HttpPut]
        public HttpStatusCode PutBanner(BannerModel banner)
        {
            if (!objBanner.Update(banner))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return HttpStatusCode.OK;
            }
        }

        [HttpDelete]
        public void DeleteBanner(string bannerID)
        {
            BannerModel banner = objBanner.Get(bannerID);
            if (banner == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            objBanner.Remove(bannerID);
        }

    }
}
