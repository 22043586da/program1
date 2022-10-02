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

namespace program1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            classes.ConnectOdb.ConObj = new BD.slojEntities();
            classes.FrameObj.frameObj = MainFrame;
            MainFrame.Navigate(new Pages.LogIn());
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                classes.FrameObj.frameObj.GoBack();
            }
            catch (Exception)
            {
                MessageBox.Show("Некуда возвращаться","Caution",MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
