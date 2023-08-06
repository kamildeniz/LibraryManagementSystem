using LibraryManagementSystem.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Repository.Configurations
{
    public class BorrowedBookConfiguration : IEntityTypeConfiguration<BorrowedBook>
    {
        public void Configure(EntityTypeBuilder<BorrowedBook> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.GivingBack).IsRequired();
            builder.Property(x => x.Deadline).IsRequired();
            builder.HasOne(bb => bb.User)
                 .WithMany(u => u.BorrowedBooks)
                 .HasForeignKey(bb => bb.UserId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(bb => bb.Book)
                   .WithMany(b => b.BorrowedBooks)
                   .HasForeignKey(bb => bb.BookId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
