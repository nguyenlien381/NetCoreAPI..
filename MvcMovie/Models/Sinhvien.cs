using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;
    public class Sinhvien
    {
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public int Tuoi { get; set; }
        public int Sodienthoai { get; set; }
    }
    