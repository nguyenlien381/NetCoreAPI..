using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;
    public class Employee 
    {
        public string Manhanvien { get; set; }
        public int Tuoi { get; set; }
        public string Tennhanvien { get; set; }
        public float Luong { get; set; }
    }