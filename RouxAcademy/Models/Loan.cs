using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RouxAcademy.Models
{
  public class Loan
  {

    [Required]
    [DisplayFormat(DataFormatString = "{0:C}")]
    public decimal Amount { get; set; }

    [Required]
    [DisplayFormat(DataFormatString = "{0:P}")]
    public decimal Rate { get; set; }

    [Required]
    public int LengthInMonths { get; set; }

    public decimal MonthlyPayment
    {
      get
      {
        decimal payment = 0;

    

        var calculatedRate = Rate / 100 / 12;
        decimal denominator = (decimal)Math.Pow((1.0 + (double)calculatedRate), LengthInMonths) - 1;
        payment = (calculatedRate + (calculatedRate / denominator)) * Amount;

        return Math.Round(payment, 2);
      }
    }
  }
}