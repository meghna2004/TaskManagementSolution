using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskManagementSolution.Models;
using TaskManagementSolution.Models.DtoModels;
using TaskManagementSolution.Models.Enums;
using TaskManagementSolution.Services;

namespace TaskManagementSolution.Pages.BasicUser
{
    [Authorize]
    public class EditTaskModel : PageModel
    {
        private readonly IWebHostEnvironment environment;
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;

        [BindProperty]
        public TaskDto TaskDto { get; set; } = new TaskDto();
        public Tasks task { get; set; } = new Tasks();
        public string errorMessage = string.Empty;
        

        public EditTaskModel(IWebHostEnvironment environment, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            this.environment = environment;
            this.context = context;
            this.userManager = userManager;
        }
        public List<SelectListItem> statusreason { get; set; }

        public void OnGet(int? id)
        {
            var userId = userManager.GetUserId(User);
           
            statusreason = EnumHelper.GetSelectList<StatusReason>();

            if (id == null)
            {
                Response.Redirect("/BasicUser/ViewTask");
                return;
            }
            var edittask = context.Tasks.Find(id);
            if (edittask == null) 
            {
                Response.Redirect("/BasicUser/ViewTask");
                return;
            }
            TaskDto.Name = edittask.Name;
            TaskDto.Description = edittask.Description;
            TaskDto.DueDate = edittask.DueDate;
            TaskDto.Estimate = edittask.Estimate;
            TaskDto.StatusReason = edittask.StatusReason;
            TaskDto.OwnerID = edittask.OwnerID;
            task = edittask;
            if (TaskDto.OwnerID != userId)
            {
                Response.Redirect("/Error");
                return;
            }
        }
        public void OnPost(int? id)
        {
            if (id == null)
            {
                Response.Redirect("/BasicUser/ViewTask");
                return;
            }
            if (!ModelState.IsValid)
            {
                errorMessage = "Please provide all the details";
                return;
            }
            var editedtask = context.Tasks.Find(id);
            if (editedtask == null)
            {
                Response.Redirect("/BasicUser/ViewTask");
                return;
            }
            editedtask.Name = TaskDto.Name;
            editedtask.Description=TaskDto.Description; 
            editedtask.DueDate = TaskDto.DueDate;
            editedtask.Estimate = TaskDto.Estimate;
            editedtask.StatusReason = TaskDto.StatusReason;
            task = editedtask;
            context.SaveChanges();

            Response.Redirect("/BasicUser/ViewTask");

        }

    }
}
