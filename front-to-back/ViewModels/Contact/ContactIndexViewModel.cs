using front_to_back.Models;

namespace front_to_back.ViewModels.Contact
{
    public class ContactIndexViewModel
    {
        public ContractIntroComponent ContractIntroComponent { get; set; }
        public ContactFormComponent ContactFormComponent { get; set; }

        public List<ContactNumberComponent> ContactNumberComponent { get; set; }
    }
}
