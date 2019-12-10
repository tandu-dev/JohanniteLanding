using JohanniteLanding.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JohanniteLanding.Data.Configurations
{
    public class LinkConfiguration : IEntityTypeConfiguration<Link>
    {
        public void Configure (EntityTypeBuilder<Link> builder)
        {
            
        }
    }
}