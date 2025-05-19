using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TimeBasedGreeting.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; } = "";

        [BindProperty]
        public string Password { get; set; } = "";

        public string Message { get; set; } = "";

        public void OnPost()
        {
            if (Username == "admin" && Password == "password")
            {
                Message = $"Welcome, {Username}!";
            }
            else
            {
                Message = "Invalid username or password.";
            }
        }
    }
}