using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TaskManagementSolution.Pages
{
    [Authorize(Roles ="teammanager")]
    public class ManagerModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
