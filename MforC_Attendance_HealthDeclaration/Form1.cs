using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MforC_Attendance_HealthDeclaration
{
    public partial class Form1 : Form
    {
        NpgsqlDataAdapter adapter;
        string conn_string = "Server =localhost;Port=5432;Database=DB_Cohar;User Id = postgres;Password=admin";
        NpgsqlConnection conn;
        long student_id;
        bool flagSelect = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (TestDBConnection(conn_string))
            {
                try
                {
                    

                    using (conn = new NpgsqlConnection(conn_string))
                    {
                        conn.Open();

                        //NpgsqlCommand command = new NpgsqlCommand("sp_students_for_attendance_healthDeclaration()", conn);
                        //command.CommandType = System.Data.CommandType.StoredProcedure; // this is default
                        adapter = new NpgsqlDataAdapter("SELECT id,first_name,last_name,teacher FROM students", conn);
                        DataTable tb = new DataTable();
                        adapter.Fill(tb);
                        dgvStudents.DataSource = tb;
                        //adapter = new NpgsqlDataAdapter($"SELECT student_id,day,attendance,health_declaration,remark from attendance_declaration ad Join students s on ad.student_id = s.id WHERE ad.student_id = (select id from students limit 1)",conn);


                        //используя AddRange мы можем сразу передать СП полученый массив параметров
                        //command.Parameters.AddRange(parameters);

                       /* var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Dictionary<string, object> one_row = new Dictionary<string, object>();
                            foreach (var item in reader.GetColumnSchema())
                            {
                                object column_value = reader[item.ColumnName];
                                one_row.Add(item.ColumnName, column_value);
                                switch (item.ColumnName)
                                {
                                    case "_id": cmbId.Items.Add(column_value.ToString()); break;
                                    case "_first_name": cmbName.Items.Add(column_value.ToString()); break;
                                    case "_last_name": cmbLastName.Items.Add(column_value.ToString()); break;
                                }
                            }
                            items.Add(one_row);
                        }*/
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex}");
                    //Console.WriteLine($"Function {sp_name} failed. parameters: {string.Join(",", parameters.Select(_ => _.ParameterName + " : " + _.Value))}");
                }


            }

            else
            {
                Console.WriteLine("Connection failed!!!");
                Console.ReadKey();
            }

        }

        bool TestDBConnection(string conn_string)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(conn_string))
                {
                    conn.Open();
                }
                return true;
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        private void rdbAttendanceFull_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbAttendanceFull.Checked )
            {
                if (flagSelect)
                {
                    using (conn = new NpgsqlConnection(conn_string))
                    {
                        conn.Open();
                        string picker = dateTimePicker1.Value.ToShortDateString().ToString();
                        adapter = new NpgsqlDataAdapter($"Insert INTO attendance_declaration( student_id,day,attendance,health_declaration,remark) VALUES({student_id}, {picker}, true, true,{txtRemark.Text})", conn);
                        UpdateTableInDataGrid();
                        flagSelect = false;
                    }
                }
                   
                rdbAttendanceFull.Checked = false;
            }

        }

        private void rdbAttendance_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAttendance.Checked)
            {
                if (flagSelect)
                {
                    using (conn = new NpgsqlConnection(conn_string))
                    {
                        conn.Open();
                        adapter = new NpgsqlDataAdapter($"Insert INTO attendance_declaration VALUES({student_id}, {dateTimePicker1.Value.ToShortDateString()}, true, false,{txtRemark.Text})", conn);
                        UpdateTableInDataGrid();
                        flagSelect = false;
                    }
                } 
                else
                    rdbAttendanceFull.Checked = false;
            }
        }

        private void rdbNoAttendance_CheckedChanged(object sender, EventArgs e)
        {

            if (flagSelect)
            {
                using (conn = new NpgsqlConnection(conn_string))
                {
                    conn.Open();
                    adapter = new NpgsqlDataAdapter($"Insert INTO attendance_declaration VALUES({student_id}, {dateTimePicker1.Value.ToShortDateString()}, false, false,{txtRemark.Text})", conn);
                    UpdateTableInDataGrid();
                    flagSelect = false;
                }
            }
                
            else
                rdbAttendanceFull.Checked = false;
        }
        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rdbAttendance.Checked = false;
            rdbAttendanceFull.Checked = false;
            rdbNoAttendance.Checked = false;
            flagSelect = true;
            student_id = (long) dgvStudents.Rows[e.RowIndex].Cells["id"].Value;
        }

        private void UpdateTableInDataGrid()
        {
            using (conn = new NpgsqlConnection(conn_string))
            {
                conn.Open();
                string picker = dateTimePicker1.Value.ToShortDateString().ToString();
                adapter = new NpgsqlDataAdapter($"SELECT id,day,attendance,health_declaration,remark from attendance_declaration WHERE day = '10/03/21'", conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dgvA_HD.DataSource = tb;
            }
            
        }
        
    }
    
}
