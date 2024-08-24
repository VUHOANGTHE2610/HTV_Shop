using NuGet.Common;
using SV21T1020178.DomainModels;

namespace SV21T1020178.Web.Models
{
    public class OrderDetailModel
    {
        public Order Order { get; set; }
        public List<OrderDetail> Details { get; set; }

    }
}
