
namespace Domain.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public int NmPages { get; set; }
        public string Genre { get; set; }
    }
}
