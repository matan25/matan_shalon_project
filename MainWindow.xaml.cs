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

namespace WpfApplication8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Employee_System(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            WorkersEnviornement we = new WpfApplication8.WorkersEnviornement();
            we.ShowDialog();
        }

        private void Button_Consumer_Serviece(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Operating_System(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Managment(object sender, RoutedEventArgs e)
        {

=======
            WorkersWindow ws = new WpfApplication8.WorkersWindow();
            ws.ShowDialog();
>>>>>>> 63b9e90125f6ee582eaed2bb8e5b3086c386b453
        }
    }
}

