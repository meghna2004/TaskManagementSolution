using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskManagementSolution.Models.DtoModels;
using TaskManagementSolution.Models.Enums;
using TaskManagementSolution.Models;
using TaskManagementSolution.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace TaskManagementSolution.Pages.BasicUser
{
    [Authorize]
    public class EditTaskListModel : PageModel
    {
        private readonly IWebHostEnvironment environment;
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;

        [BindProperty]
        public TaskListDto tlDto { get; set; } = new TaskListDto();
        public TaskList tList { get; set; } = new TaskList();
        public string errorMessage = string.Empty;
        public EditTaskListModel(IWebHostEnvironment environment, ApplicationDbContext context,UserManager<ApplicationUser> userManager)
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
                Response.Redirect("/BasicUser/ViewTaskList");
                return;
            }
            var edittl = context.TaskList.Find(id);
            if (edittl == null)
            {
                Response.Redirect("/BasicUser/ViewTaskList");
                return;
            }
            tlDto.Name = edittl.Name;
            tlDto.Description = edittl.Description;
            tlDto.DueDate = edittl.DueDate;
            tlDto.Estimate = edittl.Estimate;
            tlDto.StatusReason = edittl.StatusReason;
            tlDto.OwnerID = edittl.OwnerID;
            tList = edittl;
            if (tlDto.OwnerID != userId)
            {
                Response.Redirect("/Error");
                return;
            }
        }
        public void OnPost(int? id)
        {
            if (id == null)
            {
                Response.Redirect("/BasicUser/ViewTaskList");
                return;
            }
            if (!ModelState.IsValid)
            {
                errorMessage = "Please provide all the details";
                return;
            }
            var editedtask = context.TaskList.Find(id);
            if (editedtask == null)
            {
                Response.Redirect("/BasicUser/ViewTaskList");
                return;
            }
            editedtask.Name = tlDto.Name;
            editedtask.Description = tlDto.Description;
            editedtask.DueDate = tlDto.DueDate;
            editedtask.Estimate = tlDto.Estimate;
            editedtask.StatusReason = tlDto.StatusReason;
            tList = editedtask;
            context.SaveChanges();

            Response.Redirect("/BasicUser/ViewTaskList");

        }
    }
}
