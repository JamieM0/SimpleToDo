using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleToDo
{
    public partial class ToDo : Form
    {
        public ToDo()
        {
            InitializeComponent();
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
            cb1.Text = item;
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            completedItem();
        }

        private void completedItem()
        {
            if (cb1.Checked)
            {
                cb1.ForeColor = Color.Green;
                // Strikethrough the text
                cb1.Font = new Font(cb1.Font, FontStyle.Strikeout);
            }
            else
            {
                cb1.ForeColor = Color.Black;
                // Remove the strikethrough
                cb1.Font = new Font(cb1.Font, FontStyle.Regular);
            }
        }
    }
}
