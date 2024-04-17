using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AIS_Students.FormAdmin;

namespace AIS_Students
{
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }

        private void buttonOrdersAdministrator_Click(object sender, EventArgs e)
        {
            panelMarkTeacher.Visible = true;
            panelAssignTeacher.Visible = false;
            textBoxMarkMarkTeacher.Text = "";
            dateTimePickerMarkTeacher.Value = DateTime.Today;
            checkedListBoxMarkSubjectTeacher.Items.Clear();
            checkedListBoxMarkAssignTeacher.Items.Clear();
            checkedListBoxMarkStudentTeacher.Items.Clear();
            MySqlConnection conn = DBUtils.GetDBConnection();
            using (MySqlCommand cmd = new MySqlCommand("SELECT ID_Subject,Name FROM subjects", conn))
            {
                cmd.CommandType = CommandType.Text;
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            checkedListBoxMarkSubjectTeacher.Items.Add(new StringItemWithOldID()
                            {
                                OldID = Convert.ToInt16(row[0]),
                                text = Convert.ToString(row[1])
                            });
                        }
                    }
                }
            }
            using (MySqlCommand cmd = new MySqlCommand("SELECT ID_Assign,Name FROM assignments", conn))
            {
                cmd.CommandType = CommandType.Text;
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            checkedListBoxMarkAssignTeacher.Items.Add(new StringItemWithOldID()
                            {
                                OldID = Convert.ToInt16(row[0]),
                                text = Convert.ToString(row[1])
                            });
                        }
                    }
                }
            }
            using (MySqlCommand cmd = new MySqlCommand("SELECT ID_Student, FIO FROM students.students",conn))
            {
                cmd.CommandType = CommandType.Text;
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            checkedListBoxMarkStudentTeacher.Items.Add(new StringItemWithOldID()
                            {
                                OldID = Convert.ToInt16(row[0]),
                                text = Convert.ToString(row[1])
                            });
                        }
                    }
                }
            }
            using (MySqlCommand cmd = new MySqlCommand("SELECT\r\n  `student-assign`.ID,\r\n  `student-assign`.ID_Student,\r\n  `student-assign`.ID_Assign,\r\n\tsubjects.`Name` AS 'Предмет',\r\n  assignments.`Name` AS 'Работа',\r\n\tstudents.FIO AS 'ФИО',\r\n  `student-assign`.Mark AS 'Оценка',\r\n  `student-assign`.Date AS 'Дата сдачи'\t\r\nFROM\r\n  `student-assign`\r\nJOIN\r\n  students ON `student-assign`.ID_Student = students.ID_Student\r\nJOIN\r\n  assignments ON `student-assign`.ID_Assign = assignments.ID_Assign\r\nJOIN\r\n  subjects ON assignments.ID_Subject = subjects.ID_Subject;", conn))
            {
                cmd.CommandType = CommandType.Text;
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dataGridViewMarkTeacher.DataSource = dt;
                        dataGridViewMarkTeacher.Columns[0].Visible = false;
                        dataGridViewMarkTeacher.Columns[1].Visible = false;
                        dataGridViewMarkTeacher.Columns[2].Visible = false;
                    }
                }
            }
        }

        private void FormTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void dataGridViewOrdersAdministrator_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (int i in checkedListBoxMarkSubjectTeacher.CheckedIndices)
            {
                checkedListBoxMarkSubjectTeacher.SetItemCheckState(i, CheckState.Unchecked);
            }
            foreach (int i in checkedListBoxMarkAssignTeacher.CheckedIndices)
            {
                checkedListBoxMarkAssignTeacher.SetItemCheckState(i, CheckState.Unchecked);
            }
            if (Convert.ToString(dataGridViewMarkTeacher.CurrentRow.Cells[0].Value) != "")
            {
                textBoxMarkMarkTeacher.Text = Convert.ToString(dataGridViewMarkTeacher.CurrentRow.Cells[6].Value);
                dateTimePickerMarkTeacher.Value = Convert.ToDateTime(dataGridViewMarkTeacher.CurrentRow.Cells[7].Value);
                MySqlConnection conn = DBUtils.GetDBConnection();
                for (int i = 0; i < checkedListBoxMarkSubjectTeacher.Items.Count; i++)
                {
                    if (Convert.ToString(dataGridViewMarkTeacher.CurrentRow.Cells[3].Value) == Convert.ToString(checkedListBoxMarkSubjectTeacher.Items[i]))
                    {
                        checkedListBoxMarkSubjectTeacher.SetItemChecked(i, true);
                    }
                }
                for (int i = 0; i < checkedListBoxMarkAssignTeacher.Items.Count; i++)
                {
                    if (Convert.ToString(dataGridViewMarkTeacher.CurrentRow.Cells[4].Value) == Convert.ToString(checkedListBoxMarkAssignTeacher.Items[i]))
                    {
                        checkedListBoxMarkAssignTeacher.SetItemChecked(i, true);
                    }
                }
                for (int i = 0; i < checkedListBoxMarkStudentTeacher.Items.Count; i++)
                {
                    if (Convert.ToString(dataGridViewMarkTeacher.CurrentRow.Cells[5].Value) == Convert.ToString(checkedListBoxMarkStudentTeacher.Items[i]))
                    {
                        checkedListBoxMarkStudentTeacher.SetItemChecked(i, true);
                    }
                }
            }
            else
            {
                textBoxMarkMarkTeacher.Text = "";
                dateTimePickerMarkTeacher.Value = DateTime.Today;
                checkedListBoxMarkSubjectTeacher.ClearSelected();
                foreach (int i in checkedListBoxMarkSubjectTeacher.CheckedIndices)
                {
                    checkedListBoxMarkSubjectTeacher.SetItemCheckState(i, CheckState.Unchecked);
                }
                checkedListBoxMarkAssignTeacher.ClearSelected();
                foreach (int i in checkedListBoxMarkAssignTeacher.CheckedIndices)
                {
                    checkedListBoxMarkAssignTeacher.SetItemCheckState(i, CheckState.Unchecked);
                }
                checkedListBoxMarkStudentTeacher.ClearSelected();
                foreach (int i in checkedListBoxMarkStudentTeacher.CheckedIndices)
                {
                    checkedListBoxMarkStudentTeacher.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void buttonOrdersCreateAdministrator_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить введенные данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `student-assign` (`ID_Student`, `ID_Assign`, `Mark`, `Date`) VALUES (@student, @assign, @mark, @date)", conn);
                foreach (StringItemWithOldID item in checkedListBoxMarkStudentTeacher.CheckedItems)
                {
                    cmd.Parameters.AddWithValue("student", item.OldID.ToString());
                }
                foreach (StringItemWithOldID item in checkedListBoxMarkAssignTeacher.CheckedItems)
                {
                    cmd.Parameters.AddWithValue("assign", item.OldID.ToString());
                }
                cmd.Parameters.AddWithValue("mark", textBoxMarkMarkTeacher.Text);
                cmd.Parameters.AddWithValue("date", dateTimePickerMarkTeacher.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                buttonMarksTeacher.PerformClick();
            }
        }

        private void buttonOrdersDeleteAdministrator_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить выбранную запись из списка?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `student-assign` WHERE ID = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("id", Convert.ToString(dataGridViewMarkTeacher.CurrentRow.Cells[0].Value));
                cmd.ExecuteNonQuery();
                buttonMarksTeacher.PerformClick();
            }
        }

        private void checkedListBoxOrdersServicesAdministrator_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < checkedListBoxMarkSubjectTeacher.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBoxMarkSubjectTeacher.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < checkedListBoxMarkAssignTeacher.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBoxMarkAssignTeacher.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < checkedListBoxMarkStudentTeacher.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBoxMarkStudentTeacher.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void buttonAssignsTeacher_Click(object sender, EventArgs e)
        {
            panelAssignTeacher.Visible = true;
            panelMarkTeacher.Visible = false;
            textBoxAssignNameTeacher.Text = "";
            textBoxAssignMaxMarkTeacher.Text = "";
            checkedListBoxAssignSubjectTeacher.Items.Clear();
            MySqlConnection conn = DBUtils.GetDBConnection();
            using (MySqlCommand cmd = new MySqlCommand("SELECT ID_Subject,Name FROM subjects", conn))
            {
                cmd.CommandType = CommandType.Text;
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            checkedListBoxAssignSubjectTeacher.Items.Add(new StringItemWithOldID()
                            {
                                OldID = Convert.ToInt16(row[0]),
                                text = Convert.ToString(row[1])
                            });
                        }
                    }
                }
            }
            using (MySqlCommand cmd = new MySqlCommand("SELECT \r\n    a.ID_Assign, \r\n    a.Name AS 'Работа', \r\n    a.MAX_Mark 'Максимум баллов', \r\n    a.ID_Subject, \r\n    s.Name AS 'Предмет'\r\nFROM \r\n    assignments a\r\n        JOIN \r\n    subjects s ON a.ID_Subject = s.ID_Subject;", conn))
            {
                cmd.CommandType = CommandType.Text;
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dataGridViewAssignTeacher.DataSource = dt;
                        dataGridViewAssignTeacher.Columns[0].Visible = false;
                        dataGridViewAssignTeacher.Columns[3].Visible = false;
                    }
                }
            }
        }

        private void dataGridViewAssignTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (int i in checkedListBoxAssignSubjectTeacher.CheckedIndices)
            {
                checkedListBoxAssignSubjectTeacher.SetItemCheckState(i, CheckState.Unchecked);
            }
            if (Convert.ToString(dataGridViewAssignTeacher.CurrentRow.Cells[0].Value) != "")
            {
                textBoxAssignNameTeacher.Text = Convert.ToString(dataGridViewAssignTeacher.CurrentRow.Cells[1].Value);
                textBoxAssignMaxMarkTeacher.Text = Convert.ToString(dataGridViewAssignTeacher.CurrentRow.Cells[2].Value);
                for (int i = 0; i < checkedListBoxAssignSubjectTeacher.Items.Count; i++)
                {
                    if (Convert.ToString(dataGridViewAssignTeacher.CurrentRow.Cells[4].Value) == Convert.ToString(checkedListBoxAssignSubjectTeacher.Items[i]))
                    {
                        checkedListBoxAssignSubjectTeacher.SetItemChecked(i, true);
                    }
                }
            }
            else
            {
                textBoxMarkMarkTeacher.Text = "";
                dateTimePickerMarkTeacher.Value = DateTime.Today;
                checkedListBoxAssignSubjectTeacher.ClearSelected();
                foreach (int i in checkedListBoxAssignSubjectTeacher.CheckedIndices)
                {
                    checkedListBoxAssignSubjectTeacher.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void buttonAssignAddTeacher_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить работу?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `assignments` (`Name`, `MAX_Mark`, `ID_Subject`) VALUES (@name, @mark, @subject)", conn);
                cmd.Parameters.AddWithValue("name", textBoxAssignNameTeacher.Text);
                cmd.Parameters.AddWithValue("mark", textBoxAssignMaxMarkTeacher.Text);
                foreach (StringItemWithOldID item in checkedListBoxAssignSubjectTeacher.CheckedItems)
                {
                    cmd.Parameters.AddWithValue("subject", item.OldID.ToString());
                }
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                buttonAssignsTeacher.PerformClick();
            }
        }

        private void buttonAssignDeleteTeacher_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить выбранную работу из списка?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `assignments` WHERE ID_Assign = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("id", Convert.ToString(dataGridViewAssignTeacher.CurrentRow.Cells[0].Value));
                cmd.ExecuteNonQuery();
                buttonAssignsTeacher.PerformClick();
            }
        }
    }
}
