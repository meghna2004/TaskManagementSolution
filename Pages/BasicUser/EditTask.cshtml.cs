using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskManagementSolution.Models;
using TaskManagementSolution.Models.DtoModels;
using TaskManagementSolution.Models.Enums;
using TaskManagementSolution.Services;

namespace TaskManagementSolution.Pages.BasicUser
{
    public class EditTaskModel : PageModel
    {
        private readonly IWebHostEnvironment environment;
        private readonly ApplicationDbContext context;
        [BindProperty]
        public TaskDto taskdto { get; set; } = new TaskDto();
        public Tasks task { get; set; } = new Tasks();
        public string errorMessage = string.Empty;
        public string successMessage = string.Empty;

        public EditTaskModel(IWebHostEnvironment environment, ApplicationDbContext context)
        {
            this.environment = environment;
            this.context = context;
        }
        public List<SelectListItem> StatusChoice { get; set; }

        public void OnGet(int? id)
        {
            StatusChoice = EnumHelper.GetSelectList<StatusReason>();

            if (id == null)
            {
                Response.Redirect("/BasicUser/ViewTask");
                return;
            }
            var taskinfo = context.Tasks.Find(id);
            if (taskinfo == null) 
            {
                Response.Redirect("/BasicUser/ViewTask");
                return;
            }
            taskdto.Name = taskinfo.Name;
            taskdto.Description = taskinfo.Description;
            taskdto.DueDate = taskinfo.DueDate;
            taskdto.Estimate = taskinfo.Estimate;
            taskdto.StatusReason = taskinfo.StatusReason;
            task = taskinfo;

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
                errorMessage = "Please provide the required fields";
                return;
            }
            var editedtask = context.Tasks.Find(id);
            if(editedtask == null)
            {
                Response.Redirect("/BasicUser/ViewTask");
                return;
            }
            editedtask.Name = taskdto.Name;
            editedtask.Description = taskdto.Description;
            editedtask.DueDate = taskdto.DueDate;
            editedtask.Estimate = taskdto.Estimate;
            editedtask.StatusReason = taskdto.StatusReason;
            context.SaveChanges();
            task= editedtask;
            successMessage = "Task Edited Successfully";
            Response.Redirect("/BasicUser/ViewTask");

        }
    }
}
