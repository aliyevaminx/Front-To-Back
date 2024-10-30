using Front_To_Back_Project.Data;
using Front_To_Back_Project.Models.About;
using Microsoft.AspNetCore.Mvc;

namespace Front_To_Back_Project.Controllers;

public class AboutController : Controller
{
    private readonly AppDbContext _context;

    public AboutController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {

        var teamMembers = _context.TeamMembers.ToList();

        var teamMemberList = new List<TeamMemberVM>();
        foreach (var teamMember in teamMemberList)
        {
            var teamMemberVM = new TeamMemberVM
            {
                Name = teamMember.Name,
                Surname = teamMember.Surname,
                PhotoPath = teamMember.PhotoPath,
                Position = teamMember.Position
            };

            teamMemberList.Add(teamMemberVM);
        }


        var aims = _context.Aims.ToList();

        var aimList = new List<AimVM>();
        foreach (var aim in aims) 
        {
            var aimVM = new AimVM
            {
                Title = aim.Title,
                Description = aim.Description
            };

            aimList.Add(aimVM);
        }

        var model = new AboutIndexVM
        {
            TeamMembers = teamMemberList,
            Aims = aimList
        };

        return View(model);
    }
}
