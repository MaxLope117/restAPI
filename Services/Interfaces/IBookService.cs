using restAPI.Models;

namespace restAPI.Services.Interfaces
{
  public interface IBookService
  {
    Task<Book> CrearLibro(BookRequest request);
  }
}