﻿using System;

namespace RMSDesktopUILibrary.Models
{
    public interface ILoggedInUserModel
    {
        string Token { get; set; }
        string Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        DateTime CreateDate { get; set; }
    }
}