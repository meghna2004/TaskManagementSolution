using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskManagementSolution.Models;
using TaskManagementSolution.Models.DtoModels;
using TaskManagementSolution.Services;

namespace TaskManagementSolution.Pages.BasicUser
{
    public class CreateTaskListModel : PageModel
    {
        private readonly IWebHostEnvironment environment;
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        [BindProperty]
        public TaskListDto tasklistdto {  get; set; }= new TaskListDto();
        public CreateTaskListModel(IWebHostEnvironment environment, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            this.environment = environment;
            this.context = context;
            this.userManager = userManager;
        }
        public string errorMessage = string.Empty;

        public void OnGet()
        {
        }
        public void OnPost() 
        {
            if (tasklistdto.Name == null)
            {
                ModelState.AddModelError("taskdto.Name", "Name is required");
            }
            if (!ModelState.IsValid)
            {
                errorMessage = "Please provide the required fields";
                return;
            }
            var userId = userManager.GetUserId(User); // Get the current user's ID
            TaskList tasklist = new TaskList 
            {
                Name = tasklistdto.Name,
                Description = tasklistdto.Description,
                Estimate = tasklistdto.Estimate,
                DueDate = tasklistdto.DueDate,
                OwnerID = userId,
                StatusReason = Models.Enums.StatusReason.Draft,
            };
            context.TaskList.Add(tasklist);
            context.SaveChanges();
            tasklistdto.Name = "";
            tasklistdto.Description = "";
            tasklistdto.DueDate = DateOnly.FromDateTime(DateTime.Now);
            tasklistdto.Estimate = 0;
            ModelState.Clear();
            Response.Redirect("/BasicUser/ViewTaskList");
        }
        
    }
}
