namespace SV21T1020178.DomainModels
{
    public class Customer
    {
        /// <summary>
        /// Thông tin về khách hàng 
        /// </summary>
        public int CustomerID { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string ContactName { get; set; } = string.Empty ;

        public string Province { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone {  get; set; } = string.Empty;
        public string Email {  get; set; } = string.Empty;
        public bool IsLocked { get; set; }
    }
}
