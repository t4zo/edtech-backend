﻿using System.Collections.Generic;

namespace EdTech.Options
{
    public class UserOptions
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<string> Roles { get; set; }
    }
}