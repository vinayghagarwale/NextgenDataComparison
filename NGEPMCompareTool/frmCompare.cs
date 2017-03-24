using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGEPMCompareTool
{
    public partial class frmCompare : Form
    {
        NGEngine NGEng = new NGEngine();

        ConnectionString ConnString1 = new ConnectionString();
        ConnectionString ConnString2 = new ConnectionString();

        DataTable listResult = new DataTable();

        List<Tuple<string, string>> sPractices1 = new List<Tuple<string,string>>();
        List<Tuple<string, string>> sPractices2 = new List<Tuple<string,string>>();

        string strErrMsg = "Contact Administrator";

        public frmCompare()
        {
            InitializeComponent();
        }

        private void frmCompare_Load(object sender, EventArgs e)
        {
            try
            {
                //Load Default DSN
                InitiateControls();
            }
            catch (Exception errr)
            {
                MessageBox.Show(strErrMsg + " - " + errr.Message);
                CompareProgress.Visible = false;
                this.Close();
            }

        }

        private void cmd_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDSN1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ConnString1.DSN = Convert.ToString(cboDSN1.SelectedItem);
                ConnString1.User = txtUser.Text;
                ConnString1.Pwd = txtPwd.Text;

                if (CheckDSN(ConnString1))
                {
                    lblCon1.Text = "Connected";
                    ChangeCompareType();
                    GrpLogin.Visible = false;
                    btnConnect1.Visible = false;
                }
                else
                {
                    lblCon1.Text = "Not Connected";
                    GrpLogin.Visible = true;
                    btnConnect1.Visible = true;
                    ShowLogin(cboDSN1);
                }
            }
            catch(Exception errr)
            {
                MessageBox.Show(strErrMsg + " - " + errr.Message);
                this.Close();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                CompareProgress.Visible = false;
                CompareProgress.Value = 10;
                if (GrpLogin.Left == cboDSN1.Left)
                {
                    ConnString1.DSN = cboDSN1.SelectedItem.ToString();
                    ConnString1.User = txtUser.Text;
                    ConnString1.Pwd = txtPwd.Text;
                    if (CheckDSN(ConnString1))
                    {
                        lblCon1.Text = "Connected";
                        ChangeCompareType_Connect();
                        btnConnect1.Visible = false;
                    }
                    else
                    {
                        lblCon1.Text = "Not Connected";
                        btnCompare.Enabled = false;
                    }
                }
                else if (GrpLogin.Left == cboDSN2.Left)
                {
                    ConnString2.DSN = cboDSN2.SelectedItem.ToString();
                    ConnString2.User = txtUser.Text;
                    ConnString2.Pwd = txtPwd.Text;
                    if (CheckDSN(ConnString1))
                    {
                        lblCon2.Text = "Connected";
                        ChangeCompareType_Connect();
                        btnConnect2.Visible = false;
                    }
                    else
                    {
                        lblCon2.Text = "Not Connected";
                        btnCompare.Enabled = false;
                    }
                }
                if (ConnString1.DSN != "" && ConnString2.DSN != "")
                {
                    btnCompare.Enabled = true;
                }
                GrpLogin.Visible = false;
                CompareProgress.Visible = false;
            }
            catch(Exception errr)
            {
                MessageBox.Show(strErrMsg + " - " + errr.Message);
                CompareProgress.Visible = false;
                this.Close();
            }
        }

        private void cboDSN2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboDSN1.SelectedItem == cboDSN2.SelectedItem)
                {
                    ConnString2 = ConnString1;
                    btnCompare.Enabled = true;
                }
                else
                {
                    ConnString2.DSN = Convert.ToString(cboDSN2.SelectedItem);
                    ConnString2.User = "";
                    ConnString2.Pwd = "";
                }

                if (CheckDSN(ConnString2))
                {
                    lblCon2.Text = "Connected";
                    if (rdPractice.Checked == true)
                    {
                            LoadCombo(NGEng.GetComboNames(ConnString2, CompareType.Practice), cbo_Practice2);
                    }
                    else if (rdEnterPrise.Checked == true)
                    {
                            LoadCombo(NGEng.GetComboNames(ConnString2, CompareType.Practice), cbo_Practice2);
                    }
                    else if (rdPayer.Checked == true)
                    {
                            LoadCombo(NGEng.GetComboNames(ConnString2, CompareType.Payer), cbo_Practice2);
                    }
                    GrpLogin.Visible = false;
                    btnConnect2.Visible = false;
                }
                else
                {
                    lblCon2.Text = "Not Connected";
                    GrpLogin.Visible = true;
                    btnConnect2.Visible = true;
                    ShowLogin(cboDSN2);
                } 
            }
            catch(Exception errr)
            {
                MessageBox.Show(strErrMsg + " - " + errr.Message);
                this.Close();
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            GrpLogin.Visible = false;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            try
            {
                CompareProgress.Value = 0;
                CompareProgress.Visible = true;
                CompareProgress.Refresh();
                CompareProgress.Value = 3;
                CompareProgress.Refresh();

                string cbo_PracticeVal1 = sPractices1[cbo_Practice1.SelectedIndex].Item2;
                string cbo_PracticeVal2 = sPractices1[cbo_Practice2.SelectedIndex].Item2;
                if (rdPractice.Checked == true)
                {

                    listResult = NGEng.Compare(CompareType.Practice, ConnString1, ConnString2, Convert.ToString(cbo_PracticeVal1), Convert.ToString(cbo_PracticeVal2), CompareProgress);
                }
                else if (rdEnterPrise.Checked == true)
                {
                    listResult = NGEng.Compare(CompareType.Enterprise, ConnString1, ConnString2, Convert.ToString(cbo_PracticeVal1), Convert.ToString(cbo_PracticeVal2), CompareProgress);
                }
                else if (rdPayer.Checked == true)
                {
                    listResult = NGEng.Compare(CompareType.Payer, ConnString1, ConnString2, Convert.ToString(cbo_PracticeVal1), Convert.ToString(cbo_PracticeVal2), CompareProgress);
                }
                else if (rdContract.Checked == true)
                {
                    listResult = NGEng.Compare(CompareType.Contract, ConnString1, ConnString2, Convert.ToString(cbo_PracticeVal1), Convert.ToString(cbo_PracticeVal2), CompareProgress);
                }

                //Update Column Name
                listResult.Columns[2].ColumnName = sPractices1[cbo_Practice1.SelectedIndex].Item1;
                if (sPractices1[cbo_Practice1.SelectedIndex].Item1 == sPractices1[cbo_Practice1.SelectedIndex].Item1)
                    listResult.Columns[3].ColumnName = sPractices1[cbo_Practice2.SelectedIndex].Item1 + " ";
                else
                    listResult.Columns[3].ColumnName = sPractices1[cbo_Practice2.SelectedIndex].Item1;

                CompareProgress.Value = 90;
                CompareProgress.Refresh();
                gridbox.DataSource = listResult;

                gridbox.Columns[0].Width = 200;
                gridbox.Columns[1].Width = 200;
                gridbox.Columns[2].Width = 200;
                gridbox.Columns[3].Width = 200;
                gridbox.Columns[4].Visible = false;
                gridbox.Columns[5].Visible = false;
                CompareProgress.Value = 95;
                CompareProgress.Refresh();
                FilterDatagrid();
                CompareProgress.Value = 100;
                CompareProgress.Refresh();

                CompareProgress.Visible = false;


            }
            catch (Exception errr)
            {
                MessageBox.Show(strErrMsg + " - " + errr.Message);
              //  this.Close();
            }
        }

        private void btnConnect1_Click(object sender, EventArgs e)
        {
            ShowLogin(cboDSN1);
        }

        private void btnConnect2_Click(object sender, EventArgs e)
        {
            ShowLogin(cboDSN2);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            InitiateControls();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDatagrid();
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                btnConnect_Click(sender, e);
            }

        }

        private void rdPayer_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCompareType();
        }

        private void rdEnterPrise_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCompareType();
        }

        private void rdPractice_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCompareType();
        }

        private void txtSearchdesc_TextChanged(object sender, EventArgs e)
        {
            FilterDatagrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterDatagrid();
        }

        private void ChkShowAll_CheckStateChanged(object sender, EventArgs e)
        {
            FilterDatagrid();
        }

        private void rdContract_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCompareType();
        }

        #region HealperMethods

        private void ChangeColor()
        {
            try
            {
            foreach (DataGridViewRow row in gridbox.Rows)
                if (Convert.ToInt32(row.Cells[4].Value) == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.Tomato;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
            catch (Exception errr)
            {
                MessageBox.Show(strErrMsg + " - " + errr.Message);
                this.Close();
            }
        }

        private void LoadDSN(List<string> sDSN)
        {
            try
            {
                cboDSN1.Items.Clear();
                cboDSN2.Items.Clear();
                foreach (string s in sDSN)
                {
                    cboDSN1.Items.Add(s);
                    cboDSN2.Items.Add(s);
                }
            }
            catch(Exception errr)
            {
                MessageBox.Show(strErrMsg + " - " + errr.Message);
                this.Close();
            }
        }

        private bool CheckDSN(ConnectionString ConnString)
        {
           try
            {
                DBEngine dbe = new DBEngine(ConnString);

                return dbe.DBConnect;
            }
            catch (Exception errr)
            {
                MessageBox.Show(strErrMsg + " - " + errr.Message);
                return false;
                this.Close();
            }
        }

        private void LoadCombo(List<Tuple<string, string>> sPractices, ComboBox cbo_Combo)
        {
            try
            {
                cbo_Combo.Items.Clear();

                if (sPractices1.Count == 0) sPractices1 = sPractices;
                if (sPractices2.Count == 0) sPractices2 = sPractices;

                for (int i = 0; i < sPractices.Count - 1; i++)
                {
                    cbo_Combo.Items.Add(sPractices[i].Item1);
                }
                if (cbo_Combo.Items.Count >= 0)
                    cbo_Combo.SelectedIndex = 0;
            }
            catch(Exception errr)
            {
                MessageBox.Show(strErrMsg + " - " + errr.Message);
                this.Close();
            }
        }

        private void UpdateConnectionStatus()
        {
            try
            {
                if (CheckDSN(ConnString1))
                {
                    lblCon1.Text = "Connected";
                }
                else
                {
                    lblCon1.Text = "Not Connected";
                }
            }
            catch(Exception errr)
            {
                MessageBox.Show(strErrMsg + " - " + errr.Message);
                this.Close();
            }
        }

        private void ShowLogin(ComboBox cboDSN)
        {
            try
            {
                txtUser.Text = "";
                txtPwd.Text = "";
                GrpLogin.Visible = true;
                txtUser.Focus();
                GrpLogin.Left = cboDSN.Left;
                GrpLogin.Top = cboDSN.Top+cboDSN.Height;
            }
            catch(Exception errr)
            {
                MessageBox.Show(strErrMsg + " - " + errr.Message);
                this.Close();
            }
        }

        private void FilterDatagrid()
        {
            try
            {
                string FilterCriteria = "";

                if(ChkShowAll.Checked == true)
                {
                    FilterCriteria = "Diff <> 2";
                }
                else
                {
                    FilterCriteria = "Diff = 1";
                }

                FilterCriteria = FilterCriteria + " And DBFieldName LIKE '%{0}%'";

                FilterCriteria = FilterCriteria + " And Description LIKE '%{1}%'";

                if (cboType.SelectedIndex != 0)
                {
                    FilterCriteria = FilterCriteria + " And type LIKE '%{2}%'";
                }
                if (gridbox.DataSource != null)
                {
                    listResult.DefaultView.RowFilter = string.Format(FilterCriteria, txtSearch.Text, txtSearchdesc.Text, cboType.SelectedIndex);
                }

            
                ChangeColor();
            }
            catch(Exception errr)
            {
                MessageBox.Show(strErrMsg + " - " + errr.Message);
                this.Close();
            }
        }

        private void InitiateControls()
        {
            try
            {
                cbo_Practice1.Items.Clear();
                cbo_Practice1.Text = "";
                cbo_Practice2.Items.Clear();
                cbo_Practice2.Text = "";
                cboDSN1.Text = "";
                cboDSN2.Text = "";
                listResult.Rows.Clear();
                gridbox.DataSource = null;
                ChkShowAll.Checked = false;
                lblCon1.Text="Not Connected";
                lblCon2.Text = "Not Connected";
                ConnString1.DSN = "";
                ConnString1.User= "";
                ConnString1.Pwd = "";
                ConnString2.DSN = "";
                ConnString2.User = "";
                ConnString2.Pwd = "";
                txtUser.Text = "";
                txtPwd.Text = "";
                txtSearch.Text = "";
                txtSearchdesc.Text = "";
                btnCompare.Enabled = false;
                btnConnect1.Visible = false;
                btnConnect2.Visible = false;
                CompareProgress.Visible = false;
                cboType.SelectedIndex = 0;
                LoadDSN(NGEng.GetUserDataSourceNames());
                ChangeCompareType();
            }
            catch(Exception errr)
            {
                MessageBox.Show(strErrMsg + " - " + errr.Message);
                this.Close();
            }
        }

        private void ChangeCompareType()
        {
            try
            {
                gridbox.DataSource = null;
                if (rdPractice.Checked == true)
                {
                    lbltype1.Text = "Practice 1";
                    lbltype2.Text = "Practice 2";
                    Tab_Practice.TabPages[0].Text = "Practice Pref.";
                    sPractices1.Clear();
                    sPractices2.Clear();
                    if(ConnString1.DSN != "")
                        LoadCombo(NGEng.GetComboNames(ConnString1, CompareType.Practice), cbo_Practice1);

                    if (ConnString2.DSN != "")
                        LoadCombo(NGEng.GetComboNames(ConnString2, CompareType.Practice), cbo_Practice2);
                }
                else if (rdEnterPrise.Checked == true)
                {
                    lbltype1.Text = "Enterprise 1";
                    lbltype2.Text = "Enterprise 2";
                    sPractices1.Clear();
                    sPractices2.Clear();
                    Tab_Practice.TabPages[0].Text = "Enterprise Pref.";
                    if (ConnString1.DSN != "")
                        LoadCombo(NGEng.GetComboNames(ConnString1, CompareType.Enterprise), cbo_Practice1);

                    if (ConnString2.DSN != "")
                        LoadCombo(NGEng.GetComboNames(ConnString2, CompareType.Enterprise), cbo_Practice2);
                }
                else if (rdPayer.Checked == true)
                {
                    lbltype1.Text = "Payer 1";
                    lbltype2.Text = "Payer 2";
                    sPractices1.Clear();
                    sPractices2.Clear();
                    Tab_Practice.TabPages[0].Text = "Payer";
                    if (ConnString1.DSN != "")
                        LoadCombo(NGEng.GetComboNames(ConnString1, CompareType.Payer), cbo_Practice1);

                    if (ConnString2.DSN != "")
                        LoadCombo(NGEng.GetComboNames(ConnString2, CompareType.Payer), cbo_Practice2);
                }
                else if (rdContract.Checked == true)
                {
                    lbltype1.Text = "Contract 1";
                    lbltype2.Text = "Contract 2";
                    sPractices1.Clear();
                    sPractices2.Clear();
                    Tab_Practice.TabPages[0].Text = "Contract";
                    if (ConnString1.DSN != "")
                        LoadCombo(NGEng.GetComboNames(ConnString1, CompareType.Contract), cbo_Practice1);

                    if (ConnString2.DSN != "")
                        LoadCombo(NGEng.GetComboNames(ConnString2, CompareType.Contract), cbo_Practice2);
                }
            }
            catch(Exception errr)
            {
                MessageBox.Show(strErrMsg + " - " + errr.Message);
                this.Close();
            }
        }

        private void ChangeCompareType_Connect()
        {
            try
            {
                if (rdPractice.Checked == true)
                {
                    lbltype1.Text = "Practice 1";
                    lbltype2.Text = "Practice 2";
                    sPractices1.Clear();
                    sPractices2.Clear();
                    Tab_Practice.TabPages[0].Text = "Practice Pref.";
                    if (GrpLogin.Left == cboDSN1.Left)
                    {
                        LoadCombo(NGEng.GetComboNames(ConnString1, CompareType.Practice), cbo_Practice1);
                    }
                    else if (GrpLogin.Left == cboDSN2.Left)
                    {
                        LoadCombo(NGEng.GetComboNames(ConnString2, CompareType.Practice), cbo_Practice2);
                    }
                }
                else if (rdEnterPrise.Checked == true)
                {
                    lbltype1.Text = "Enterprise 1";
                    lbltype2.Text = "Enterprise 2";
                    sPractices1.Clear();
                    sPractices2.Clear();
                    Tab_Practice.TabPages[0].Text = "Enterprise Pref.";
                    if (GrpLogin.Left == cboDSN1.Left)
                    {
                        LoadCombo(NGEng.GetComboNames(ConnString1, CompareType.Practice), cbo_Practice1);
                    }
                    else if (GrpLogin.Left == cboDSN2.Left)
                    {
                        LoadCombo(NGEng.GetComboNames(ConnString2, CompareType.Practice), cbo_Practice2);
                    }
                }
                else if (rdPayer.Checked == true)
                {
                    lbltype1.Text = "Payer 1";
                    lbltype2.Text = "Payer 2";
                    sPractices1.Clear();
                    sPractices2.Clear();
                    Tab_Practice.TabPages[0].Text = "Payer";
                    if (GrpLogin.Left == cboDSN1.Left)
                    {
                        LoadCombo(NGEng.GetComboNames(ConnString1, CompareType.Payer), cbo_Practice1);
                    }
                    else if (GrpLogin.Left == cboDSN2.Left)
                    {
                        LoadCombo(NGEng.GetComboNames(ConnString2, CompareType.Payer), cbo_Practice2);
                    }
                }
            }
            catch(Exception errr)
            {
                MessageBox.Show(strErrMsg + " - " + errr.Message);
                this.Close();
            }
        }

        #endregion HealperMethods

        private void cbo_Practice2_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridbox.DataSource = null;
        }

        private void cbo_Practice1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridbox.DataSource = null;
        }
    }
}
