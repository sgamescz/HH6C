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
            InitializeComponent();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            hledejakci(Int32.Parse(hledaneid.Text));
        }

       



        public void hledejakci(int ID)
        {
            try
            {

                VM.IDAKCE=ID;
                
                string vratkaselectu;
                vratkaselectu = VM.SQL_READDATA("SYBASE", "select A.NAZEV, R.SERNR, A._ID, A.CISLO, A.SSTYP, A.Akcestav, A.adresa1, A.mesto, A.popisinst, A.ras, A.popisnet, A._SKA2ID, A.popis, A.Akcetyp, A.SKUPAKCE1 from AKCE_V A left outer join AKCE_REGINFO_V R on R._MASTERID = A._ID where r.SERNR = '" + ID + "' ORDER BY NAZEV", "console");
                string[] stringSeparators = new string[] { "|||" };
                string[] vysledky = vratkaselectu.Split(stringSeparators, StringSplitOptions.None);
                //            foreach (string word in vysledky)
                //          {
                //            Console.WriteLine("vysledky: " + word);
                //      }
                var color = (Brush)Application.Current.Resources["MahApps.Brushes.Accent"];


            

                ////title_stavakce.Background = color;
                ////title_smlouva.Background = color;
                ////title_olomouc.Background = color;
                ////title_praha.Background = color;

                ////if (vysledky[4] == "TOP servis") { title_smlouva.Background = Brushes.YellowGreen; }
                ////if (vysledky[4] == "S19 (Maintenance)") { title_smlouva.Background = Brushes.Gray; }
                ////if (vysledky[4] == "S18 (Maintenance)") { title_smlouva.Background = Brushes.Gray; }
                ////if (vysledky[4] == "S17 (Maintenance)") { title_smlouva.Background = Brushes.Gray; }
                ////if (vysledky[4] == "S16 (Maintenance)") { title_smlouva.Background = Brushes.Gray; }
                ////if (vysledky[4] == "S15 (Maintenance)") { title_smlouva.Background = Brushes.Gray; }
                ////if (vysledky[5].Contains("rušená")) { title_stavakce.Background = Brushes.Gray; }
                ////if (vysledky[5].Contains("V hotovosti")) { title_stavakce.Background = Brushes.Red; }

                ////akceinfo.Text = vysledky[8];
                ////akceinfo2.Text = vysledky[9];
                ////akceinfo3.Text = vysledky[10];
                ////akceinfo_zaklinfo.Text = vysledky[12];


                //string iString = VM.SQL_READDATA("SYBASE", "select first CAST(a.ukoncenidt AS DATE) DATUM from telkonzultace_v A left outer join AKCE_REGINFO_V R on R._MASTERID = A._akceid where r.SERNR = '" + ID + "' ORDER BY a._id desc", "console");
                //DateTime oDate = DateTime.ParseExact(iString, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
//                title_poslednitk.Title = oDate.ToString("dd.MM.yyyy");

                //iString = VM.SQL_READDATA("SYBASE", "select first CAST(a.odjezddt  AS DATE) DATUM from protokol_v A left outer join AKCE_REGINFO_V R on R._MASTERID = A._akceid where r.SERNR = '" + ID + "' ORDER BY a._id desc", "console");
                //oDate = DateTime.ParseExact(iString, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
  //              title_poslednisz.Title = oDate.ToString("dd.MM.yyyy");

                
              


                //VM.API_GETGOOGLEDISTANCE(VM.SQL_READDATA("SYBASE", "select A.SEPJMENO from akce_akcepocitac_v A left outer join AKCE_REGINFO_V R on R._MASTERID = A._MASTERID  where A.netjmeno='_GPS' and R.SERNR='" + ID + "'", "console"), "Praha");
                //VM.API_GETGOOGLEDISTANCE(VM.SQL_READDATA("SYBASE", "select A.SEPJMENO from akce_akcepocitac_v A left outer join AKCE_REGINFO_V R on R._MASTERID = A._MASTERID  where A.netjmeno='_GPS' and R.SERNR='" + ID + "'", "console"), "Olomouc");
                //title_ostrava.Count = "145Km" + Environment.NewLine + "1:45 hod.";
                

                //Decimal kilometry1 = Convert.ToDecimal(title_praha.Count.Remove(title_praha.Count.Length - 2));
                //Decimal kilometry2 = Convert.ToDecimal(title_olomouc.Count.Remove(title_olomouc.Count.Length - 2));
                //Console.WriteLine(kilometry1);
                //Console.WriteLine(kilometry2);

                //if (kilometry1>kilometry2) { title_praha.Background = Brushes.Gray; }
                //else { title_olomouc.Background = Brushes.Gray;  }

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

    

    }
}
