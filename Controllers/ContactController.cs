using Front_To_Back_Project.Data;
using Front_To_Back_Project.Models.Contact;
using Microsoft.AspNetCore.Mvc;

namespace Front_To_Back_Project.Controllers;

public class ContactController : Controller
{

    private readonly AppDbContext _context;

    public ContactController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var contactInfos = _context.ContactInfos.ToList();

        var contactInfoList = new List<ContactInfoVM>();
        foreach (var contactInfo in contactInfos)
        {
            var contactInfoVM = new ContactInfoVM
            {
                ContactType = contactInfo.ContactType,
                Name = contactInfo.Name,
                Surname = contactInfo.Surname,
                PhoneNumber = contactInfo.PhoneNumber
            };

            contactInfoList.Add(contactInfoVM);
        }

        var model = new ContactIndexVM { ContactInfos = contactInfoList };

        return View(model); 
    }
}
