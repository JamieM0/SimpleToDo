namespace SimpleToDo
{
    partial class ToDo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.cbCalendar = new System.Windows.Forms.CheckBox();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.pnlItems1 = new System.Windows.Forms.Panel();
            this.pnlItems1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(501, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(239, 58);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "To Do List";
            // 
            // calendar
            // 
            this.calendar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.Location = new System.Drawing.Point(18, 453);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 1;
            // 
            // cbCalendar
            // 
            this.cbCalendar.AutoSize = true;
            this.cbCalendar.Checked = true;
            this.cbCalendar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCalendar.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCalendar.Location = new System.Drawing.Point(18, 627);
            this.cbCalendar.Name = "cbCalendar";
            this.cbCalendar.Size = new System.Drawing.Size(267, 42);
            this.cbCalendar.TabIndex = 2;
            this.cbCalendar.Text = "Enable Calendar";
            this.cbCalendar.UseVisualStyleBackColor = true;
            this.cbCalendar.CheckedChanged += new System.EventHandler(this.cbCalendar_CheckedChanged);
            this.cbCalendar.Enter += new System.EventHandler(this.cbCalendar_Enter);
            // 
            // txtEnter
            // 
            this.txtEnter.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnter.Location = new System.Drawing.Point(57, 56);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(278, 40);
            this.txtEnter.TabIndex = 3;
            this.txtEnter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEnter_KeyDown);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(11, 56);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(40, 40);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "+";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.Location = new System.Drawing.Point(23, 16);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(431, 37);
            this.cb1.TabIndex = 6;
            this.cb1.Text = "Item1 will go here when inputted.";
            this.cb1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // pnlItems1
            // 
            this.pnlItems1.Controls.Add(this.cb1);
            this.pnlItems1.Location = new System.Drawing.Point(18, 102);
            this.pnlItems1.Name = "pnlItems1";
            this.pnlItems1.Size = new System.Drawing.Size(1211, 567);
            this.pnlItems1.TabIndex = 7;
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 681);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.cbCalendar);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pnlItems1);
            this.Name = "ToDo";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.ToDo_Load);
            this.pnlItems1.ResumeLayout(false);
            this.pnlItems1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.CheckBox cbCalendar;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.Panel pnlItems1;
    }
}

