using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAuthRef.Models
{
    public class User
    {
        public int Id {  get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateOnly RegistrationDate { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public int RoleId { get; set; } //Пример названия: TestId
        public Role Role { get; set; } //Пример: Test
    }
}
