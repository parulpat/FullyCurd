using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullCRUD.Models
{
    public class CrudModel
    {
        public int ID { get; set; }
        public string WebsiteName { get; set; }
        public int HostingRenewalPrice { get; set; }
        public DateTime HostingRenwalDate { get; set; }
        public int DomainRenewalPrice { get; set; }
        public DateTime DomainRenewalDate { get; set; }
        public int AMCRenewalPrice { get; set; }
        public DateTime AMCRenewalDate { get; set; }
        public int SEORenewalPrice { get; set; }
        public DateTime SEORenewalDate { get; set; }
        public string PaymentMode { get; set; }
        public string Remark { get; set; }
    }
}
