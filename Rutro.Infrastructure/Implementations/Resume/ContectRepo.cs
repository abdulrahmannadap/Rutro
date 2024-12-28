using Rutro.Application.Interfaces.Resume;
using Rutro.Domain.Entity;
using Rutro.Infrastructure.Implementation;

namespace Rutro.Infrastructure.Implementations.Resume;

public class ContectRepo : Repository<Contect>, IContectRepo
{
    public ContectRepo(ApplicationDbContext context) : base(context)
    {
    }
}
