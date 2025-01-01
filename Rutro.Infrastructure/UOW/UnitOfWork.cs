using Rutro.Application.Interfaces.Resume;
using Rutro.Application.UOW;
using Rutro.Infrastructure.Implementations.Resume;

namespace Rutro.Infrastructure.UOW_Implimentation;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        AcademicCredentials = new AcademicCredentialRepo(context);
        Contects = new ContectRepo(context);
        PersonalDetails = new PersonalDetailRepo(context);
        ProfessionalExperiences = new ProfessionalExperienceRepo(context);
        Skills = new SkillRepo(context);
        SocialMadias = new SocialMadiaRepo(context);
    }

    public IAcademicCredentialRepo AcademicCredentials { get; private set; }
    public IContectRepo Contects { get; private set; }
    public IPersonalDetailRepo PersonalDetails { get; private set; }
    public IProfessionalExperienceRepo ProfessionalExperiences { get; private set; }
    public ISkillRepo Skills { get; private set; }
    public ISocialMadiaRepo SocialMadias { get; private set; }
    public void Save()
    {
        _context.SaveChangesAsync();
    }

}