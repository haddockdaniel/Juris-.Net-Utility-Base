using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;
using Gizmox.Controls;
using JDataEngine;
using JurisAuthenticator;
using JurisUtilityBase.Properties;
using System.Data.OleDb;

namespace JurisUtilityBase
{
    public partial class UtilityBaseMain : Form
    {
        #region Private  members

        private JurisUtility _jurisUtility;

        #endregion

        #region Public properties

        public string CompanyCode { get; set; }

        public string JurisDbName { get; set; }

        public string JBillsDbName { get; set; }

        public string userInit = "";

        public string allUsers = "";

        List<string> entryNumbers = new List<string>();

        private int numberOfUsers = 0;

        #endregion

        #region Constructor

        public UtilityBaseMain()
        {
            InitializeComponent();
            _jurisUtility = new JurisUtility();
        }

        #endregion

        #region Public methods

        public void LoadCompanies()
        {
            var companies = _jurisUtility.Companies.Cast<object>().Cast<Instance>().ToList();
//            listBoxCompanies.SelectedIndexChanged -= listBoxCompanies_SelectedIndexChanged;
            listBoxCompanies.ValueMember = "Code";
            listBoxCompanies.DisplayMember = "Key";
            listBoxCompanies.DataSource = companies;
//            listBoxCompanies.SelectedIndexChanged += listBoxCompanies_SelectedIndexChanged;
            var defaultCompany = companies.FirstOrDefault(c => c.Default == Instance.JurisDefaultCompany.jdcJuris);
            if (companies.Count > 0)
            {
                listBoxCompanies.SelectedItem = defaultCompany ?? companies[0];
            }
        }

        #endregion

        #region MainForm events

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listBoxCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_jurisUtility.DbOpen)
            {
                _jurisUtility.CloseDatabase();
            }
            CompanyCode = "Company" + listBoxCompanies.SelectedValue;
            _jurisUtility.SetInstance(CompanyCode);
            JurisDbName = _jurisUtility.Company.DatabaseName;
            JBillsDbName = "JBills" + _jurisUtility.Company.Code;
            _jurisUtility.OpenDatabase();
            if (_jurisUtility.DbOpen)
            {
                ///GetFieldLengths();
            }

            numberOfUsers = 0;
            string TkprIndex;
            comboBoxUser.ClearItems();
            string SQLTkpr = "select empinitials + case when len(empinitials)=1 then '     ' when len(empinitials)=2 then '     ' when len(empinitials)=3 then '   ' else '  ' end +  empname as employee from employee order by empinitials";
            DataSet myRSTkpr = _jurisUtility.RecordsetFromSQL(SQLTkpr);

