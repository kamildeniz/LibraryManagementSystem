using AutoMapper;
using Entity;
using LibraryManagementSystem.Core.Dtos;
using LibraryManagementSystem.Core.Services;
using LibraryManagementSystem.Entity;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Api.Controllers
{
    public class BorrowedBookController : CustomBaseController
    {
        private readonly IService<BorrowedBook> _service;
        private readonly IMapper _mapper;

        public BorrowedBookController(IService<BorrowedBook> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
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
            {
                return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404, "bu id'ye sahip kitap bulunamadı."));
            }
            await _service.DeleteAsync(borrowedBook);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
