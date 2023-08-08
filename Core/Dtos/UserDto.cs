namespace LibraryManagementSystem.Core.Dtos
{
    public class UserDto : BaseDto
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public int RoleId { get; set; }
        public string? ProfilePhotoPath { get; set; }


    }
}
