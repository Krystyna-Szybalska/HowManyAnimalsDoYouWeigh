using HowManyAnimalsDoYouWeighAPI.FunFacts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HowManyAnimalsDoYouWeighAPI.Configurations
{
    public class AnimalFunFactConfiguration : IEntityTypeConfiguration<AnimalFunFact>
    {
        public void Configure(EntityTypeBuilder<AnimalFunFact> builder)
        {
            builder
                .HasKey(a => a.Id);
        }
    }
}