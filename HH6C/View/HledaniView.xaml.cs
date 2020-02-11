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
using HH6C;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using HH6C.Model;

namespace HH6C.View
{




    /// <summary>
    /// Interakční logika pro HledaniView.xaml
    /// </summary>
    public partial class HledaniView : UserControl
    {
        private ViewModel VM => this.DataContext as ViewModel;
     


        public HledaniView()
        {
            InitializeComponent();
        }




        private void hledej_GotFocus(object sender, RoutedEventArgs e)
        {
            var myValue = ((TextBox)sender).Tag.ToString();
            var dynradiobutton = (RadioButton)this.FindName("hledejradio"+myValue);
            dynradiobutton.IsChecked  = true ;
            VM.SQL_SQLITE_SAVEDATA("update nastaveni set hodnota = '" + ((TextBox)sender).Tag.ToString() + "' where polozka='selectedsearch'");
        }

        



        private void hledej_textchanged(object sender, RoutedEventArgs e)
        {
            if (sender != null)
            {
                var myValue = ((TextBox)sender).Tag.ToString();
                VM.SQL_SQLITE_SAVEDATA("update nastaveni set hodnota = '" + ((TextBox)sender).Text.ToString() + "' where polozka='hledano" + myValue + "'");
            }
        }

        private void inicializaceformulare(object sender, RoutedEventArgs e)
        {
     
            var oznacenyradio = (RadioButton)this.FindName("hledejradio" + VM.SQL_READDATA("SQLITE","select hodnota from nastaveni where polozka='selectedsearch' ", "selectedsearch"));
            oznacenyradio.IsChecked = true;
            oznacenyradio = null;

            for (int i = 1; i < 11; i++)
            {
                var tmp_hledanotextbox= (TextBox)this.FindName("hledej_"+i);
                tmp_hledanotextbox.Text = VM.SQL_READDATA("SQLITE","select hodnota from nastaveni where polozka='hledano"+i+"'", "");
                tmp_hledanotextbox= null;
            }

        }

        private void BTN_hledejakci_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            // VM.vybranyindexvhamburgeru = 1;
            //DM.bind_hledanichecked(1);
            

    }
}
}
