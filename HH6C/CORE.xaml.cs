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
using MahApps.Metro.Controls;
using System.Data.SQLite;
using HH6C.View;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using HH6C.Model;

namespace HH6C
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    /// 

    public partial class CORE : MetroWindow
    {

        private ViewModel VM => this.DataContext as ViewModel;



        public CORE()
        {

            this.DataContext = new ViewModel();
            InitializeComponent();
            VM.SQL_OPENCONNECTION("SQLITE");
            VM.SQL_OPENCONNECTION("SYBASE");
            VM.SQL_READDATA("SQLITE", "select hodnota from nastaveni where polozka='pozadi'", "pozadi");
            VM.SQL_READDATA("SQLITE", "select hodnota from nastaveni where polozka='popredi' ", "popredi");
            //MahApps.Metro.ThemeManager.ChangeTheme(Application.Current, pozadi[pouzitepozadi], barva[pouzitabarva]);
            
        }




        private void HamburgerMenuControl_OnItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs e)
        {
            //this.HamburgerMenuControl.Content = e.InvokedItem;
            //this.HamburgerMenuControl.DataContext = Pohledy.Test.DataContextProperty;
        }





        public void test()
        {
        }


        private void CLICK_changeforeground(object sender, RoutedEventArgs e)
        {
            VM.Function_global_changeforeground = VM.Function_global_changeforeground + 1;
        }

        private void CLICK_changebackground(object sender, RoutedEventArgs e)
        {
            VM.Function_global_changebackground = VM.Function_global_changebackground + 1;

        }







        private void core_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            VM.SQL_CLOSECONNECTION("SQLITE");
            VM.SQL_CLOSECONNECTION("SYBASE");
        }




       

    }
}
