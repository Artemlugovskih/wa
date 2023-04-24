using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Стройматериалы.ViewModel;

namespace Стройматериалы.View
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        private AuthViewModel _authViewModel;
        public AuthWindow()
        {
            InitializeComponent();
            DataContext = _authViewModel= new AuthViewModel();
        }

        private void TbLog_TextChanged(object sender, TextChangedEventArgs e)
        {
            (DataContext as AuthViewModel).Login = TbLog.Text;
        }

        private void PsBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            (DataContext as AuthViewModel).Password = PsBox.Password;
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            _authViewModel.Auth();
        }
    }
}
