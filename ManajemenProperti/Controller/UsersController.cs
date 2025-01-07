using ManajemenProperti.Model.Entity;
using ManajemenProperti.Model.Repositori;
using ManajemenProperti.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenProperti.Controller
{
    public class UsersController
    {
        private readonly UsersRepository usersRepository;

        public UsersController()
        {
            // Pastikan DbContext diinstansiasi dengan benar
            usersRepository = new UsersRepository(new DbContext());
        }

        public bool Login(string username, string password)
        {
            var user = new User { Username = username, Password = password };
            return usersRepository.Login(user);
        }

        public bool Register(string username, string password)
        {
            var user = new User { Username = username, Password = password };
            return usersRepository.Register(user);
        }
    }
}
