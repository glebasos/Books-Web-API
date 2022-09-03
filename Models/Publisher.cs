namespace Udemy.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //navigation props
        public List<Book> Books { get; set; }
    }
}