            if (myRSTkpr.Tables[0].Rows.Count == 0)
                comboBoxUser.SelectedIndex = 0;
            else
            {
                comboBoxUser.Items.Add("***   All Users");
                foreach (DataTable table in myRSTkpr.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        numberOfUsers++;
                        allUsers = allUsers + dr["employee"].ToString().Split(' ')[0] + ",";
                        TkprIndex = dr["employee"].ToString();
                        comboBoxUser.Items.Add(TkprIndex);
                    }
                }
                allUsers = allUsers.TrimEnd(',');

            }

            DateTime dt = DateTime.Now;
            int currentYear = dt.Year;
            for (int a = currentYear; a > 1899; a--)
            {
                comboBoxYear.Items.Add(a.ToString());
            }
        }



        #endregion

        #region Private methods

        private void DoDaFix()
        {
            // Enter your SQL code here
            // To run a T-SQL statement with no results, int RecordsAffected = _jurisUtility.ExecuteNonQueryCommand(0, SQL);
            // To get an ADODB.Recordset, ADODB.Recordset myRS = _jurisUtility.RecordsetFromSQL(SQL);

            foreach (Control control in groupBox1.Controls)
            {
                CheckBox textBox = control as CheckBox;

                if (textBox.Checked)
                    entryNumbers.Add(textBox.Name.Replace("checkBox", ""));
            }



            if (radioButtonPriorToDate.Checked)
            {
                if (comboBoxMonth.SelectedIndex == -1 || comboBoxYear.SelectedIndex == -1)
                    MessageBox.Show("Please select an accounting period in the date boxes", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    processRange();
                    cleanUp();
                    purgeAsk();
                    MessageBox.Show("The process is complete", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else if (radioButtonPrdOnly.Checked)
            {
                if (comboBoxMonth.SelectedIndex == -1 || comboBoxYear.SelectedIndex == -1)
                    MessageBox.Show("Please select an accounting period in the date boxes", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    processDate();
                    cleanUp();
                    purgeAsk();
                    MessageBox.Show("The process is complete", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else if (radioButtonAllForUser.Checked)
            {

                processUser();
                cleanUp();
                purgeAsk();
                MessageBox.Show("The process is complete", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
                MessageBox.Show("Please select one of the Purge Folders Options", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            System.Environment.Exit(1);
        }

        private void purgeAsk()
        {
            DialogResult dr = MessageBox.Show("Process Complete! Would you like to purge the log tables as well?", "Additional Purge Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                processLogTables();
        }



        private void processRange()
        {
            int count = 1;
            foreach (string entry in entryNumbers)
            {

                //get docids for the folders associated with the user
                string SQL = "select dtdocid from DocumentTree where dtdocclass = " + entry + "  and DTDocType = 'F' and dttitle in (" + userInit.Trim() + ")";
                DataSet ds = _jurisUtility.RecordsetFromSQL(SQL);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows) //2319 smgr
                    {
                        //get the docids of the records asociated with the folder
                        string modifiedMonth = "";
                        if (comboBoxMonth.Text.ToString().Length == 1)
                            modifiedMonth = "0" + comboBoxMonth.Text.ToString();
                        SQL = "select dtdocid, dttitle from DocumentTree where dtdocclass = " + entry + "  and DTDocType = 'F' and dtparentid = " + dr[0].ToString();
                        DataSet dm = _jurisUtility.RecordsetFromSQL(SQL); //2470 2008-2
                        if (dm.Tables[0].Rows.Count > 0)
                        {
                            string removeIDS = "";
                            foreach (DataRow row in dm.Tables[0].Rows)
                            {
                                string[] items = row[1].ToString().Split('-');
                                DateTime fromDB = Convert.ToDateTime(items[1] + "/01/" + items[0]);
                                DateTime fromSelection = Convert.ToDateTime(comboBoxMonth.Text.ToString() + "/01/" + comboBoxYear.Text.ToString());
                                int result = DateTime.Compare(fromDB, fromSelection);
                                if (result < 0)
                                    removeIDS = removeIDS + row[0].ToString() + ",";
                               // SQL = "delete from DocumentTree where dtdocclass = " + entry + "  and DTDocType = 'F' and dtdocid in (" + removeIDS + ")";
                                //_jurisUtility.ExecuteNonQueryCommand(0, SQL);

                            }
                            removeIDS = removeIDS.TrimEnd(',');
                            if (!string.IsNullOrEmpty(removeIDS))
                            {
                                SQL = "delete from DocumentTree where dtdocclass = " + entry + "  and DTDocType = 'R' and dtparentid in (" + removeIDS + ")";
                                _jurisUtility.ExecuteNonQueryCommand(0, SQL);
                                SQL = "delete from DocumentTree where dtdocclass = " + entry + "  and DTDocType = 'F' and dtdocid in (" + removeIDS + ")";
                                _jurisUtility.ExecuteNonQueryCommand(0, SQL);
                            }


                        }

                    }


                }
                UpdateStatus("Updating type: " + entry, count, entryNumbers.Count);
                count++;
            }


        }

        private void processUser()
        {
            int count = 1;
            foreach (string entry in entryNumbers)
            {
                //get docids for the folders associated with the user
                string SQL = "select dtdocid from DocumentTree where dtdocclass = " + entry + "  and DTDocType = 'F' and dttitle in (" + userInit.Trim() + ")";
                DataSet ds = _jurisUtility.RecordsetFromSQL(SQL);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        //get the docids of the folders asociated with the user folder
                        SQL = "select dtdocid from DocumentTree where dtdocclass = " + entry + "  and DTDocType = 'F' and dtparentid = " + dr[0].ToString();
                        DataSet dm = _jurisUtility.RecordsetFromSQL(SQL);
                        if (dm.Tables[0].Rows.Count > 0)
                        {
                            //remove the records associated with the folders associated with the user folder
                            foreach (DataRow row in dm.Tables[0].Rows)
                            {
                                SQL = "delete from DocumentTree where dtdocclass = " + entry + "  and DTDocType = 'R' and dtparentid = " + row[0].ToString();
                                _jurisUtility.ExecuteNonQueryCommand(0, SQL);
                            }
                        }
                        SQL = "delete from DocumentTree where dtdocclass = " + entry + "  and DTDocType = 'F' and dtparentid = " + dr[0].ToString();
                        _jurisUtility.ExecuteNonQueryCommand(0, SQL);
                    }
                    
                    
                }
                UpdateStatus("Updating type: " + entry, count, entryNumbers.Count);
                count++;
            }

        }


        private void cleanUp()
        {
            userInit = "";
            entryNumbers.Clear();
            foreach (Control control in groupBox1.Controls)
            {
                CheckBox textBox = control as CheckBox;

                if (textBox.Checked)
                    textBox.Checked = false;
            }
            numberOfUsers = 0;

        }


        private void processDate()
        {
            int count = 0;
            foreach (string entry in entryNumbers)
            {

                //get docids for the folders associated with the user
                string SQL = "select dtdocid from DocumentTree where dtdocclass = " + entry + "  and DTDocType = 'F' and dttitle in (" + userInit.Trim() + ")";
                DataSet ds = _jurisUtility.RecordsetFromSQL(SQL);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows) //2319 smgr
                    {
                        //get the docids of the records asociated with the folder
                        string modifiedMonth = "";
                        if (comboBoxMonth.Text.ToString().Length == 1)
                            modifiedMonth = "0" + comboBoxMonth.Text.ToString();
                        SQL = "select dtdocid from DocumentTree where dtdocclass = " + entry + "  and DTDocType = 'F' and dtparentid = " + dr[0].ToString() + " and (dttitle = '" + comboBoxYear.Text.ToString() + "-" + comboBoxMonth.Text.ToString() + "' or dttitle = '" + comboBoxYear.Text.ToString() + "-" + modifiedMonth + "')";
                        DataSet dm = _jurisUtility.RecordsetFromSQL(SQL); //2470 2008-2
                        if (dm.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow row in dm.Tables[0].Rows)
                            {
                                SQL = "delete from DocumentTree where dtdocclass = " + entry + "  and DTDocType = 'R' and dtparentid = " + row[0].ToString();
                                _jurisUtility.ExecuteNonQueryCommand(0, SQL);
                                SQL = "delete from DocumentTree where dtdocclass = " + entry + "  and DTDocType = 'F' and dtdocid = " + row[0].ToString();
                                _jurisUtility.ExecuteNonQueryCommand(0, SQL);
                            }

                        }

                    }

                }
                UpdateStatus("Updating type: " + entry, count, entryNumbers.Count);
                count++;
            }

        }


        private void processLogTables()
        {
            String SQL = "SELECT TABLE_NAME " +
                        "FROM INFORMATION_SCHEMA.TABLES " +
                        "WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG='" + JurisDbName + "' " +
                        "and (TABLE_NAME like '%_log' and TABLE_NAME not in " +
                        "('ARBill_Log', 'ARFTaskAlloc_Log', 'ARExpAlloc_Log', 'PracticeClass_Log', 'CliOrigAtty_Log', 'MatOrigAtty_Log') " +
                        "and TABLE_NAME not like 'PreBill%')";
            DataSet dm = _jurisUtility.RecordsetFromSQL(SQL);
            foreach (DataRow table in dm.Tables[0].Rows)
            {
                SQL = "Truncate table " + table[0];
                _jurisUtility.ExecuteNonQueryCommand(0, SQL);
            }
        }



        private bool VerifyFirmName()
        {
            //    Dim SQL     As String
            //    Dim rsDB    As ADODB.Recordset
            //
            //    SQL = "SELECT CASE WHEN SpTxtValue LIKE '%firm name%' THEN 'Y' ELSE 'N' END AS Firm FROM SysParam WHERE SpName = 'FirmName'"
            //    Cmd.CommandText = SQL
            //    Set rsDB = Cmd.Execute
            //
            //    If rsDB!Firm = "Y" Then
            return true;
            //    Else
            //        VerifyFirmName = False
            //    End If

        }

        private bool FieldExistsInRS(DataSet ds, string fieldName)
        {

            foreach (DataColumn column in ds.Tables[0].Columns)
            {
                if (column.ColumnName.Equals(fieldName, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }


        private static bool IsDate(String date)
        {
            try
            {
                DateTime dt = DateTime.Parse(date);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum; 
        }

        private void WriteLog(string comment)
        {
            var sql =
                string.Format("Insert Into UtilityLog(ULTimeStamp,ULWkStaUser,ULComment) Values('{0}','{1}', '{2}')",
                    DateTime.Now, GetComputerAndUser(), comment);
            _jurisUtility.ExecuteNonQueryCommand(0, sql);
        }

        private string GetComputerAndUser()
        {
            var computerName = Environment.MachineName;
            var windowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent();
            var userName = (windowsIdentity != null) ? windowsIdentity.Name : "Unknown";
            return computerName + "/" + userName;
        }

        /// <summary>
        /// Update status bar (text to display and step number of total completed)
        /// </summary>
        /// <param name="status">status text to display</param>
        /// <param name="step">steps completed</param>
        /// <param name="steps">total steps to be done</param>
        private void UpdateStatus(string status, long step, long steps)
        {
            labelCurrentStatus.Text = status;

            if (steps == 0)
            {
                progressBar.Value = 0;
                labelPercentComplete.Text = string.Empty;
            }
            else
            {
                double pctLong = Math.Round(((double)step/steps)*100.0);
                int percentage = (int)Math.Round(pctLong, 0);
                if ((percentage < 0) || (percentage > 100))
                {
                    progressBar.Value = 0;
                    labelPercentComplete.Text = string.Empty;
                }
                else
                {
                    progressBar.Value = percentage;
                    labelPercentComplete.Text = string.Format("{0} percent complete", percentage);
                }
            }
        }

        private void DeleteLog()
        {
            string AppDir = Path.GetDirectoryName(Application.ExecutablePath);
            string filePathName = Path.Combine(AppDir, "VoucherImportLog.txt");
            if (File.Exists(filePathName + ".ark5"))
            {
                File.Delete(filePathName + ".ark5");
            }
            if (File.Exists(filePathName + ".ark4"))
            {
                File.Copy(filePathName + ".ark4", filePathName + ".ark5");
                File.Delete(filePathName + ".ark4");
            }
            if (File.Exists(filePathName + ".ark3"))
            {
                File.Copy(filePathName + ".ark3", filePathName + ".ark4");
                File.Delete(filePathName + ".ark3");
            }
            if (File.Exists(filePathName + ".ark2"))
            {
                File.Copy(filePathName + ".ark2", filePathName + ".ark3");
                File.Delete(filePathName + ".ark2");
            }
            if (File.Exists(filePathName + ".ark1"))
            {
                File.Copy(filePathName + ".ark1", filePathName + ".ark2");
                File.Delete(filePathName + ".ark1");
            }
            if (File.Exists(filePathName ))
            {
                File.Copy(filePathName, filePathName + ".ark1");
                File.Delete(filePathName);
            }

        }

            

        private void LogFile(string LogLine)
        {
            string AppDir = Path.GetDirectoryName(Application.ExecutablePath);
            string filePathName = Path.Combine(AppDir, "VoucherImportLog.txt");
            using (StreamWriter sw = File.AppendText(filePathName))
            {
                sw.WriteLine(LogLine);
            }	
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            DoDaFix();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {

            System.Environment.Exit(0);
          
        }

        private string getReportSQL()
        {
            string reportSQL = "";
            //if matter and billing timekeeper
            if (true)
                reportSQL = "select Clicode, Clireportingname, Matcode, Matreportingname,empinitials as CurrentBillingTimekeeper, 'DEF' as NewBillingTimekeeper" +
                        " from matter" +
                        " inner join client on matclinbr=clisysnbr" +
                        " inner join billto on matbillto=billtosysnbr" +
                        " inner join employee on empsysnbr=billtobillingatty" +
                        " where empinitials<>'ABC'";


            //if matter and originating timekeeper
            else if (false)
                reportSQL = "select Clicode, Clireportingname, Matcode, Matreportingname,empinitials as CurrentOriginatingTimekeeper, 'DEF' as NewOriginatingTimekeeper" +
                    " from matter" +
                    " inner join client on matclinbr=clisysnbr" +
                    " inner join matorigatty on matsysnbr=morigmat" +
                    " inner join employee on empsysnbr=morigatty" +
                    " where empinitials<>'ABC'";


            return reportSQL;
        }



        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUser.Text.StartsWith("***"))
                userInit = "'" + allUsers.Replace(",", "','") + "'";
            else
            {
                userInit = comboBoxUser.Text;
                userInit = "'" + userInit.Split(' ')[0] + "'";
                numberOfUsers = 1;
            }
        }






    }
}
