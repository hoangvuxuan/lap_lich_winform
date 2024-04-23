namespace lap_lich
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            nup_notifiy = new NumericUpDown();
            CB_notify = new CheckBox();
            bt_today = new Button();
            dtp_day = new DateTimePicker();
            panel2 = new Panel();
            p_matrix = new Panel();
            panel4 = new Panel();
            bt_next = new Button();
            bt_pre = new Button();
            bt_Sunday = new Button();
            bt_saturday = new Button();
            bt_Friday = new Button();
            bt_thursday = new Button();
            bt_wednesday = new Button();
            bt_tuesday = new Button();
            bt_monday = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nup_notifiy).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 549);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(nup_notifiy);
            panel3.Controls.Add(CB_notify);
            panel3.Controls.Add(bt_today);
            panel3.Controls.Add(dtp_day);
            panel3.Location = new Point(5, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(920, 60);
            panel3.TabIndex = 1;
            // 
            // nup_notifiy
            // 
            nup_notifiy.Location = new Point(81, 17);
            nup_notifiy.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            nup_notifiy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nup_notifiy.Name = "nup_notifiy";
            nup_notifiy.Size = new Size(50, 27);
            nup_notifiy.TabIndex = 3;
            nup_notifiy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CB_notify
            // 
            CB_notify.AutoSize = true;
            CB_notify.Location = new Point(3, 18);
            CB_notify.Name = "CB_notify";
            CB_notify.Size = new Size(72, 24);
            CB_notify.TabIndex = 2;
            CB_notify.Text = "Notify";
            CB_notify.UseVisualStyleBackColor = true;
            // 
            // bt_today
            // 
            bt_today.Location = new Point(668, 12);
            bt_today.Name = "bt_today";
            bt_today.Size = new Size(102, 34);
            bt_today.TabIndex = 1;
            bt_today.Text = "today";
            bt_today.UseVisualStyleBackColor = true;
            bt_today.Click += bt_today_Click;
            // 
            // dtp_day
            // 
            dtp_day.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_day.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_day.Location = new Point(328, 12);
            dtp_day.Name = "dtp_day";
            dtp_day.Size = new Size(334, 34);
            dtp_day.TabIndex = 0;
            dtp_day.ValueChanged += dtp_day_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(p_matrix);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(3, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(923, 477);
            panel2.TabIndex = 0;
            // 
            // p_matrix
            // 
            p_matrix.Location = new Point(112, 83);
            p_matrix.Name = "p_matrix";
            p_matrix.Size = new Size(701, 391);
            p_matrix.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(bt_next);
            panel4.Controls.Add(bt_pre);
            panel4.Controls.Add(bt_Sunday);
            panel4.Controls.Add(bt_saturday);
            panel4.Controls.Add(bt_Friday);
            panel4.Controls.Add(bt_thursday);
            panel4.Controls.Add(bt_wednesday);
            panel4.Controls.Add(bt_tuesday);
            panel4.Controls.Add(bt_monday);
            panel4.Location = new Point(9, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(908, 71);
            panel4.TabIndex = 0;
            // 
            // bt_next
            // 
            bt_next.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_next.Location = new Point(810, 3);
            bt_next.Name = "bt_next";
            bt_next.Size = new Size(68, 59);
            bt_next.TabIndex = 3;
            bt_next.Text = ">>";
            bt_next.UseVisualStyleBackColor = true;
            bt_next.Click += bt_next_Click;
            // 
            // bt_pre
            // 
            bt_pre.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_pre.Location = new Point(29, 3);
            bt_pre.Name = "bt_pre";
            bt_pre.Size = new Size(68, 59);
            bt_pre.TabIndex = 2;
            bt_pre.Text = "<<";
            bt_pre.UseVisualStyleBackColor = true;
            bt_pre.Click += bt_pre_Click;
            // 
            // bt_Sunday
            // 
            bt_Sunday.Location = new Point(709, 3);
            bt_Sunday.Name = "bt_Sunday";
            bt_Sunday.Size = new Size(95, 59);
            bt_Sunday.TabIndex = 1;
            bt_Sunday.Text = "Sunday";
            bt_Sunday.UseVisualStyleBackColor = true;
            // 
            // bt_saturday
            // 
            bt_saturday.Location = new Point(608, 3);
            bt_saturday.Name = "bt_saturday";
            bt_saturday.Size = new Size(95, 59);
            bt_saturday.TabIndex = 1;
            bt_saturday.Text = "Saturday";
            bt_saturday.UseVisualStyleBackColor = true;
            // 
            // bt_Friday
            // 
            bt_Friday.Location = new Point(507, 3);
            bt_Friday.Name = "bt_Friday";
            bt_Friday.Size = new Size(95, 59);
            bt_Friday.TabIndex = 2;
            bt_Friday.Text = "Friday";
            bt_Friday.UseVisualStyleBackColor = true;
            // 
            // bt_thursday
            // 
            bt_thursday.Location = new Point(406, 3);
            bt_thursday.Name = "bt_thursday";
            bt_thursday.Size = new Size(95, 59);
            bt_thursday.TabIndex = 3;
            bt_thursday.Text = "Thursday";
            bt_thursday.UseVisualStyleBackColor = true;
            // 
            // bt_wednesday
            // 
            bt_wednesday.Location = new Point(305, 3);
            bt_wednesday.Name = "bt_wednesday";
            bt_wednesday.Size = new Size(95, 59);
            bt_wednesday.TabIndex = 4;
            bt_wednesday.Text = "Wednesday";
            bt_wednesday.UseVisualStyleBackColor = true;
            // 
            // bt_tuesday
            // 
            bt_tuesday.Location = new Point(204, 3);
            bt_tuesday.Name = "bt_tuesday";
            bt_tuesday.Size = new Size(95, 59);
            bt_tuesday.TabIndex = 1;
            bt_tuesday.Text = "Tuesday";
            bt_tuesday.UseVisualStyleBackColor = true;
            // 
            // bt_monday
            // 
            bt_monday.Location = new Point(103, 3);
            bt_monday.Name = "bt_monday";
            bt_monday.Size = new Size(95, 59);
            bt_monday.TabIndex = 0;
            bt_monday.Text = "Monday";
            bt_monday.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 573);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nup_notifiy).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Button bt_today;
        private DateTimePicker dtp_day;
        private Panel p_matrix;
        private Button bt_Sunday;
        private Button bt_saturday;
        private Button bt_Friday;
        private Button bt_thursday;
        private Button bt_wednesday;
        private Button bt_tuesday;
        private Button bt_monday;
        private Button bt_pre;
        private NumericUpDown nup_notifiy;
        private CheckBox CB_notify;
        private Button bt_next;
    }
}
