using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
namespace NGEPMCompareTool
{
    enum CompareType
    {
        Practice,
        Enterprise,
        UserLevel,
        Usersecurity,
        Payer,
        Contract
    }

    class ConnectionString
    {
        public string DSN;
        public string User;
        public string Pwd;
    }

    class NGEngine
    {
        private DataTable LoadFinalResult(DataTable DTTable1, DataTable DTTable2)
        {
            DataTable DTResult = new DataTable();

            DTResult.Columns.Add("DBFieldName");
            DTResult.Columns.Add("Description");
            DTResult.Columns.Add("Value1");
            DTResult.Columns.Add("Value2");
            DTResult.Columns.Add("Diff");
            DTResult.Columns.Add("Type");

            DTResult.PrimaryKey = new DataColumn[] { DTResult.Columns["DBFieldName"] };


            for (int i = 0; i < DTTable1.Rows.Count; i++)
            {
                DTResult.Rows.Add(DTTable1.Rows[i][0].ToString(), GetDescriptionFromResource(DTTable1.Rows[i][0].ToString()), DTTable1.Rows[i][1].ToString());
            }

            for (int i = 0; i < DTTable2.Rows.Count; i++)
            {

                int index = DTResult.Rows.IndexOf(DTResult.Rows.Find(DTTable2.Rows[i][0]));
                if (index >= 0)
                { 
                    DTResult.Rows[index]["Value2"] = DTTable2.Rows[i][1].ToString();
                }
                else
                {
                    DTResult.Rows.Add(DTTable2.Rows[i][0].ToString(), GetDescriptionFromResource(DTTable2.Rows[i][0].ToString()), DTTable2.Rows[i][1].ToString());
                }
            }

            return DTResult;
        }

        private DataTable LoadFinalResultDiff(DataTable DTTable)
        {
            for (int i = 0; i < DTTable.Rows.Count; i++)
            {
                if (DTTable.Rows[i][2].ToString() != DTTable.Rows[i][3].ToString())
                {
                    DTTable.Rows[i][4] = "1";
                }
                else
                {
                    DTTable.Rows[i][4] = "0";
                }

                if (DTTable.Rows[i][0].ToString().Contains("ind"))
                {
                    DTTable.Rows[i][5] = "1";
                }
                else if (DTTable.Rows[i][0].ToString().Contains("lib"))
                {
                    DTTable.Rows[i][5] = "2";
                }
                else
                {
                    DTTable.Rows[i][5] = "0";
                }
            }
            return DTTable;
        }

        private string ExtractPracticeId(string str)
        {
            return str.Substring(0, str.IndexOf(';'));
        }

        private string GetDescriptionFromResource(string str)
        {
            return str;
        }

        private string ExtractPracticeName(string str)
        {
            return str.Substring(str.IndexOf(';') + 1, str.Length - str.IndexOf(';') - 1);
        }

        private DataTable CompareTable(string strTableName, ConnectionString ConnString1, ConnectionString ConnString2, string swhere1, string swhere2, System.Windows.Forms.ProgressBar Progress)
        {
            DBEngine DBEngine1 = new DBEngine(ConnString1);
            DBEngine DBEngine2 = new DBEngine(ConnString2);

            DataTable DTTable1 = new DataTable();
            DataTable DTTable2 = new DataTable();

            Progress.Value = 20;
            Progress.Refresh();
                        //Get Data From Table 1
            DTTable1 = DBEngine1.GetTableData(strTableName, swhere1);

            Progress.Value = 30;
            Progress.Refresh();
            //Get Data From Table 2
            DTTable2 = DBEngine2.GetTableData(strTableName, swhere2);


            //Generate Compare Result Table
            return LoadFinalResult(DTTable1, DTTable2);

        }

        private DataTable AppendDataTable(DataTable DTTable1, DataTable DTTable2)
        {
            
            for (int i = 0; i < DTTable2.Rows.Count; i++)
            {
                DTTable1.Rows.Add(DTTable2.Rows[i][0].ToString(), GetDescriptionFromResource(DTTable2.Rows[i][0].ToString()), DTTable2.Rows[i][1].ToString());
            }
            return DTTable1;
        }

