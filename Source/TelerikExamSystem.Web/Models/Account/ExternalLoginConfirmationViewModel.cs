﻿namespace TelerikExamSystem.Web.Models.Account
{
    using System.ComponentModel.DataAnnotations;
    
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}