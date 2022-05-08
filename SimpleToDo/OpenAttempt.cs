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

namespace SimpleToDo
{
    public partial class OpenAttempt : Form
    {
        public OpenAttempt()
        {
            InitializeComponent();
        }

        private void OpenAttempt_Load(object sender, EventArgs e)
        {
            if (File.Exists("todo.txt"))
            {
                StreamReader sr = new StreamReader("todo.txt");
            }
            else
            {
                //Create todo.txt new file
                File.Create("todo.txt");
                
            }
        }
    }
}
