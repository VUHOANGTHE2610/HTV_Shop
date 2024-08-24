using SV21T1020178.DomainModels;

namespace SV21T1020178.Web.Models
{
    /// <summary>
    /// Lớp cơ sở cho kết quả tìm kiếm, hiển thị dữ liệu dưới dạng phân trang
    /// </summary>
    public class PaginationSearchResult
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; }
        public string SearchValue { get; set; } = "";
        public int RowCount { get; set; } = 0;
        public int PageCount
        {
            get
            {
                if (PageSize <= 0)
                    return 1;

                int n = RowCount / PageSize;
                if (RowCount % PageSize > 0)
                {
                    n++;
                }
                return n;
            }
        }

    }
    /// <summary>
    /// Kết quả tìm kiếm khách hàng
    /// </summary>
    public class CustomerSearchResult : PaginationSearchResult
    {
        public required List<Customer> Data { get; set; }
    }

    public class EmployeeSearchResult : PaginationSearchResult
    {
        public List<Employee> Data { get; set; }
    }

    public class ProductSearchResult : PaginationSearchResult
    {
        public int CategoryId { get; set; } = 0;
        public int SupplierId { get; set; } = 0;
        public decimal MinPrice { get; set; } = 0;
        public decimal MaxPrice { get; set; } = 0;
        public required List<Product> Data { get; set; }
    }
    public class CategorySearchResult : PaginationSearchResult
    {
        public List<Category> Data { get; set; }

    }
}
