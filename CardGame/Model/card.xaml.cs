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

namespace CardGame.Model
{
    /// <summary>
    /// Interaction logic for card.xaml
    /// </summary>
    public partial class card : UserControl
    {
        private string code;
        private string image;
        public card(string code, string image)
        {
            

            this.code = code;
            this.image = image;

            InitializeComponent();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(image, UriKind.Absolute);
            bitmap.EndInit();
            card_image.Source = bitmap;

        }
    }
}
