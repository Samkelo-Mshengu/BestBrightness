using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLogic.User
{
    public class UserView
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public char? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string ContactNumber { get; set; } = default!;
        public string Username { get; set; } = default!;
        public string UserType { get; set; } = default!;
    }
}