        public DataTable Compare(CompareType cType, ConnectionString ConnString1, ConnectionString ConnString2, string swhere1, string swhere2, System.Windows.Forms.ProgressBar Progress )
        {
            //Declare Result List
            DataTable DTResult = new DataTable();

            DataTable DTTable1 = new DataTable();
            DataTable DTTable2 = new DataTable();
            DataTable DTTable3 = new DataTable();


            DBEngine DBEngine1 = new DBEngine(ConnString1);
            DBEngine DBEngine2 = new DBEngine(ConnString2);
            Progress.Value = 10;
            Progress.Refresh();
            switch (cType)
            {
                case CompareType.Practice:

                    //Get Data From Table 1
                    DTResult = CompareTable("Practice_misc", ConnString1, ConnString2, " Where Practice_id = '" + swhere1 + "'", " Where Practice_id = '" + swhere2 + "'", Progress);

                    break;
                case CompareType.Enterprise:

                    DTResult = CompareTable("enterprise_prefs", ConnString1, ConnString2, " Where enterprise_id = '" + swhere1 + "'", " Where enterprise_id = '" + swhere2 + "'", Progress);
                    break;
                case CompareType.Usersecurity:
                    break;
                case CompareType.Payer:
                    //Write code to check payer compare
                    //Get Data From Table 1
                    /*
                    payer_mstr_detail
                    payer_mstr_bh_min_rnd
                    payer_mstr_sec_refs
                    --payer_mstr_prov_paper_qual
                    payer_mstr_interface_link*/

                    DTResult = CompareTable("Payer_mstr", ConnString1, ConnString2, " Where Payer_id = '" + swhere1 + "'", " Where Payer_id = '" + swhere2 + "'", Progress);

                    DTTable3 = CompareTable("payer_mstr_prov_paper_qual", ConnString1, ConnString2, "Where Payer_id = '" + swhere1 + "'", "Where Payer_id = '" + swhere1 + "'", Progress);

                    if (DTTable3.Rows.Count > 0)
                        DTResult = AppendDataTable(DTResult, DTTable3) ;

                    break;
                case CompareType.Contract:

                    DTResult = CompareTable("contract_mstr", ConnString1, ConnString2, " Where contract_id = '" + swhere1 + "'", " Where contract_id = '" + swhere2 + "'", Progress);

                    break;

                default:
                    break;
            };

            Progress.Value = 60;
            Progress.Refresh();
            //Update Value with Difference
            DTResult = LoadFinalResultDiff(DTResult);

            Progress.Value = 80;
            Progress.Refresh();

            return DTResult;
        }

        public List<Tuple<string, string>> GetComboNames(ConnectionString ConnString, CompareType Ctype)
        {
            List<Tuple<string, string>> dsnList = new List<Tuple<string, string>>();
            DBEngine dbe1 = new DBEngine(ConnString);

            if (Ctype == CompareType.Practice)
            {
            dsnList = dbe1.GetTableData("Practice", 1, 2);
            }
            else if (Ctype == CompareType.Payer)
            {
                dsnList = dbe1.GetTableData("Payer_mstr", 0, 1);
            }
            else if (Ctype == CompareType.Enterprise)
            {
                dsnList = dbe1.GetTableData("enterprise", 0, 1);
            }
            else if (Ctype == CompareType.Contract)
            {
                dsnList = dbe1.GetTableData("contract_mstr", 0, 1);

            }
            return dsnList;
        }

