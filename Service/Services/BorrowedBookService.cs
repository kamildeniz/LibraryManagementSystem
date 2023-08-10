using AutoMapper;
using LibraryManagementSystem.Core.Dtos;
using LibraryManagementSystem.Core.Repositories;
using LibraryManagementSystem.Core.Services;
using LibraryManagementSystem.Core.UnitOfWorks;
using LibraryManagementSystem.Entity;
using LibraryManagementSystem.Repository.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Service.Services
{
    public class BorrowedBookService : Service<BorrowedBook>, IBorrowedBookService
    {
        private readonly IBorrowedRepository _borrowedBookRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public BorrowedBookService(IUnitOfWork unitOfWork, IMapper mapper, IBorrowedRepository borrowedBookRepository) : base(unitOfWork, borrowedBookRepository)
        {
            _mapper = mapper;
            _borrowedBookRepository = borrowedBookRepository;
            _unitOfWork = unitOfWork;
        }


        public async Task UpdateAsync(BorrowedBook entity)
        {
            _borrowedBookRepository.Update(entity);
            await _unitOfWork.CommitAsync();
        }
        public async Task<CustomResponseDto<List<BorrowedBookByUserDto>>> GetBorrowedBooksByUser()
        {
            var borrowedBooks = await _borrowedBookRepository.GetBorrowedBooksByUser();
            var borrowedBooksDto = _mapper.Map<List<BorrowedBookByUserDto>>(borrowedBooks);
            return CustomResponseDto<List<BorrowedBookByUserDto>>.Success(200, borrowedBooksDto);
        }

        public async Task<CustomResponseDto<List<BorrowedBookByBookDto>>> GeBorrowedtBooksByBook()
        {
            var borrowedBooks = await _borrowedBookRepository.GetBorrowedBooksByBook();
            var borrowedBooksDto = _mapper.Map<List<BorrowedBookByBookDto>>(borrowedBooks);
            return CustomResponseDto<List<BorrowedBookByBookDto>>.Success(200, borrowedBooksDto);
        }


    }
}
