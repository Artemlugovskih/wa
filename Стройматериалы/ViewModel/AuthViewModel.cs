using KininTech.SqlMapping.ORM;
using SqlKata;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.Builders;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Стройматериалы.Entity;
using Стройматериалы.Model;

namespace Стройматериалы.ViewModel
{
    public class AuthViewModel : BaseViewModel
    {
        private string _login;
        private string _password;
        public BuildingMaterialEntities _db;
        private AuthViewModel _authViewModel;

        public AuthViewModel()
        {
            _db = new BuildingMaterialEntities();
            _authViewModel = new AuthViewModel();
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

       public async Task<bool> Helper(string log,string password)
        {
            var user = await _db.User.FirstOrDefaultAsync(x => x.Password == password && x.Login == log);
            if (user == null)
            {
                return false;
            }
            UserSingletone.User=user;
            return true;
        }

        public async void Auth()
        {
            if (await _authViewModel.Helper(Login, Password))
            {
                MessageBox.Show("Авторизация прошла успешно");
                
            }
            else
            {
                MessageBox.Show("Что-то пошло не так , повторите попытку позже");
            }
        }

    }
}
