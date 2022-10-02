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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
            //RoleCB.ItemsSource = classes.ConnectOdb.ConObj.role.ToList();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            Registr();
        }

        void Registr() 
        {
            if (LoginTB.Text == "" || RoleCB.SelectedItem != null || NameTB.Text == "" || PasswordTB.Text == "")
            {
                MessageBox.Show("Заполните все поля","Error input",MessageBoxButton.OK,MessageBoxImage.Stop);
            }
            else
            {

            }
        }

        private void NameTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
