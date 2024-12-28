using Rutro.Application.Interfaces.Resume;
using Rutro.Domain.Entity;
using Rutro.Infrastructure.Implementation;

namespace Rutro.Infrastructure.Implementations.Resume;

public class SkillRepo : Repository<Skill>, ISkillRepo
{
    public SkillRepo(ApplicationDbContext context) : base(context)
    {
    }
}
