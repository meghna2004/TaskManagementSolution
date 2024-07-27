using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskManagementSolution.Models;
using TaskManagementSolution.Services;

namespace TaskManagementSolution.Pages.BasicUser
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;
        public List<Tasks> tasks { get; set; } = new List<Tasks>();
        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            tasks = context.Tasks.OrderByDescending(t =>t.DueDate).ToList();
        }
    }
}
