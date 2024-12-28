using Rutro.Application.Interfaces.Resume;
using Rutro.Domain.Entity;
using Rutro.Infrastructure.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutro.Infrastructure.Implementations.Resume;

public class PersonalDetailRepo : Repository<PersonalDetail>, IPersonalDetailRepo
{
    public PersonalDetailRepo(ApplicationDbContext context) : base(context)
    {
    }
}
