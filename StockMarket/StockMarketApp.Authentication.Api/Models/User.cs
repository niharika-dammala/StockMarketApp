using System;
using System.Collections.Generic;

#nullable disable

namespace StockMarketApp.Authentication.Api.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Confirmed { get; set; }
    }
}
