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

namespace EjercicioA3DOM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtLabel.Text = "";
            txtLabel.Visibility = Visibility.Hidden;
            txtName.Text = "";
            
        }

        private void btn_message_Click(object sender, RoutedEventArgs e)
        {
            if(txtName.Text.Trim() == "")
            {
                MessageBox.Show("Nombre es Obligatorio", "Hola Mundo");
                txtName.Text = "";
                txtLabel.Text = "";
                txtLabel.Visibility = Visibility.Hidden;
            }
            else
            {
                txtLabel.Text = "Bienvenido " + txtName.Text.Trim() + " !!!";
                txtLabel.Visibility = Visibility.Visible;
                txtName.Text = "";
            }
        }
    }
}
