namespace lap_lich
{
    partial class Daily_Plan
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
            panel1 = new Panel();
            panel3 = new Panel();
            dp_bt_next = new Button();
            dp_bt_pre = new Button();
            dp_dtp_day = new DateTimePicker();
            dp_p_show_job = new Panel();
            menuStrip1 = new MenuStrip();
            ms_add_job = new ToolStripMenuItem();
            ms_today = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dp_p_show_job);
            panel1.Location = new Point(6, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 714);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dp_bt_next);
            panel3.Controls.Add(dp_bt_pre);
            panel3.Controls.Add(dp_dtp_day);
            panel3.Location = new Point(4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(995, 45);
            panel3.TabIndex = 1;
            // 
            // dp_bt_next
            // 
            dp_bt_next.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dp_bt_next.Location = new Point(666, 3);
            dp_bt_next.Name = "dp_bt_next";
            dp_bt_next.Size = new Size(71, 34);
            dp_bt_next.TabIndex = 4;
            dp_bt_next.Text = ">>";
            dp_bt_next.UseVisualStyleBackColor = true;
            dp_bt_next.Click += button1_Click;
            // 
            // dp_bt_pre
            // 
            dp_bt_pre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dp_bt_pre.Location = new Point(241, 3);
            dp_bt_pre.Name = "dp_bt_pre";
            dp_bt_pre.Size = new Size(71, 34);
            dp_bt_pre.TabIndex = 3;
            dp_bt_pre.Text = "<<";
            dp_bt_pre.UseVisualStyleBackColor = true;
            // 
            // dp_dtp_day
            // 
            dp_dtp_day.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dp_dtp_day.Location = new Point(318, 3);
            dp_dtp_day.Name = "dp_dtp_day";
            dp_dtp_day.Size = new Size(333, 34);
            dp_dtp_day.TabIndex = 0;
            // 
            // dp_p_show_job
            // 
            dp_p_show_job.Location = new Point(3, 54);
            dp_p_show_job.Name = "dp_p_show_job";
            dp_p_show_job.Size = new Size(996, 652);
            dp_p_show_job.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ms_add_job, ms_today });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1017, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ms_add_job
            // 
            ms_add_job.Name = "ms_add_job";
            ms_add_job.Size = new Size(84, 24);
            ms_add_job.Text = "ADD JOB";
            // 
            // ms_today
            // 
            ms_today.Name = "ms_today";
            ms_today.Size = new Size(69, 24);
            ms_today.Text = "TODAY";
            // 
            // Daily_Plan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 753);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Daily_Plan";
            Text = "Daily_Plan";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DateTimePicker dp_dtp_day;
        private Panel dp_p_show_job;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ms_add_job;
        private ToolStripMenuItem ms_today;
        private Button dp_bt_next;
        private Button dp_bt_pre;
    }
}