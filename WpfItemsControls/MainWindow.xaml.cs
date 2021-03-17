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

namespace WpfItemsControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();

            //Person p = new Person();
            //p.FirstName = "Mads";
            //p.LastName = "Rasmussen";
            //p.Email = "mara@aspit.dk";
            //p.PhoneNumber = "121654654";

            //Person p1 = new Person();
            //p1.FirstName = "Brian";
            //p1.LastName = "Jørgensen";
            //p1.Email = "brjo@aspit.dk";
            //p1.PhoneNumber = "8787878787";

            //string s = p1.FullName();
            //p1.FirstName = "Jens";
            //s = p1.FullName();
        }
    }
}
