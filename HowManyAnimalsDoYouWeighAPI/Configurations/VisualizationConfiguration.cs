using HowManyAnimalsDoYouWeighAPI.Visualizations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HowManyAnimalsDoYouWeighAPI.Configurations
{
    public class VisualizationConfiguration : IEntityTypeConfiguration<Visualization>
    {
        public void Configure(EntityTypeBuilder<Visualization> builder)
        {
            builder
                .HasKey(a => a.Id);
        }
    }
}