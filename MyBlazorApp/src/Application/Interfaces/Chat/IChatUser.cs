﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlazorApp.Application.Interfaces.Chat
{
    public interface IChatUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Column(TypeName = "text")]
        public string ProfilePictureDataUrl { get; set; }
    }
}