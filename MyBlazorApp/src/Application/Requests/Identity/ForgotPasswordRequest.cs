﻿using System.ComponentModel.DataAnnotations;

namespace MyBlazorApp.Application.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}