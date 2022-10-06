using front_to_back.DAL;
using front_to_back.ViewModels.Contact;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace front_to_back.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ContactController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var contractIntroComponent = await _appDbContext.ContractIntroComponent.FirstOrDefaultAsync();

            var contactFormComponent = await _appDbContext.ContactFormComponent.FirstOrDefaultAsync();
            var contactNumberComponent = await _appDbContext.ContactNumberComponent.ToListAsync();

            var model = new ContactIndexViewModel
            {
                ContractIntroComponent = contractIntroComponent,
                ContactFormComponent = contactFormComponent,
                ContactNumberComponent = contactNumberComponent
            };

            return View(model);
        }
    }
}
