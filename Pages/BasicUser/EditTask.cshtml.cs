using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskManagementSolution.Models;
using TaskManagementSolution.Models.DtoModels;
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
        public void OnGet(int? id)
        {
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
    }
}
