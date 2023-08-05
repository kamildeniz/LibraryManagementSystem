using LibraryManagementSystem.Entity;

namespace Entity
{
    public class User : BaseEntity
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public int RoleId { get; set; }
        public string ProfilePhotoPath { get; set; }
        public Role Role { get; set; }
    }
}
