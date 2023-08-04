
using LibraryManagementSystem.Entity;
using Microsoft.EntityFrameworkCore;


namespace LibraryManagementSystem.Repository.Seeds
{
    public class BookSeed : IEntityTypeConfiguration<Book>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                // Fyodor Dostoyevski
                new Book { Id = 1, Name = "Suç ve Ceza", Stock = 3, AuthorId = 1, CategoryId = 1, Description = "Suç ve Ceza, Rus yazar Fyodor Dostoyevski tarafından yazılan psikolojik ve dram türündeki romandır. İlk olarak 1866 yılı boyunca Rus Habercisi adlı edebiyat dergisinde on iki ayda yayımlandı. Daha sonra ise tek cilt olarak yayımlandı." });
        }
    }
}
