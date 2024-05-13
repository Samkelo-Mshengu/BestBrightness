using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLogic.User
{
    public class UserView
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string Username { get; set; }
        public string UserType { get; set; }
    }
}
