using HowManyAnimalsDoYouWeighAPI.ItemFunFacts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HowManyAnimalsDoYouWeighAPI.Configurations
{
    public class ItemFunFactConfiguration : IEntityTypeConfiguration<ItemFunFact>
    {
        public void Configure(EntityTypeBuilder<ItemFunFact> builder)
        {
            builder
                .HasKey(i => i.Id);
        }
    }
}