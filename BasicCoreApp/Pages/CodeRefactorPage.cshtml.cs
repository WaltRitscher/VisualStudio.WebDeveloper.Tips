﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasicCoreApp.Pages
{
  public class CodeRefactorPageModel : PageModel
  {
    public void OnGet()
    {

    }
    private string customerName;
    private bool x;
    private bool y;
    private void RefactorHere()
    {
      // Visual Studio includes some analyzers, refactorings
      // Roslynator adds 500+ analyzers, refactorings

      // use string.empty
      string s = "";

      // use string.IsNullOrEmpty
      if (s == null || s.Length == 0)
      {
      }

    }

    private bool MoreRefactor()
    {
      // remove redundant parenthesis
      if ((x))
      {
        return (y);
      }
      return true;
    }


  }

  public enum TourType
  {
    Bike = 4,
    Walking = 2,
    Cruise = 1,

  }

  public enum Empty {
    None=0,
  }
}