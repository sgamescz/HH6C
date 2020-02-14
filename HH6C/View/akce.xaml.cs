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
using HH6C.Model;
using System.Data.Odbc;

namespace HH6C.View
{
    /// <summary>
    /// Interakční logika pro FirstView.xaml
    /// </summary>
    public partial class Akce : UserControl
    {
        
        private ViewModel VM => this.DataContext as ViewModel;
        public Akce()
        {
            Console.WriteLine("AKCE INICIALIZACE");
            InitializeComponent();
            Console.WriteLine("AKCE INICIALIZOVANO");

        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            hledejakci(Int32.Parse(hledaneid.Text));
        }



        public void hledejakci(int ID)
        {
            try
            {
                VM.hledejakci(ID);
           
            }
            catch (Exception exp)
            {
                Console.Write(exp.ToString());
            }
        }
        private static OdbcConnection Connect(String strUserName, String strPassword, String strPort, String strHostName, String dbName, out String strErrorMsg)
        {
            OdbcConnection con = null;
            strErrorMsg = String.Empty;
            try
            {
                String conString = "DRIVER={Adaptive Server Anywhere 9.0};ENG=ASA9;DBN=ASWINFO;Uid=alesk;Pwd=p3crom9t;Links=tcpip(Host=db.aswsyst.cz);";
                con = new OdbcConnection(conString);
                con.Open();
            }
            catch (Exception exp)
            {
                con = null;
                strErrorMsg = exp.ToString();
            }

            return con;
        }

        private static void Close(OdbcConnection con)
        {
            con.Close();
        }


        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            //            var styl = (Style)Application.Current.Resources["MahApps.Metro.Styles.MetroCircleButtonStyle"];

            Button mybutton = new Button();
            gridpokus.Children.Add(mybutton);
            mybutton.Height = 100;
           // mybutton.Style = styl;
            mybutton.Width = 100;
            mybutton.Name = "button";
            mybutton.Content = mybutton.Name;
            //mybutton.Click += button_Click;
        }

        private void ToggleButton_Checked_1(object sender, RoutedEventArgs e)
        {
                        var styl = (Style)Application.Current.Resources["MahApps.Metro.Styles.AccentedSquareButtonStyle"];

            Button mybutton = new Button();
            gridpokus.Children.Add(mybutton);
            mybutton.Height = 100;
            mybutton.Style = styl;
            mybutton.Width = 100;
            mybutton.Name = "button";
            mybutton.Content = mybutton.Name;
            //mybutton.Click += button_Click;
        }

        private void unload(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("AKCE UNLOADED");
        }

        private void Label_Loaded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("AKCE LOADED");

        }
    }
}
