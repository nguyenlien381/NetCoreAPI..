using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;
    public class Persion
    {
        public string PersionId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
