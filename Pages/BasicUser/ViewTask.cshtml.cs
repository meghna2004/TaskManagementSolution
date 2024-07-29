using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskManagementSolution.Models;
using TaskManagementSolution.Services;

namespace TaskManagementSolution.Pages.BasicUser
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;

        public List<Tasks> tasks { get; set; } = new List<Tasks>();
        public IndexModel(ApplicationDbContext context,UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }
        public void OnGet(int? id)
        {
            var ownerId = userManager.GetUserId(User);
            tasks =   context.Tasks.Where(t =>t.OwnerID==ownerId).ToList();
        }
    }
}
