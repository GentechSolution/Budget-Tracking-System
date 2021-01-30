using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RegistrationAndLogin.Models
{
    public class MonthlyExpenses
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Gross Income is required")]
        public string Gross_Income { get; set; }

        public string Monthly_Tax { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Utilities is required")]
        public string Utilities { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Travel Cost is required")]
        public string Travel_Cost { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone Bill is required")]
        public string Phone_Bill { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Other Expenses is required")]
        public string Other_Expenses { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Net Income is required")]
        public string Net_Income { get; set; }
    }
}