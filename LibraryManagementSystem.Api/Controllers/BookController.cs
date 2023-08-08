using AutoMapper;
using LibraryManagementSystem.Core.Dtos;
using LibraryManagementSystem.Core.Services;
using LibraryManagementSystem.Entity;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Api.Controllers
{
    public class BookController : CustomBaseController
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public BookController(IMapper mapper, IBookService bookService)
        {
            _mapper = mapper;
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var books = await _bookService.GetAllAsync();
            var booksDtos = _mapper.Map<List<BookDto>>(books.ToList());
            return CreateActionResult(CustomResponseDto<List<BookDto>>.Success(200, booksDtos));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var book = await _bookService.GetByIdAsync(id);
            var booksDto = _mapper.Map<BookDto>(book);
            return CreateActionResult(CustomResponseDto<BookDto>.Success(200, booksDto));
        }
        [HttpPost]
        public async Task<IActionResult> Save(BookDto bookDto)
        {
            var book = await _bookService.AddAsync(_mapper.Map<Book>(bookDto));
            var booksDto = _mapper.Map<BookDto>(book);
            return CreateActionResult(CustomResponseDto<BookDto>.Success(201, booksDto));
        }
        [HttpPut]
        public async Task<IActionResult> Update(BookDto bookDto)
        {
            await _bookService.UpdateAsync(_mapper.Map<Book>(bookDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var book = await _bookService.GetByIdAsync(id);
            if (book == null)
            {
                return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404, "bu id'ye sahip kitap bulunamadı."));
            }
            await _bookService.DeleteAsync(book);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetBooksByCategory()
        {
            return CreateActionResult(await _bookService.GetBooksByCategory());
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetBooksByAuthor()
        {
            return CreateActionResult(await _bookService.GetBooksByAuthor());
        }
    }
}
