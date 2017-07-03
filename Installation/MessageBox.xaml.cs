using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Installation
{
    /// <summary>
    /// MessageBox.xaml 的交互逻辑
    /// </summary>
    public partial class MessageWindow : Window
    {
        public MessageWindow(string title, string message)
        {
            InitializeComponent();
            ImageBrush b = new ImageBrush();
            b.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/MSGBack.png"));
            b.Stretch = Stretch.Fill;
            this.Background = b;
        }

        public static bool?  ShowMessage(string title, string message)
        {
            MessageWindow messageWindow = new MessageWindow(title, message);
            return messageWindow.ShowDialog();
        }
    }
}
