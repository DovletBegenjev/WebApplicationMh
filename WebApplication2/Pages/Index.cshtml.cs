using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Pages.Shared.Models;

namespace WebApplication2.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public FormData FormData { get; set; }

    public static List<FormData> FormDataList { get; set; } = new List<FormData>();

    public void OnGet() { }

    public IActionResult OnPost()
    {
        Console.WriteLine("OnPost method triggered"); // Debug log

        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
            foreach (var error in errors)
            {
                Console.WriteLine(error);
            }
            Console.WriteLine("Model state is invalid");
            return Page();
        }

        FormDataList.Add(FormData);
        Console.WriteLine("Data added successfully");
        return RedirectToPage("Results");
    }
}