using AutoMapper;
using Entity;
using LibraryManagementSystem.Core.Dtos;
using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.Service.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AuthorDto, Author>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<BookDto, Book>().ReverseMap();
            CreateMap<RoleDto, Role>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();


        }
    }
}
