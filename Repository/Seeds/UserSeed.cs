using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Repository.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1, Name = "Kamil", Password = "12345", RoleId = 2, ProfilePhotoPath = "C:\\Users\\Kamil\\Desktop\\Ekran görüntüsü 2023-07-25 222215.png" },
                new User { Id = 2, Name = "Yusuf", Password = "123456", RoleId = 1, ProfilePhotoPath = "C:\\Users\\Kamil\\Desktop\\Ekran görüntüsü 2023-07-25 222215.png" }
            );
        }
    }
}
