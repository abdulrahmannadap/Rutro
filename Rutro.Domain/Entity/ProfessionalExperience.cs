namespace Rutro.Domain.Entity;

public class ProfessionalExperience
{
    public int ProexId { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public string Designation { get; set; } = string.Empty;
    public string Duration { get; set; } = string.Empty;
    public string Project { get; set; } = string.Empty;
    public string Technologies { get; set; } = string.Empty;
    public string ProjectDescription { get; set; } = string.Empty;
    public string ProjectResponsibilities { get; set; } = string.Empty;
}
