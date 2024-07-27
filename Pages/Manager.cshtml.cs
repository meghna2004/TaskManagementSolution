using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TaskManagementSolution.Pages
{
    [Authorize(Roles ="teammanager,admin")]
    public class ManagerModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
