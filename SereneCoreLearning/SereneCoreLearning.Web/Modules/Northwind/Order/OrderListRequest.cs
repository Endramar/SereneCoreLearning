using Serenity.Services;

namespace SereneCoreLearning.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}