using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstNewDatabaseSample
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string DisplayName { get; set; }
    }
}
