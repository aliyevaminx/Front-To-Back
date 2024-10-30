namespace Front_To_Back_Project.Entities;

public class TeamMember : BaseEntity
{
    public string PhotoPath { get; set; }
    public string Name { get; set; }
    public string? Surname { get; set; }
    public string Position { get; set; }
}
