using Microsoft.AspNetCore.Mvc.Rendering;

namespace TaskManagementSolution.Models.Enums
{
    public class EnumHelper
    {
        public static List<SelectListItem> GetSelectList<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                       .Cast<T>()
                       .Select(e => new SelectListItem
                       {
                           Value = e.ToString(),
                           Text = e.ToString()
                       })
                       .ToList();
        }
    }
}
