using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TimeBasedGreeting_Razor_app.Pages;

public class IndexModel : PageModel
{
    public string? Greeting { get; set; }
    public string? CurrentTime { get; set; }

    public void OnGet()
    {
        var now = DateTime.Now;
        var hour = now.Hour;

        if (hour < 12)
        {
            Greeting = "Good Evening";
        }
        else if (hour < 18)
        {
            Greeting = "Good Afternoon";
        }
        else
        {
            Greeting = "Good Evening";
        }

        CurrentTime = now.ToString("hh mm tt");
    }
}
