﻿namespace AuthWebAPI.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        public string Roles { get; set; } = string.Empty;
    }
}
