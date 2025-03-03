using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Pages.Shared.Models;

namespace WebApplication2.Pages.Shared;

public class Results : PageModel
{
    public List<FormData> FormDataList { get; set; } = new List<FormData>();

    public void OnGet()
    {
        FormDataList = IndexModel.FormDataList;
    }
}