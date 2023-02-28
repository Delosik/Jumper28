using Jumper_SviridovKE_PR_20._106.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace Jumper_SviridovKE_PR_20._106
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public class helper
    {
        public static bool flag = false;
        public static int prioritet = 0;

        public static JumperSviridovEntities1 ent;
        public static JumperSviridovEntities1 GetContext()
        {
            if (ent == null)
            {
                ent = new JumperSviridovEntities1();
            }
            return ent;
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Content = new Pages.Page1(mainFrame);

        }

        public object frame { get; private set; }

        private void frame_LoadCompleted(object sender, NavigationEventArgs e)
        {
            try
            {
                Pages.Page1 pg = (Pages.Page1)e.Content;
                pg.Load();
            }
            catch { };

        }

    }
}
