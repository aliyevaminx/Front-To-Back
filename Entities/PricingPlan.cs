namespace Front_To_Back_Project.Entities;

public class PricingPlan : BaseEntity
{
    public string PlanName { get; set; }
    public double Price { get; set; }
    public string Users { get; set; }
    public string Space { get; set; }
    public string Sources { get; set; }
    public string Support { get; set; }
    public string? AdditionalFeature { get; set; }
}
