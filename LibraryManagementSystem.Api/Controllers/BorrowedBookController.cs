using AutoMapper;
using Entity;
using LibraryManagementSystem.Core.Dtos;
using LibraryManagementSystem.Core.Services;
using LibraryManagementSystem.Entity;
using LibraryManagementSystem.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Api.Controllers
{
    public class BorrowedBookController : CustomBaseController
    {
        private readonly IBookService _bookService;
        private readonly IBorrowedBookService _service;
        private readonly IMapper _mapper;

        public BorrowedBookController(IBorrowedBookService service, IMapper mapper, IBookService bookService)
        {
            _service = service;
            _mapper = mapper;
            _bookService = bookService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var borrowedBooks = await _service.GetAllAsync();
            var borrowedBooksDto = _mapper.Map<List<BorrowedBookDto>>(borrowedBooks.ToList());
            return CreateActionResult(CustomResponseDto<List<BorrowedBookDto>>.Success(200, borrowedBooksDto));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var borrowedBook = await _service.GetByIdAsync(id);
            var borrowedBookDto = _mapper.Map<BorrowedBookDto>(borrowedBook);
            return CreateActionResult(CustomResponseDto<BorrowedBookDto>.Success(200, borrowedBookDto)); ;
        }
        [HttpPost]
        public async Task<IActionResult> Save(BorrowedBookDto borrowedBookDto)
        {
            var book = await _bookService.GetByIdAsync(borrowedBookDto.BookId); // Diyelim ki kitap servisi var ve GetByIdAsync metodu ile kitap alınabilir.
            if (book == null)
            {
                return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(400, "Kitap bulunamadı."));
            }

            if (book.Stock <1)
            {
                return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(400, "Kitap stokta yok."));
            }
            book.Stock--;
            var borrowedBook = await _service.AddAsync(_mapper.Map<BorrowedBook>(borrowedBookDto));
            var borrowedsBookDto = _mapper.Map<BorrowedBookDto>(borrowedBook);
            return CreateActionResult(CustomResponseDto<BorrowedBookDto>.Success(201, borrowedsBookDto));
        }


        [HttpPut]
        public async Task<IActionResult> Update(BorrowedBookDto borrowedBookDto)
        {
            await _service.UpdateAsync(_mapper.Map<BorrowedBook>(borrowedBookDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var borrowedBook = await _service.GetByIdAsync(id);
            if (borrowedBook == null)
                return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404, "Bu id'ye sahip ödünç alınmış kitap bulunamadı."));
            
            var book = await _bookService.GetByIdAsync(borrowedBook.BookId);

            if (book == null)
                return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404, "Bu id'ye sahip ödünç alınmış kitap bulunamadı."));
           

                book.Stock++;

            await _service.DeleteAsync(borrowedBook);
             //await _bookService.UpdateAsync(book);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetBorrowedBooksByUser()
        {
            return CreateActionResult(await _service.GetBorrowedBooksByUser());

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GeBorrowedtBooksByBook()
        {
            return CreateActionResult(await _service.GeBorrowedtBooksByBook());
        }
    }
}
