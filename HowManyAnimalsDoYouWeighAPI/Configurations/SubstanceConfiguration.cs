using HowManyAnimalsDoYouWeighAPI.Items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HowManyAnimalsDoYouWeighAPI.Configurations
{
    public class SubstanceConfiguration: IEntityTypeConfiguration<Substance>
    {
        public void Configure(EntityTypeBuilder<Substance> builder)
        {
            builder
                .HasKey(a => a.Id);
        }
    }
}