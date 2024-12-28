using Rutro.Application.Interfaces.Resume;
using Rutro.Domain.Entity;
using Rutro.Infrastructure.Implementation;

namespace Rutro.Infrastructure.Implementations.Resume;

public class ProfessionalExperienceRepo : Repository<ProfessionalExperience>, IProfessionalExperienceRepo
{
    public ProfessionalExperienceRepo(ApplicationDbContext context) : base(context)
    {
    }
}
