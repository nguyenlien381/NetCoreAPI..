using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;
    public class DaiLy
    {
        public string MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string Diachi { get; set; }
        public string  NguoiDaiDien { get; set; }
        public string DienThoai { get; set; }   
        public string MaHTPP { get; set; }  
    }