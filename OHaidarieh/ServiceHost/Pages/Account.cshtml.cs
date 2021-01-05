using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class AccountModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        private readonly IAccountApplication _accountApplication;
        public AccountModel(IAccountApplication accountApplication)
        {
            _accountApplication = accountApplication;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPostLogin(Login command)
        {
            var result = _accountApplication.Login(command);
            if (result.IsSuccedded)
                return RedirectToPage("/Index", new { area = "Admin" }); 
            Message = result.Message;
            return RedirectToPage("/Account");

        }
        public IActionResult OnGetLogout()
        {
            _accountApplication.Logout();
            return RedirectToPage("./Account");
        }
    }
}
