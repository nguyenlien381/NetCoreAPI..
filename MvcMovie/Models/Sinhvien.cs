namespace MvcMovie.Models
{
    public class Sinhvien 
    {
        public Sinhvien(string fullName) 
        {
            this.FullName = fullName;
   
        }
                public string FullName { get; set; }
        public int Age { get; set; }
    }
}