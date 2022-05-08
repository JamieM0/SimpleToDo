using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using FormSerialisation;

namespace SimpleToDo
{
    public partial class ToDo : Form
    {

        bool firstSet = false;
        bool tooManyItems = false;

        public ToDo()
        {
            InitializeComponent();
            attemptLoad();
            cbCalendar.Text = "Show Calendar";
            if (pnlItems1.Controls.OfType<CheckBox>().ToList().Count > 1 || cb1.Text != "Item1 will go here when inputted.")
            {
                firstSet = true;
                btnEnter.Enabled = false;
            }
        }

        private void cbCalendar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCalendar.Checked)
            {
                calendar.Visible = true;
                cbCalendar.Text = "Hide Calendar";
                //cbCalendar.Checked = false;
            }
            else
            {
                calendar.Visible = false;
                cbCalendar.Text = "Show Calendar";
                //cbCalendar.Checked = true;
            }
        }

        private void cbCalendar_Enter(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string item = txtEnter.Text;
            txtEnter.Text = "";
            setCheckbox(item);
        }

        private void setCheckbox(string item)
        {
            int count = pnlItems1.Controls.OfType<CheckBox>().ToList().Count;
            if (count == 1 && !firstSet)
            {
                cb1.Text = item;
                firstSet = true;
                saveAll();
            }
            else
            {
                newCheckbox(count, item);
                saveAll();
            }

            if (count > 16)
            {
                tooManyItems = true;
            }
        }

        private void newCheckbox(int count, string item)
        {
            CheckBox checkbox = new CheckBox();
            if (count < 7)
            {
                checkbox.Location = new System.Drawing.Point(23, 16 + (43 * count));
            }
            else if (count > 6 && count < 18)
            {
                checkbox.Location = new System.Drawing.Point(600, 16 + (43 * (count - 6)));
            }
            else
            {
                MessageBox.Show("Too many items!");
                tooManyItems = true;
            }
            checkbox.Size = new System.Drawing.Size(431, 37);
            checkbox.Name = "cb" + (count + 1);
            checkbox.Text = (item);
            checkbox.Font = new Font("Roboto", 20);
            checkbox.Click += new EventHandler(checkbox_Click);
            pnlItems1.Controls.Add(checkbox);
            if (tooManyItems)
            {
                btnEnter.Enabled = false;
            }
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            completedItem("cb1");
        }

        private void checkbox_Click(object sender, EventArgs e)
        {
            string name = ((CheckBox)sender).Name;
            completedItem(name);
        }

        private void completedItem(string name)
        {
            //Change name to variable name
            CheckBox checkbox = (CheckBox)pnlItems1.Controls[name];

            if (checkbox.Checked)
            {
                checkbox.ForeColor = Color.Green;
                // Strikethrough the text
                checkbox.Font = new Font(cb1.Font, FontStyle.Strikeout);
            }
            else
            {
                checkbox.ForeColor = Color.Black;
                // Remove the strikethrough
                checkbox.Font = new Font(cb1.Font, FontStyle.Regular);
            }

            saveAll();
        }

        private void ToDo_Load(object sender, EventArgs e)
        {

        }

        private void txtEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter.PerformClick();
            }
            else
            {

            }
        }

        private void saveAll()
        {
            //Save all checkbox text datas to todo.txt
            string todo = "";
            foreach (CheckBox checkbox in pnlItems1.Controls.OfType<CheckBox>())
            {
                todo += checkbox.Text + "~" + checkbox.Font + "~" + checkbox.Checked + "~" + "\n";
            }
            File.WriteAllText("todo.txt", todo);
        }

        private void attemptLoad()
        {
            int lineNumberData = 0;

            if (!File.Exists("todo.txt"))
            {
                File.Create("todo.txt").Close();
            }
            else
            {
                //Load all checkbox text datas from todo.txt
                string todo = File.ReadAllText("todo.txt");
                string[] lines = todo.Split('\n');
                foreach (string line in lines)
                {
                    string[] data = line.Split('~');
                    if (data[0] != "")
                    {
                        if (lineNumberData == 0)
                        {
                            cb1.Text = data[0];
                            cb1.Font = new Font("Roboto", 20);
                            cb1.Checked = Convert.ToBoolean(data[2]);
                        }
                        else
                        {
                            CheckBox checkbox = new CheckBox();
                            if (lineNumberData < 7)
                            {
                                checkbox.Location = new System.Drawing.Point(23, 16 + (43 * lineNumberData));
                            }
                            else if (lineNumberData > 6 && lineNumberData < 18)
                            {
                                checkbox.Location = new System.Drawing.Point(600, 16 + (43 * (lineNumberData - 6)));
                            }
                            else
                            {
                                MessageBox.Show("Too many items!");
                                tooManyItems = true;
                            }
                            checkbox.Size = new System.Drawing.Size(431, 37);
                            checkbox.Name = "cb" + (lineNumberData);
                            checkbox.Text = (data[0]);
                            checkbox.Font = new Font("Roboto", 20);
                            checkbox.Click += new EventHandler(checkbox_Click);
                            checkbox.Checked = Convert.ToBoolean(data[2]);
                            pnlItems1.Controls.Add(checkbox);
                        }
                        checkStyleCheckbox();
                    }
                    lineNumberData++;
                }
            }
        }

        private void checkStyleCheckbox()
        {
            foreach (CheckBox checkbox in pnlItems1.Controls.OfType<CheckBox>())
            {
                if (checkbox.Checked)
                {
                    checkbox.ForeColor = Color.Green;
                    // Strikethrough the text
                    checkbox.Font = new Font(cb1.Font, FontStyle.Strikeout);
                }
            }   
        }
    }
}
