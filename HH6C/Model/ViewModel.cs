using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Odbc;
using System.IO;
using System.Net;


namespace HH6C.Model
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    /// 
    public class ViewModel : INotifyPropertyChanged
    {
        SQLiteConnection m_SQLITEdbConnection;
        OdbcConnection m_SYBASEconnection;
        
        string[] barva = new string[] { "Red", "Green", "Blue", "Purple", "Orange", "Lime", "Emerald", "Teal", "Cyan", "Cobalt", "Indigo", "Violet", "Pink", "Magenta", "Crimson", "Amber", "Yellow", "Brown", "Olive", "Steel", "Mauve", "Taupe", "Sienna" };
        string[] pozadi = new string[] { "Light", "Dark" };
        int pouzitabarva = 1;
        int pouzitepozadi = 1;
        int IDAKCE_int = 1;
        int INTERNIAKCEID_int = 1;
        bool bind_hledanichecked_value = false;


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #region SS bubliny

        public bool bind_S20
        {
            get {

                if (IDAKCE_int > 1) { 
                Boolean vysledek = false;
                if (SQL_READDATA("SYBASE", "select A.NETJMENO from akce_akcepocitac_v A left outer join AKCE_REGINFO_V R on R._MASTERID = A._MASTERID  where A.netjmeno='_S20' and R.SERNR='" + IDAKCE + "'", "console") == "_S20")
                {vysledek = true;};
                return vysledek;}
            else{ return false; }
        }
        }

        public bool bind_S19
        {
            get
            {
                if (IDAKCE_int > 1)
                {

                    Boolean vysledek = false;
                    if (SQL_READDATA("SYBASE", "select A.NETJMENO from akce_akcepocitac_v A left outer join AKCE_REGINFO_V R on R._MASTERID = A._MASTERID  where A.netjmeno='_S19' and R.SERNR='" + IDAKCE + "'", "console") == "_S19")
                    { vysledek = true; };
                    return vysledek;
                }
                else { return false; }
            }
        }
        public bool bind_S18
        {
            get
            {
                if (IDAKCE_int > 1)
                {

                Boolean vysledek = false;
                if (SQL_READDATA("SYBASE", "select A.NETJMENO from akce_akcepocitac_v A left outer join AKCE_REGINFO_V R on R._MASTERID = A._MASTERID  where A.netjmeno='_S18' and R.SERNR='" + IDAKCE + "'", "console") == "_S18")
                { vysledek = true; };
                return vysledek;
                }
                else { return false; }

            }
        }
        public bool bind_S17
        {
            get
            {
                if (IDAKCE_int > 1)
                {
                    Boolean vysledek = false;
                if (SQL_READDATA("SYBASE", "select A.NETJMENO from akce_akcepocitac_v A left outer join AKCE_REGINFO_V R on R._MASTERID = A._MASTERID  where A.netjmeno='_S17' and R.SERNR='" + IDAKCE + "'", "console") == "_S17")
                { vysledek = true; };
                return vysledek;
            }
                else { return false; }

        }
    }
        public bool bind_S16
        {
            get
            {
                if (IDAKCE_int > 1)
                {
                    Boolean vysledek = false;
                if (SQL_READDATA("SYBASE", "select A.NETJMENO from akce_akcepocitac_v A left outer join AKCE_REGINFO_V R on R._MASTERID = A._MASTERID  where A.netjmeno='_S16' and R.SERNR='" + IDAKCE + "'", "console") == "_S16")
                { vysledek = true; };
                return vysledek;
                }
                else { return false; }
            }
        }
        public bool bind_S15
        {
            get
            {
                if (IDAKCE_int > 1)
                {
                    Boolean vysledek = false;
                if (SQL_READDATA("SYBASE", "select A.NETJMENO from akce_akcepocitac_v A left outer join AKCE_REGINFO_V R on R._MASTERID = A._MASTERID  where A.netjmeno='_S15' and R.SERNR='" + IDAKCE + "'", "console") == "_S15")
                { vysledek = true; };
                return vysledek;
            }
                else { return false; }
        }
        }
        public bool bind_S14
        {
            get
            {
                if (IDAKCE_int > 1)
                {
                    Boolean vysledek = false;
                if (SQL_READDATA("SYBASE", "select A.NETJMENO from akce_akcepocitac_v A left outer join AKCE_REGINFO_V R on R._MASTERID = A._MASTERID  where A.netjmeno='_S14' and R.SERNR='" + IDAKCE + "'", "console") == "_S14")
                { vysledek = true; };
                return vysledek;
                }
                else { return false; }
            }
        }
        public bool bind_S13
        {
            get
            {
                if (IDAKCE_int > 1)
                {
                    Boolean vysledek = false;
                if (SQL_READDATA("SYBASE", "select A.NETJMENO from akce_akcepocitac_v A left outer join AKCE_REGINFO_V R on R._MASTERID = A._MASTERID  where A.netjmeno='_S13' and R.SERNR='" + IDAKCE + "'", "console") == "_S13")
                { vysledek = true; };
                return vysledek;
            }
                else { return false; }
        }
        }
        public bool bind_S12
        {
            get
            {
                if (IDAKCE_int > 1)
                {
                    Boolean vysledek = false;
                if (SQL_READDATA("SYBASE", "select A.NETJMENO from akce_akcepocitac_v A left outer join AKCE_REGINFO_V R on R._MASTERID = A._MASTERID  where A.netjmeno='_S12' and R.SERNR='" + IDAKCE + "'", "console") == "_S12")
                { vysledek = true; };
                return vysledek;
                }
                else { return false; }
            }
        }

        #endregion


        public bool bind_hledanichecked
        {
            get { return bind_hledanichecked_value; }
            set
            {
                bind_hledanichecked_value = value;
                OnPropertyChanged("bind_hledanichecked");
            }
        }



        private string someText;
        public string SomeText
        {
            get { return someText; }
            set
            {
                someText = value;


            }
        }




        public int IDAKCE
        {
            get { return IDAKCE_int; }
            set { 
                IDAKCE_int = value;
                if (IDAKCE_int > 1) {
                    Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                        BIND_INTERNIIDAKCE = Convert.ToInt32(SQL_READDATA("SYBASE", "select A._ID from AKCE_V A left outer join AKCE_REGINFO_V R on R._MASTERID = A._ID where R.SERNR='" + IDAKCE_int + "'", "console"));
                        OnPropertyChanged("IDAKCE");
                        OnPropertyChanged("BIND_CISLAAKCE");
                        OnPropertyChanged("BIND_NAZEVAKCE");
                        OnPropertyChanged("BIND_TYPSS");
                        OnPropertyChanged("BIND_TYPSW");
                        OnPropertyChanged("BIND_TYPPROVOZU");
                        OnPropertyChanged("BIND_STAVAKCE");
                        OnPropertyChanged("BIND_ADRESA");
                        OnPropertyChanged("BIND_POSLEDNITK");
                        OnPropertyChanged("BIND_POSLEDNISZ");


                        for (int i = 12; i <= 20; i++)
                        {
                            OnPropertyChanged("bind_S"+i);
                        }
                    }
                }
    }


        public int BIND_INTERNIIDAKCE
        {
            get { return INTERNIAKCEID_int; }
            set
            {
                INTERNIAKCEID_int = value;
                OnPropertyChanged("BIND_INTERNIIDAKCE");
            }
        }

        public string BIND_CISLAAKCE
        {
            get {
                string ret="---";
                string sqlvysledek;
                sqlvysledek = SQL_READDATA("SYBASE", "select R.SERNR, A._ID, A.CISLO from AKCE_V A left outer join AKCE_REGINFO_V R on R._MASTERID = A._ID where A._ID='" + BIND_INTERNIIDAKCE + "'", "console");
                string[] stringSeparators = new string[] { "|||" };
                string[] vysledky = sqlvysledek.Split(stringSeparators, StringSplitOptions.None);
                if (vysledky.Length >= 3) { 
                ret = string.Format("SN : {0}   |   ID : {1}   |   ČÍSLO : {2}", vysledky[0], vysledky[1], vysledky[2]); ;
                }
                return ret;
                ;
            }
        }

        public string BIND_NAZEVAKCE
        {
            get
            {
                return  SQL_READDATA("SYBASE", "select A.NAZEV from AKCE_V A where A._ID='" + BIND_INTERNIIDAKCE + "'", "console");
            }
        }

        public string BIND_TYPSS
        {
            get
            {
                return SQL_READDATA("SYBASE", "select A.SSTYP from AKCE_V A where A._ID='" + BIND_INTERNIIDAKCE + "'", "console");
            }
        }

        public string BIND_TYPSW {get {return SQL_READDATA("SYBASE", "select A.SKUPAKCE1 from AKCE_V A where A._ID='" + BIND_INTERNIIDAKCE + "'", "console");}}
        public string BIND_TYPPROVOZU { get { return SQL_READDATA("SYBASE", "select A.akcetyp from AKCE_V A where A._ID='" + BIND_INTERNIIDAKCE + "'", "console"); } }
        public string BIND_STAVAKCE { get { return SQL_READDATA("SYBASE", "select A.akcestav from AKCE_V A where A._ID='" + BIND_INTERNIIDAKCE + "'", "console"); } }
        private int int_FLIPID=1;
      

        public string BIND_POSLEDNISZ { 
            get {
                string vracenedatum = "---";
                try
                {

                string iString = SQL_READDATA("SYBASE", "select first CAST(a.ukoncenidt AS DATE) DATUM from telkonzultace_v A where A._AKCEID = '" + BIND_INTERNIIDAKCE + "' ORDER BY a._id desc", "console");
                DateTime oDate = DateTime.ParseExact(iString, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                vracenedatum = "Poslední SZ : " + oDate.ToString("dd.MM.yyyy");
                }
                catch (Exception exp)
                {
                    Console.Write(exp.ToString());
                }
                return vracenedatum;
            }
        }

        public string BIND_POSLEDNITK
        {
            get
            {
                string vracenedatum = "---";
try
                {
                    string iString = SQL_READDATA("SYBASE", "select first CAST(a.odjezddt  AS DATE) DATUM from protokol_v A where A._AKCEID = '" + BIND_INTERNIIDAKCE + "' ORDER BY a._id desc", "console");
                    DateTime oDate = DateTime.ParseExact(iString, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    vracenedatum= "Poslední TK : " +  oDate.ToString("dd.MM.yyyy");
                }

                catch (Exception exp)
                {
                    Console.Write(exp.ToString());
                }
                return vracenedatum;
            }
        }


        public string BIND_ADRESA
        {
            get
            {
                string ret = "---";
                string sqlvysledek;
                sqlvysledek = SQL_READDATA("SYBASE", "select A.adresa1, A.mesto from AKCE_V A where A._ID='" + BIND_INTERNIIDAKCE + "'", "console");
                string[] stringSeparators = new string[] { "|||" };
                string[] vysledky = sqlvysledek.Split(stringSeparators, StringSplitOptions.None);
                if (vysledky.Length >= 2)
                {
                    ret = string.Format("{0},{1}", vysledky[0], vysledky[1]); ;
                }
                return ret;
                ;
            }
        }

        //VM.Adresa = string.Format("{0},{1}", vysledky[6], vysledky[7]);




        private string gpsprahacas_str;
        public string gpsprahacas
        {
            get { return gpsprahacas_str; }
            set { gpsprahacas_str = value; OnPropertyChanged("gpsprahacas"); }
        }

        private string gpsprahavzdalenost_str;
        public string gpsprahavzdalenost
        {
            get { return gpsprahavzdalenost_str; }
            set { gpsprahavzdalenost_str = value; OnPropertyChanged("gpsprahavzdalenost"); }
        }





        private string gpsolomouccas_str;
        public string gpsolomouccas
        {
            get { return gpsolomouccas_str; }
            set { gpsolomouccas_str = value; OnPropertyChanged("gpsolomouccas"); }
        }

        private string gpsolomoucvzdalenost_str;
        public string gpsolomoucvzdalenost
        {
            get { return gpsolomoucvzdalenost_str; }
            set { gpsolomoucvzdalenost_str = value; OnPropertyChanged("gpsolomoucvzdalenost"); }
        }


        private int vybranyindexvhamburgeru_str=0;
        public int vybranyindexvhamburgeru
        {
            get { return vybranyindexvhamburgeru_str; }
            set { vybranyindexvhamburgeru_str = value; OnPropertyChanged("vybranyindexvhamburgeru"); }
            
        }


        public int Function_global_changeforeground
        {
            get { return pouzitabarva; }
            set { pouzitabarva = value; zmenbarvupopredi();
                //    OnPropertyChanged("Function_global_changeforeground"); 
            }
        }
        public int Function_global_changebackground
        {
            get { return pouzitepozadi; }
            set { pouzitepozadi = value; zmenbarvupozadi(); }
        }





        public void SQL_OPENCONNECTION(string typdb)
        {
            if (typdb == "SQLITE")
            {
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                var directory = System.IO.Path.GetDirectoryName(path);
                m_SQLITEdbConnection = new SQLiteConnection("Data Source=" + directory + "/db/data.db;");
                m_SQLITEdbConnection.Open();
            }

            if (typdb == "SYBASE")
            {
                m_SYBASEconnection = new OdbcConnection("DRIVER={Adaptive Server Anywhere 9.0};ENG=ASA9;DBN=ASWINFO;Uid=alesk;Pwd=p3crom9t;Links=tcpip(Host=db.aswsyst.cz);");
                m_SYBASEconnection.Open();
                
            }
            Console.WriteLine("SQL_OPENCONNECTION:" + typdb);

        }





        public void SQL_SQLITE_SAVEDATA(string sqltext)
        {
            try
            {

                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                var directory = System.IO.Path.GetDirectoryName(path);

                SQLiteCommand command = new SQLiteCommand(sqltext, m_SQLITEdbConnection);

                command.ExecuteNonQuery();
                Console.WriteLine("SQLSAVE:" + sqltext);
            }
            catch (Exception myException)
            {
                Console.WriteLine("Message: " + myException.Message + "\n");
            }



        }


        public string API_GETGOOGLEDISTANCE(string GPS, string odkud)
        {
            string vysledek = "";
            string url = "";

            if (odkud == "Praha") { url = @"https://maps.googleapis.com/maps/api/distancematrix/json?origins=" + GPS + "&destinations=K Hájům 2671/8,Praha&mode=car&language=cs-CZ&key=AIzaSyDe2K0EFQtR21phmbEYOAxiYb2wEtkdSxA";}
            if (odkud == "Olomouc") { url = @"https://maps.googleapis.com/maps/api/distancematrix/json?origins=" + GPS + "&destinations=Wittgensteinova 10, Olomouc&mode=car&language=cs-CZ&key=AIzaSyDe2K0EFQtR21phmbEYOAxiYb2wEtkdSxA"; }

            Console.WriteLine(url);
            WebRequest request = WebRequest.Create(url);

            WebResponse response = request.GetResponse();

            Stream data = response.GetResponseStream();

            StreamReader reader = new StreamReader(data);

            // json-formatted string from maps api
            string responseFromServer = reader.ReadToEnd();

            response.Close();
            vysledek = responseFromServer;



            foreach (var line in vysledek.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
            {
                if (line.Contains("\"text\" : \""))
                {
                    string[] words = line.Split(new string[] { "\"text\" : \"" }, StringSplitOptions.None);
                
                    if (words[1].Contains("km"))
                    {

                        if (odkud == "Praha"){ gpsprahavzdalenost = words[1].Remove(words[1].Length - 2) ; }
                        if (odkud == "Olomouc") { gpsolomoucvzdalenost =  words[1].Remove(words[1].Length - 2); }
                    }
                    else
                    {
                        if (odkud == "Praha") { gpsprahacas = "Praha" + Environment.NewLine +  words[1].Remove(words[1].Length - 2); }
                        if (odkud == "Olomouc") { gpsolomouccas = "Olomouc" + Environment.NewLine +  words[1].Remove(words[1].Length - 2); }
                    }
                    Console.WriteLine("XXX" + words[1] + "YYY");
                }
            }

            return vysledek;
        }


    

       


        public void SQL_CLOSECONNECTION(string typdb)
        {
            if (typdb == "SQLITE")
            {
                m_SQLITEdbConnection.Close();
            }

            if (typdb == "SYBASE")
            {
                m_SYBASEconnection.Close();
            }
            Console.WriteLine("SQL_CLOSECONNECTION:" + typdb);

        }



        public string SQL_READDATA(string typdb, string sqltext, string kamulozitvysledek)
        {
            string vysledek = "";

            if (typdb == "SQLITE")
            {
                SQLiteCommand command = new SQLiteCommand(sqltext, m_SQLITEdbConnection);
                SQLiteDataReader sqlite_datareader;
                try
                {
                    sqlite_datareader = command.ExecuteReader();
                    while (sqlite_datareader.Read())
                    {
                        string myreader = sqlite_datareader.GetString(0);
                        vysledek = myreader;
                       

                    }
                }
                catch (Exception myException)
                {
                    Console.WriteLine("Message: " + myException.Message + "\n");
                }

            }






            if (typdb == "SYBASE")
            {
                OdbcCommand command = new OdbcCommand(sqltext, m_SYBASEconnection);
                OdbcDataReader odbc_datareader;
                try
                {
                    odbc_datareader = command.ExecuteReader();
                    while (odbc_datareader.Read())
                    {

                        for (int i = 0; i < odbc_datareader.FieldCount; i++)
                        {
                            Console.WriteLine("Value of i: {0}", odbc_datareader.GetString(i));
                            vysledek = vysledek + "|||" + odbc_datareader.GetString(i);
                        }

//                        string myreader = odbc_datareader.GetString(i-1);
  //                      Console.WriteLine(i);
    //                    Console.WriteLine(myreader);                            
      //                      vysledek = vysledek+ myreader;

                    }
                }
                catch (Exception myException)
                {
                    Console.WriteLine("Message: " + myException.Message + "\n");
                }

            }



            if (kamulozitvysledek == "pozadi")
            {
                pouzitepozadi = Int32.Parse(vysledek);
                //MahApps.Metro.ThemeManager.ChangeThemeBaseColor(System.Windows.Application.Current, pozadi[Int32.Parse(vysledek)]);
                zmenbarvupozadi();
            }
            if (kamulozitvysledek == "popredi")
            {

                pouzitabarva = Int32.Parse(vysledek);
                //                MahApps.Metro.ThemeManager.ChangeThemeColorScheme(System.Windows.Application.Current, barva[Int32.Parse(vysledek)]);
                zmenbarvupopredi();
            }

            Console.WriteLine("SQL_READDATA do DB " + typdb + " se selectem " + sqltext + " do uložení " + kamulozitvysledek + " se rovná výsledku " + vysledek);
            string data = vysledek;
            string realvysledek;

            if (data.Contains("|||"))
            {
                realvysledek = data.Remove(0,3);
            }
            else
            {
                realvysledek = data;
            }
            return realvysledek;


        }


        public void zmenbarvupopredi()
        {




            if (pouzitabarva == 23)
            {
                pouzitabarva = 0;
            }


            MahApps.Metro.ThemeManager.ChangeTheme(System.Windows.Application.Current, pozadi[pouzitepozadi], barva[pouzitabarva]);
            SQL_SQLITE_SAVEDATA("update nastaveni set hodnota = " + pouzitabarva + " where polozka='popredi'");

        }


        public void zmenbarvupozadi()
        {



            if (pouzitepozadi == 2)
            {
                pouzitepozadi = 0;
            }

            SQL_SQLITE_SAVEDATA("update nastaveni set hodnota = " + pouzitepozadi + " where polozka='pozadi'");
            MahApps.Metro.ThemeManager.ChangeTheme(System.Windows.Application.Current, pozadi[pouzitepozadi].ToString(), barva[pouzitabarva].ToString());

        }



    }
}
