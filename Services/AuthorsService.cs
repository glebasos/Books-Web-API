using Udemy.Data;
using Udemy.Models;
using Udemy.ViewModels;

namespace Udemy.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                Name = author.Name
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }

        public AuthorWithBooksVM GetAuthorWithBooks(int authorid)
        {
            var _author = _context.Authors.Where(n => n.Id == authorid).Select(n => new AuthorWithBooksVM()
            {
                Name = n.Name,
                BookTitles = n.Book_Authors.Select(ba => ba.Book.Title).ToList()
            }).FirstOrDefault();
            return _author;
        }

        public List<Author> GetAllAuthors() => _context.Authors.ToList();

        public Author GetAuthorById(int authorId) => _context.Authors.FirstOrDefault(a => a.Id == authorId);

        //public Author UpdateAuthorById(int authorid, AuthorVM author)
        //{
        //    var _author = _context.Authors.FirstOrDefault(a => a.Id == authorid);
        //    if (_author != null)
        //    {
        //        _author.Name = author.Name;

        //        _context.SaveChanges();
        //    }
        //    return _author;
        //}

        //public void DeleteAuthorById(int id)
        //{
        //    var _author = _context.Authors.FirstOrDefault(a => a.Id == id);
        //    if (_author != null)
        //    {
        //        _context.Authors.Remove(_author);
        //        _context.SaveChanges();
        //    }
        //}
    }
}
