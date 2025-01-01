using Rutro.Application.Interfaces.Resume;

namespace Rutro.Application.UOW;

public interface IUnitOfWork
{
    IAcademicCredentialRepo AcademicCredentials { get; }
    IContectRepo Contects { get; }
    IPersonalDetailRepo PersonalDetails { get; }
    IProfessionalExperienceRepo ProfessionalExperiences { get; }
    ISkillRepo Skills { get; }
    ISocialMadiaRepo SocialMadias { get; }
    void Save();
}
