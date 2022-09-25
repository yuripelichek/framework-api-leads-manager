using Microsoft.EntityFrameworkCore;
using Framework.LeadsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Framework.LeadsManager.Infrastructure.Data.Context
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder) 
        {         
            builder.HasKey(x => x.ClientId);
        }
    }
}