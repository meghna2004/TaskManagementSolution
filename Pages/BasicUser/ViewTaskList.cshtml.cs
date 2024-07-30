using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskManagementSolution.Models;
using TaskManagementSolution.Services;

namespace TaskManagementSolution.Pages.BasicUser
{
    [Authorize]
    public class ViewTaskListModel : PageModel
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        public List<TaskList> taskLists = new List<TaskList>();


        public ViewTaskListModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }
        public void OnGet()
        {
            var ownerid = userManager.GetUserId(User);
            taskLists=context.TaskList.Include(tl=>tl.tasks).Where(tl=> tl.OwnerID==ownerid).OrderByDescending(tl=>tl.DueDate).ToList();
        }
    }
}
