using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApps
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

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "Button Clicked !";

            await Task.Run(async () => {

                await Task.Delay(1000);

                // To avoid UI cross thread problem.
                await Dispatcher.BeginInvoke(new Action(() => { textBox.Text = ""; }));

            });

            //or 
            //await Task.Delay(1000);

        }
    }
}
