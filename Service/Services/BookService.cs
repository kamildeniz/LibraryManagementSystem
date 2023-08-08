using AutoMapper;
using LibraryManagementSystem.Core.Dtos;
using LibraryManagementSystem.Core.Repositories;
using LibraryManagementSystem.Core.Services;
using LibraryManagementSystem.Core.UnitOfWorks;
using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.Service.Services
{
    public class BookService : Service<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IGenericRepository<Book> repository, IUnitOfWork unitOfWork, IMapper mapper, IBookRepository bookRepository) : base(unitOfWork,bookRepository)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }
        


        public async Task<CustomResponseDto<List<BookByCategoryDto>>> GetBooksByCategory()
        {
            var books = await _bookRepository.GetBooksByCategory();
            var booksDto = _mapper.Map<List<BookByCategoryDto>>(books);
            return CustomResponseDto<List<BookByCategoryDto>>.Success(200, booksDto);
        }

        public async Task<CustomResponseDto<List<BookByAuthorDto>>> GetBooksByAuthor()
        {
            var books = await _bookRepository.GetBooksByAuthor();
            var booksDto = _mapper.Map<List<BookByAuthorDto>>(books);
            return CustomResponseDto<List<BookByAuthorDto>>.Success(200, booksDto);
        }


    }
}
