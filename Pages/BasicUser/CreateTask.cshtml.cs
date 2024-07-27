using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TaskManagementSolution.Models;
using TaskManagementSolution.Models.DtoModels;
using TaskManagementSolution.Services;

namespace TaskManagementSolution.Pages.BasicUser
{
    public class CreateTaskModel : PageModel
    {
        private readonly IWebHostEnvironment environment;
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;


        [BindProperty]
        public TaskDto taskdto { get; set; } = new TaskDto();
        public CreateTaskModel(IWebHostEnvironment environment,ApplicationDbContext context,UserManager<ApplicationUser> userManager)
        {
            this.environment = environment;
            this.context = context;
            this.userManager = userManager;
        }
        public void OnGet()
        {
        }
        public string errorMessage = string.Empty;
        public void OnPost() 
        {
            if(taskdto.Name == null)
            {
                ModelState.AddModelError("taskdto.Name", "Name is required");
            }
            if (!ModelState.IsValid) 
            {
                errorMessage = "Please provide the required fields";
                return;
            }
            var userId = userManager.GetUserId(User); // Get the current user's ID

            Tasks task = new Tasks()
            {
                Name = taskdto.Name,
                Description = taskdto.Description,
                Estimate = taskdto.Estimate,
                DueDate = taskdto.DueDate,
                OwnerID = userId,
                StatusReason= Models.Enums.StatusReason.Draft,
            };
            context.Tasks.Add(task);
            context.SaveChanges();
            taskdto.Name = "";
            taskdto.Description = "";
            taskdto.DueDate = DateOnly.FromDateTime(DateTime.Now);
            taskdto.Estimate = 0;
            ModelState.Clear();
            Response.Redirect("/BasicUser/ViewTask");
        }
    }
}
