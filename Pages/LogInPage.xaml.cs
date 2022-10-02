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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace program1.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        public LogIn()
        {
            InitializeComponent();
            LogTB.Focus();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            classes.FrameObj.frameObj.Navigate(new Pages.Registration());
        }

        private void BtnLog_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LogTB.Text != "" & PassTB.Password != "")
                {
                    var user = classes.ConnectOdb.ConObj.user.Where(x => x.Login == LogTB.Text && x.Password == PassTB.Password).FirstOrDefault();
                    if (user != null)
                    {
                        var role = classes.ConnectOdb.ConObj.role.Where(x => x.Id == user.IdRole).FirstOrDefault();
                        var result = MessageBox.Show($"Пользователь найден, успешная авторизация\nВы авторизовались как {role.Name}", "Suspect", MessageBoxButton.OK, MessageBoxImage.Information);
                        if (result == MessageBoxResult.OK)
                        {
                            switch (role.Id)
                            {
                                case 1:
                                    classes.FrameObj.frameObj.Navigate(new Pages.AdminPage());
                                    break;
                                case 2:
                                    classes.FrameObj.frameObj.Navigate(new Pages.ManagerPage());
                                    break;
                                case 3:
                                    classes.FrameObj.frameObj.Navigate(new Pages.UserPage());
                                    break;
                                default:
                                    MessageBox.Show("Не удалось получить данные о роли, попробуйте авторизоваться снова","Data Not Found",MessageBoxButton.OK,MessageBoxImage.Error);
                                    break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден ", "ErrorAutorization", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Для входа введите в поля логин и пароль данные", "ErrorInput", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Необработанная ошибка\n {ex.Message}","CritError",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void BtnGuest_Click(object sender, RoutedEventArgs e)
        {
            classes.FrameObj.frameObj.Navigate(new Pages.GuestPage());
        }
    }
}
