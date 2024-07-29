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
        public TaskDto TaskDto { get; set; } = new TaskDto();
        public Tasks task { get; set; } = new Tasks();
        public string errorMessage = string.Empty;
        

        public EditTaskModel(IWebHostEnvironment environment, ApplicationDbContext context)
        {
            this.environment = environment;
            this.context = context;
        }
        public List<SelectListItem> statusreason { get; set; }

        public void OnGet(int? id)
        {
            statusreason = EnumHelper.GetSelectList<StatusReason>();

            if (id == null)
            {
                Response.Redirect("/BasicUser/ViewTask");
                return;
            }
            var product = context.Tasks.Find(id);
            if (product == null) 
            {
                Response.Redirect("/BasicUser/ViewTask");
                return;
            }
            TaskDto.Name = product.Name;
            TaskDto.Description = product.Description;
            TaskDto.DueDate = product.DueDate;
            TaskDto.Estimate = product.Estimate;
            task = product;

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
            var product = context.Tasks.Find(id);
            if (product == null)
            {
                Response.Redirect("/BasicUser/ViewTask");
                return;
            }
            product.Name = TaskDto.Name;
            product.Description=TaskDto.Description; 
            product.DueDate = TaskDto.DueDate;
            product.Estimate = TaskDto.Estimate;
            product.StatusReason = TaskDto.StatusReason;
            task = product;
            context.SaveChanges();

            Response.Redirect("/BasicUser/ViewTask");

        }

    }
}
