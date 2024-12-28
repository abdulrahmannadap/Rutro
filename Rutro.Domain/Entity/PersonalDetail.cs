namespace Rutro.Domain.Entity;

public class PersonalDetail
{
    public int PerId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string FatherName { get; set; } = string.Empty;
    public DateOnly? DateofBirth { get; set; }
    public string PlaceofBirth { get; set; } = string.Empty;
}
