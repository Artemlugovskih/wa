using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Стройматериалы.Entity;

namespace Стройматериалы.Model
{
    public static class UserSingletone
    {
        public static User User { get; set; }
    }
}
