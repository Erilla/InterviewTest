using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FundsLibrary.InterviewTest.Common
{
    public class SecurityFunds
    {
        [Display(Name = "Code")]
        public string IsinCode { get; set; }

        [Display(Name = "Name")]
        public string FullName { get; set; }
        
    }
}
