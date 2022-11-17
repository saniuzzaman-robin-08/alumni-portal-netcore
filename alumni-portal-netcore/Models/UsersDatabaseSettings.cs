﻿namespace CoUAlumniPortal.Models
{
    public class UsersDatabaseSettings : IUsersDatabaseSettings
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
        public string UsersCollectionName { get; set; } = string.Empty;
    }
}
