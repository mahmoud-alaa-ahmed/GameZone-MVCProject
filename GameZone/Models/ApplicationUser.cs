﻿namespace GameZone.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}
