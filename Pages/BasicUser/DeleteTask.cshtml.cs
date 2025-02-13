using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskManagementSolution.Services;

namespace TaskManagementSolution.Pages.BasicUser
{
    public class DeleteTaskModel : PageModel
    {
        private readonly IWebHostEnvironment environment;
        private readonly ApplicationDbContext context;

        public DeleteTaskModel(IWebHostEnvironment environment, ApplicationDbContext context)
        {
            this.environment = environment;
            this.context = context;
        }

        public void OnGet(int?id )
        {
            if (id == null)
            {
                Response.Redirect("/BasicUser/ViewTask");
                return;
            }
            var task = context.Tasks.Find(id);
            if( task==null)
            {
                Response.Redirect("/BasicUser/ViewTask");
                return;
            }
            context.Tasks.Remove(task);
            context.SaveChanges();
            Response.Redirect("/BasicUser/ViewTask");

        }

    }
}
