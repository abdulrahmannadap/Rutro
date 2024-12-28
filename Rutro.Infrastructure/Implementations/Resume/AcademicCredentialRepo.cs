using Rutro.Application.Interfaces.Resume;
using Rutro.Domain.Entity;
using Rutro.Infrastructure.Implementation;

namespace Rutro.Infrastructure.Implementations.Resume;

public class AcademicCredentialRepo : Repository<AcademicCredential>, IAcademicCredentialRepo
{
    public AcademicCredentialRepo(ApplicationDbContext context) : base(context)
    {
    }
}
