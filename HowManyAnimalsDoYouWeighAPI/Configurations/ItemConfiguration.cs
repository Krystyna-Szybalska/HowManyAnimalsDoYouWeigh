using HowManyAnimalsDoYouWeighAPI.ItemFunFacts;
using HowManyAnimalsDoYouWeighAPI.Items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HowManyAnimalsDoYouWeighAPI.Configurations
{
    public class ItemConfiguration: IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder
                .HasKey(i => i.Id);
            builder
                .HasMany<ItemFunFact>(a => a.RandomFacts)
                .WithOne()
                .HasForeignKey(a => a.ItemId);
        }
    }
}