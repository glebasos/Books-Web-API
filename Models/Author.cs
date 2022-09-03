namespace Udemy.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //navi props
        public List<Book_Author> Book_Authors { get; set; }
    }
}
