using System;
using System.Collections;
using System.Collections.Generic;

namespace DataAccessLayer.BannerDataAccess
{
    public class Banner
    {
        private string _id { get; set; }
        private string _html { get; set; }
        private DateTime _created { get; set; }
        private DateTime? _modified { get; set; }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Html
        {
            get { return _html; }
            set { _html = value; }
        }
        public DateTime createdOn
        {
            get { return _created; }
            set { _created = value; }
        }
        public DateTime? ModifiedOn
        {
            get { return _modified; }
            set { _modified = value; }
        }

        public ICollection<Banner> GetAllBannerItems { get; set; }
    }
}