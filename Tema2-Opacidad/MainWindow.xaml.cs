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

namespace Tema2_Opacidad
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

        
        private void Img_MouseEnter(object sender, MouseEventArgs e)
        {
            String foto = (sender as Image).Tag.ToString();
            
            if (foto =="img1")
                img1.Opacity = 1;
            else if (foto == "img2")
                img2.Opacity = 1;
            else 
                img3.Opacity = 1;
        }

        private void Img_MouseLeave(object sender, MouseEventArgs e)
        {
            img1.Opacity = 0.5;
            img2.Opacity = 0.5;
            img3.Opacity = 0.5;
        }
    }
}
