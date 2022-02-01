using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_works.SCR.ObjectUser
{
    public partial class Buyer
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password{ get; set; }

        public Buyer(string Login, string Password) { 
            this.Login = Login;
            this.Password = Password;
        }
    }
}
