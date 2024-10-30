using Front_To_Back_Project.Data;
using Front_To_Back_Project.Models.Pricing;
using Microsoft.AspNetCore.Mvc;

namespace Front_To_Back_Project.Controllers;

public class PricingController : Controller
{
    private readonly AppDbContext _context;

    public PricingController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {

        var pricingPlans = _context.PricingPlans.ToList();

        var pricingPlanList = new List<PricingPlanVM>();
        foreach (var pricingPlan in pricingPlans)
        {
            var pricingPlanVM = new PricingPlanVM
            {
                PlanName = pricingPlan.PlanName,
                Price = pricingPlan.Price,
                Users = pricingPlan.Users,
                Space = pricingPlan.Space,
                Sources = pricingPlan.Sources,
                Support = pricingPlan.Support,
                AdditionalFeature = pricingPlan.AdditionalFeature
            };

            pricingPlanList.Add(pricingPlanVM);
        }

        var model = new PricingIndexVM
        {
            PricingPlans = pricingPlanList
        };

        return View(model); 
    }
}
