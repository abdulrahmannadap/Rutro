namespace Rutro.Domain.Entity;

public class AcademicCredential
{
    public int AcdId { get; set; }
    public string AcdType { get; set; } = string.Empty; //DropDown School College University
    public DateTime? AcdStartingYear { get; set; }
    public DateTime? AcdEndYear { get; set; }
    public int AcdPercentage { get; set; }
    public string AcdAddress { get; set; } = string.Empty;
}
