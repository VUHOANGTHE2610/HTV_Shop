using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV21T1020178.DataLayers
{
    /// <summary>
    /// định nghĩa dữ liệu chung
    /// (T:generic)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICommonDAL<T> where T : class
    {
        /// <summary>
        /// tìm kiếm và lấy danh sach dưới dạng phân trang 
        /// </summary>
        /// <param name="page"> trang cần hiển thị</param>
        /// <param name="pageSize">số dòng hiến thị trên mỗi trang(bằng 0 nếu không phân trang)</param>
        /// <param name="searchValue">Giá trị tìm kiếm (chuổi Rỗng nếu không tìm kiếm)</param>
        /// <returns></returns>
        List<T> List(int page = 1, int pageSize = 0, string searchValue = "");
        /// <summary>
        /// Đếm số dòng dữ liệu tìm kiếm được 
        /// </summary>
        /// <param name="searchValue">Giá trị tìm kiếm (chuổi Rỗng nếu không tìm kiếm</param>
        /// <returns></returns>
        int Count(string searchValue = "");
        /// <summary>
        /// lấy một bản ghi dòng dữ liệu dựa trên mã id 
        /// </summary>
        /// <param name="id"> mã của dữ liệu cần lấy</param>
        /// <returns></returns>
        T? Get(int id);
        /// <summary>
        /// Bổ sung dữ liệu vào bảng, Hàm trả về Id của dữ liệu bổ Sung
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int Add(T data);
        /// <summary>
        /// Cập nhật dữ liệu
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Update (T data);
        /// <summary>
        /// kiểm tra xem 1 dòng dữ liệu dựa vào id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
        /// <summary>
        /// kiểm tra một dòng dữ liệu có mã là id hiện có dữ liệu liên quan 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool InUsed (int id);
    }
}
