using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RouxAcademy.Pages
{
  public class StudentLoanModel : PageModel
  {
    public string Message { get; set; }


    [BindProperty]
    public Models.Loan StudentLoan { get; set; }

    public void OnGet()
    {
      StudentLoan =  new Models.Loan { Amount = 600, Rate = .12M, LengthInMonths = 24 };

      Message = "Your contact page.";
    }


  }
}
