using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace DataBase_Final
{
    public partial class STDVisitorView : Form
    {
        public STDVisitorView()
        {
            InitializeComponent();
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void STDVisitorRecord_btn_Click(object sender, EventArgs e)
        {
            string connetionString = Login.ConnectionStr();
            try
            {
                string sql = "select Student_ID,relation,name,CNIC,contact,enter_time,leave_time from visitor inner join visitor_detail on visitor.VID=Visitor_detail.VD_ID WHERE STUDENT_ID = '" + Login.StudentLoginID + "'";
                OracleConnection MyConn = new OracleConnection(connetionString);
                MyConn.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    STDVisitor_grid.DataSource = dTable;
                }
                else
                {
                    MessageBox.Show("No thing to Show!", "Task Requirement!");
                }
                MyConn.Close();
            }
            catch
            {
                MessageBox.Show("Failed to Connect to Data Base", "Connection Failure!");
            }
        }
    }
}
