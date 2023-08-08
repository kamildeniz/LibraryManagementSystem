using AutoMapper;
using Entity;
using LibraryManagementSystem.Core.Dtos;
using LibraryManagementSystem.Core.Services;
using LibraryManagementSystem.Entity;
using LibraryManagementSystem.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Api.Controllers
{
    public class UserController : CustomBaseController
    {
        private readonly IService<User> _service;
   private readonly IMapper _mapper;
        public UserController(IService<User> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
      public async Task<IActionResult> All()
        {
            var users = await _service.GetAllAsync();
            var usersDtos = _mapper.Map<List<UserDto>>(users.ToList());
            return CreateActionResult(CustomResponseDto<List<UserDto>>.Success(200, usersDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _service.GetByIdAsync(id);
            var userDto = _mapper.Map<UserDto>(user);
            return CreateActionResult(CustomResponseDto<UserDto>.Success(200, userDto)); ;
        }
        [HttpPost]
        public async Task<IActionResult> Save(UserDto userDto)
        {
            var user = await _service.AddAsync(_mapper.Map<User>(userDto));
            var usersDto = _mapper.Map<UserDto>(user);
            return CreateActionResult(CustomResponseDto<UserDto>.Success(201, usersDto));
        }
        [HttpPut]
        public async Task<IActionResult> Update(UserDto userDto)
        {
            await _service.UpdateAsync(_mapper.Map<User>(userDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var user = await _service.GetByIdAsync(id);
            if (user == null)
            {
                return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404, "bu id'ye sahip kitap bulunamadı."));
            }
            await _service.DeleteAsync(user);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
