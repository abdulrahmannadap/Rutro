using Rutro.Application.Interfaces.Resume;
using Rutro.Domain.Entity;
using Rutro.Infrastructure.Implementation;

namespace Rutro.Infrastructure.Implementations.Resume;

public class SocialMadiaRepo : Repository<SocialMadia>, ISocialMadiaRepo
{
    public SocialMadiaRepo(ApplicationDbContext context) : base(context)
    {
    }
}
