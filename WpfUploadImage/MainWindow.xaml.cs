using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfUploadImage
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

        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                string appPath = @"..\..\..\Assets\UploadedImages\";
                var fileNameToSave = Guid.NewGuid().ToString()+'_'+op.SafeFileName;
                ImageUrl.Text = op.FileName;
                var imagePath = System.IO.Path.Combine(appPath + fileNameToSave);
                {
                    Directory.CreateDirectory(appPath);
                }
                //this.user,ImagePath = imagePath; //Add Image path to user
                File.Copy(op.FileName, imagePath);

            }
        }
    }
}
