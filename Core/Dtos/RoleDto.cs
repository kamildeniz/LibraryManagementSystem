using Entity;

namespace LibraryManagementSystem.Core.Dtos
{
    public class RoleDto : BaseDto
    {
        public string? Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
