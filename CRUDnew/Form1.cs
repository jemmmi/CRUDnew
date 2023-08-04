using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRUDnew
{
    public partial class FormEmployee : Form
    {
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        string Staff_id = "";
        string conString = "Data Source=DESKTOP-163LJK7\\MICTCO;Initial Catalog=CRUD;Integrated Security=True";
        public FormEmployee()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            datagv.AutoGenerateColumns = false;
            datagv.DataSource = FetchStaffDetails();
            FetchStaffDetails();
        }
        private DataTable FetchStaffDetails()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            sqlCmd = new SqlCommand("spStaff", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ActionType", "FetchData");
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            sqlSda.Fill(dtData);
            //if(dtData.Rows.Count>0)
            //{
            //    for(int i=0; i <= dtData.Rows.Count - 1; i++) 
            //    {
            //        if (dtData.Rows.Count >= datagv.Rows.Count)
            //        {
            //            datagv.Rows.Add();
            //        }

            //        datagv.Rows[i].Cells["StaffId"].Value = dtData.Rows[i]["Staff_id"].ToString();
            //        datagv.Rows[i].Cells["name"].Value = dtData.Rows[i]["Name"].ToString();
            //        datagv.Rows[i].Cells["city"].Value = dtData.Rows[i]["City"].ToString();
            //        datagv.Rows[i].Cells["department"].Value = dtData.Rows[i]["Department"].ToString();
            //        datagv.Rows[i].Cells["gender"].Value = dtData.Rows[i]["Gender"].ToString();
            //    }
            //}
            return dtData;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_name.Text))
            {
                MessageBox.Show("Enter Employee Name");
                tb_name.Select();
            }
            else if (string.IsNullOrWhiteSpace(tb_city.Text))
            {
                MessageBox.Show("Enter Current City");
                tb_city.Select();
            }
            else if (string.IsNullOrWhiteSpace(tb_dept.Text))
            {
                MessageBox.Show("Enter Department");
                tb_dept.Select();
            }
            else if (cb_gender.SelectedIndex <= -1)
            {
                MessageBox.Show("Select Gender");
                cb_gender.Select();
            }
            else if (string.IsNullOrWhiteSpace(tb_ph.Text))
            {
                MessageBox.Show("Enter PhoneNo");
            }
            else
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    string actionType = "";
                    actionType = btn_save.Text == "Save" ? "SaveData" : "UpdateData";
                    DataTable dtData = new DataTable();
                    sqlCmd = new SqlCommand("spStaff", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ActionType", "SaveData");
                    sqlCmd.Parameters.AddWithValue("@Staff_id", Staff_id);
                    sqlCmd.Parameters.AddWithValue("@Name", tb_name.Text);
                    sqlCmd.Parameters.AddWithValue("@City", tb_city.Text);
                    sqlCmd.Parameters.AddWithValue("@Department", tb_dept.Text);
                    sqlCmd.Parameters.AddWithValue("@Gender", cb_gender.Text);
                    sqlCmd.Parameters.AddWithValue("@PhoneNo", tb_ph.Text);
                    int numRes = sqlCmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Successfully Entered");
                        ClearAllData();
                    }
                    else
                        MessageBox.Show("Enter Again");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error:-" + ex.Message);
                }
            }
        }

        private void datagv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_save.Text = "Update";
                Staff_id = datagv.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataTable dtData = FetchStaffRecords(Staff_id);
                if (dtData.Rows.Count > 0)
                {
                    Staff_id = dtData.Rows[0][0].ToString();
                    tb_name.Text = dtData.Rows[0][1].ToString();
                    tb_city.Text = dtData.Rows[0][2].ToString();
                    tb_dept.Text = dtData.Rows[0][3].ToString();
                    cb_gender.Text = dtData.Rows[0][4].ToString().Trim();
                    tb_ph.Text = dtData.Rows[0][5].ToString();
                }
                else
                {
                    ClearAllData();
                }
            }
        }
        private DataTable FetchStaffRecords(string Staff_id)
        {

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            sqlCmd = new SqlCommand("spStaff", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ActionType", "FetchRecord");
            sqlCmd.Parameters.AddWithValue("@Staff_id", Staff_id);
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            sqlSda.Fill(dtData);
            return dtData;
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Staff_id))
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    DataTable dtData = new DataTable();
                    sqlCmd = new SqlCommand("spStaff", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ActionType", "DeleteData");
                    sqlCmd.Parameters.AddWithValue("@Staff_id", Staff_id);
                    int numRes = sqlCmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully");
                        ClearAllData();
                    }
                    else
                    {
                        MessageBox.Show("Pls try again");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error:-" + ex.Message);
                }
            else
            {
                MessageBox.Show("Please Select A Record !!!");
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }
        public void ClearAllData()
        {
            btn_save.Text = "Save";
            tb_name.Text = "";
            tb_city.Text = "";
            tb_dept.Text = "";
            cb_gender.SelectedIndex = -1;
            tb_ph.Text = "";
            Staff_id = "";
            FetchStaffDetails();
            datagv.DataSource = null;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand cmd = new SqlCommand("display", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dtData = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dtData);
            datagv.AutoGenerateColumns = true;
            //dtData.Load(cmd.ExecuteReader());
            datagv.DataSource = dtData;

            sqlCon.Close();
            //if (dtData.Rows.Count > 0)
            //{
            //    for (int i = 0; i <= dtData.Rows.Count - 1; i++)
            //    {
            //        if (dtData.Rows.Count >= datagv.Rows.Count)
            //        {
            //            datagv.Rows[i].Cells["StaffId"].Value = dtData.Rows[i]["Staff_id"].ToString();
            //            datagv.Rows[i].Cells["name"].Value = dtData.Rows[i]["Name"].ToString();
            //            datagv.Rows[i].Cells["city"].Value = dtData.Rows[i]["City"].ToString();
            //            datagv.Rows[i].Cells["department"].Value = dtData.Rows[i]["Department"].ToString();
            //            datagv.Rows[i].Cells["gender"].Value = dtData.Rows[i]["Gender"].ToString();
            //            datagv.Rows[i].Cells["phone"].Value = dtData.Rows[i]["PhoneNo"].ToString();
            //        }
            //    }
            //}

        }

        private void tb_name_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlConnection connection = new SqlConnection(conString);
                SqlDataAdapter adap = new SqlDataAdapter("select * from tblStaff", sqlCon);
                DataTable dtData = new DataTable();
                adap.Fill(dtData);

                for (int i = 0; i < dtData.Rows.Count; i++)
                {
                    if (tb_name.Text == dtData.Rows[i]["Name"].ToString())
                    {
                        MessageBox.Show("duplicate value");
                        return;
                    }
                    else
                    {
                        tb_city.Focus();
                    }
                }
            }
        }
        private void tb_city_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_dept.Focus();
            }
        }

        private void tb_dept_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cb_gender.Focus();
            }
        }

        private void cb_gender_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_ph.Focus();
            }
        }

        private void tb_ph_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlConnection connection = new SqlConnection(conString);
                SqlDataAdapter adap = new SqlDataAdapter("select * from tblStaff", sqlCon);
                DataTable dtData = new DataTable();
                adap.Fill(dtData);
                //Regex phoneNumpattern = new Regex(@"\+[0-9]{3}\s+[0-9]{3}\s+[0-9]{5}\s+[0-9]{3}");
                //if (phoneNumpattern.IsMatch(tb_ph.Text))
                //{
                //}
                //else
                //{
                //    MessageBox.Show("Invalid Format");
                //}
                for (int i = 0; i < dtData.Rows.Count; i++)
                {
                    if (tb_ph.Text == dtData.Rows[i]["PhoneNo"].ToString() && tb_name.Text ==dtData.Rows[i]["Name"].ToString())
                    {
                        MessageBox.Show("Number already EXIST");
                        return;
                    }
                    else
                    {
                        btn_save.Focus();
                    }
                }
            }
        }
    }
}