using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace lol
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
     

      

        public MainWindow()
        {
            InitializeComponent();
            var handle = GetConsoleWindow();
            // Hide
            ShowWindow(handle, SW_HIDE);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var handle = GetConsoleWindow();
            // Show
            ShowWindow(handle, SW_SHOW);
            for (int counter = 0; counter<50; counter++)
            {
                Console.Beep(20000, 500);
                Console.WriteLine("LMAOBOX has activated");
            }
        }
    }
}
