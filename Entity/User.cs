namespace Entity
{
    public class User : BaseEntity
    {
        public string? Password { get; set; }
        public int RoleId { get; set; }
        public string ProfilePhotoPath { get; set; }
    }
}
