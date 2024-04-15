using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AIS_Students
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        public class StringItemWithOldID
        {
            public int OldID;
            public string text;
            public override string ToString()
            {
                return this.text;
            }
        }

        private void buttonGroupCreateAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите создать новый заказ используя введенные данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO groups (Class, `Group`, Faculty) VALUES (@class, @group, @faculty)", conn);
                cmd.Parameters.AddWithValue("class", textBoxGroupClassAdmin.Text);
                cmd.Parameters.AddWithValue("group", textBoxGroupNameAdmin.Text);
                cmd.Parameters.AddWithValue("faculty", textBoxGroupFacultyAdmin.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                buttonGroupAdmin.PerformClick();
            }
        }

        private void buttonGroupAdmin_Click(object sender, EventArgs e)
        {
            panelGroupAdmin.Visible = true;
            panelServicesAdministrator.Visible = false;
            panelStudentAdmin.Visible = false;
            panelWorkersAdministrator.Visible = false;
            panelAuthorizationAdministrator.Visible = false;
            textBoxGroupNameAdmin.Text = "";
            textBoxGroupFacultyAdmin.Text = "";
            textBoxGroupClassAdmin.Text = "";
            MySqlConnection conn = DBUtils.GetDBConnection();
            using (MySqlCommand cmd = new MySqlCommand("SELECT ID_Group, `Group`, Faculty, Class FROM groups", conn))
            {
                cmd.CommandType = CommandType.Text;
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dataGridViewGroupAdmin.DataSource = dt;
                        dataGridViewGroupAdmin.Columns[0].Visible = false;
                    }
                }
            }

        }

        private void buttonGroupDeleteAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить выбранный заказ?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM groups WHERE ID_Group = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("id", Convert.ToString(dataGridViewGroupAdmin.CurrentRow.Cells[0].Value));
                cmd.ExecuteNonQuery();
                buttonGroupAdmin.PerformClick();
            }
        }

        private void buttonStudentsAdmin_Click(object sender, EventArgs e)
        {
            panelGroupAdmin.Visible = false;
            panelStudentAdmin.Visible = true;
            textBoxStudentNameAdmin.Text = "";
            checkedListBoxGroupStudentAdmin.Items.Clear();
            MySqlConnection conn = DBUtils.GetDBConnection();
            using (MySqlCommand cmd = new MySqlCommand("SELECT ID_Group,CONCAT(Faculty,'-',`Group`) FROM groups", conn))
            {
                cmd.CommandType = CommandType.Text;
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            checkedListBoxGroupStudentAdmin.Items.Add(new StringItemWithOldID()
                            {
                                OldID = Convert.ToInt16(row[0]),
                                text = Convert.ToString(row[1])
                            });
                        }
                    }
                }
            }
            using (MySqlCommand cmd = new MySqlCommand("SELECT ID_Student, FIO as `ФИО студента`, CONCAT(Faculty,'-',`Group`) as `Группа`\r\nFROM students\r\nJOIN groups ON students.ID_Group = groups.ID_Group;", conn))
            {
                cmd.CommandType = CommandType.Text;
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dataGridViewStudentAdmin.DataSource = dt;
                        dataGridViewStudentAdmin.Columns[0].Visible = false;
                    }
                }
            }

        }

        private void dataGridViewStudentAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (int i in checkedListBoxGroupStudentAdmin.CheckedIndices)
            {
                checkedListBoxGroupStudentAdmin.SetItemCheckState(i, CheckState.Unchecked);
            }
            if (Convert.ToString(dataGridViewStudentAdmin.CurrentRow.Cells[0].Value) != "")
            {
                
                textBoxStudentNameAdmin.Text = Convert.ToString(dataGridViewStudentAdmin.CurrentRow.Cells[1].Value);
                for(int i = 0; i < checkedListBoxGroupStudentAdmin.Items.Count; i++)
                {
                    if (Convert.ToString(dataGridViewStudentAdmin.CurrentRow.Cells[2].Value) == Convert.ToString(checkedListBoxGroupStudentAdmin.Items[i]))
                    {
                        checkedListBoxGroupStudentAdmin.SetItemChecked(i, true);
                    }
                }
            }
        }
    }
}