        public List<string> GetUserDataSourceNames()
        {
            List<string> dsnList = new List<string>();

            // get user dsn's
            Microsoft.Win32.RegistryKey reg = (Microsoft.Win32.Registry.CurrentUser).OpenSubKey("Software");
            Microsoft.Win32.RegistryKey reg1 = (Microsoft.Win32.Registry.LocalMachine).OpenSubKey("Software");
            if (reg != null)
            {
                reg = reg.OpenSubKey("ODBC");
                if (reg != null)
                {
                    reg = reg.OpenSubKey("ODBC.INI");
                    if (reg != null)
                    {
                        reg = reg.OpenSubKey("ODBC Data Sources");
                        if (reg != null)
                        {
                            // Get all DSN entries defined in DSN_LOC_IN_REGISTRY.
                            foreach (string sName in reg.GetValueNames())
                            {
                                dsnList.Add(sName);
                            }
                        }
                        try
                        {
                            reg.Close();
                        }
                        catch { /* ignore this exception if we couldn't close */ }
                    }
                }
            }

            if (reg1 != null)
            {
                reg1 = reg1.OpenSubKey("ODBC");
                if (reg1 != null)
                {
                    reg1 = reg1.OpenSubKey("ODBC.INI");
                    if (reg1 != null)
                    {
                        reg1 = reg1.OpenSubKey("ODBC Data Sources");
                        if (reg1 != null)
                        {
                            // Get all DSN entries defined in DSN_LOC_IN_REGISTRY.
                            foreach (string sName in reg1.GetValueNames())
                            {
                                dsnList.Add(sName);
                            }
                        }
                        try
                        {
                            reg.Close();
                        }
                        catch { /* ignore this exception if we couldn't close */ }
                    }
                }
            }

            return dsnList;
        }
    }

    // DAL Starts From Here

    class DBEngine
    {
        private OdbcConnection DBcon = new OdbcConnection();
        private OdbcCommand DBComm = new OdbcCommand();
        private ConnectionString ConnectStr;
        private bool _connected;

        public bool DBConnect
        {
            get
            {
                return this._connected;
            }
            set
            {
                this._connected = value;
            }
        }

        public DBEngine(ConnectionString ConString)
        {
            ConnectStr = ConString;
            SqlConnect();
        }

        public void SqlConnect()
        {
            try
            {
                string sqlConnString = "dsn=" + ConnectStr.DSN + ";Uid=" + ConnectStr.User + "; Pwd=" + ConnectStr.Pwd + ";";
                DBcon.ConnectionString = sqlConnString;
                DBcon.Open();
                _connected = true;
            }
            catch (Exception e)
            {
                _connected = false;
            }
        }

        public DataTable GetTableData(string sTableName, string sWhere)
        {

            DataTable listResult = new DataTable();

            listResult.Columns.Add("fieldname");
            listResult.Columns.Add("Value1");

            listResult.PrimaryKey = new DataColumn[] { listResult.Columns["fieldname"] };
            string SQL;

            if (sWhere.Length == 0)
            {
                SQL = "Select * from " + sTableName;
            }
            else
            {
                SQL = "Select * from " + sTableName  + ' ' + sWhere ;
            }

            if (_connected)
            {
                DBComm.Connection = DBcon;
                DBComm.CommandText = SQL;

                DataSet ds = new DataSet();
                DataTable dt = new DataTable(sTableName);
                OdbcDataAdapter DBad = new OdbcDataAdapter(DBComm);
                DBad.Fill(ds);
                listResult.Clear();

                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                        listResult.Rows.Add(ds.Tables[0].Columns[i].ToString(), ds.Tables[0].Rows[0][ds.Tables[0].Columns[i].ToString()].ToString());
                }
            }
            return listResult;
        }

        public List<Tuple<string, string>> GetTableData(string sTableName, int indexDesc, int indexCode)
        {
            List<Tuple<string, string>> listResult = new List<Tuple<string, string>>();
            string SQL = "Select * from " + sTableName;

            SqlConnect();

                DBComm.Connection = DBcon;
                DBComm.CommandText = SQL;

                using (IDataReader ds = DBComm.ExecuteReader())
                {
                    while (ds.Read())
                        listResult.Add(Tuple.Create(ds[indexCode].ToString(), ds[indexDesc].ToString()));
                }

            return listResult;
        }
    }
    }
