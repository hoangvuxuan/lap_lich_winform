namespace lap_lich
{
    partial class A_job
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            aj_bt_delete = new Button();
            aj_bt_edit = new Button();
            aj_cb_status = new ComboBox();
            aj_nup_to_minute = new NumericUpDown();
            aj_nup_to_h = new NumericUpDown();
            label1 = new Label();
            aj_nud_from_minute = new NumericUpDown();
            aj_nud_from_h = new NumericUpDown();
            aj_tb_job = new TextBox();
            aj_cb_done = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)aj_nup_to_minute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aj_nup_to_h).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aj_nud_from_minute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aj_nud_from_h).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(aj_bt_delete);
            panel1.Controls.Add(aj_bt_edit);
            panel1.Controls.Add(aj_cb_status);
            panel1.Controls.Add(aj_nup_to_minute);
            panel1.Controls.Add(aj_nup_to_h);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(aj_nud_from_minute);
            panel1.Controls.Add(aj_nud_from_h);
            panel1.Controls.Add(aj_tb_job);
            panel1.Controls.Add(aj_cb_done);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 77);
            panel1.TabIndex = 0;
            // 
            // aj_bt_delete
            // 
            aj_bt_delete.Location = new Point(850, 19);
            aj_bt_delete.Name = "aj_bt_delete";
            aj_bt_delete.Size = new Size(63, 29);
            aj_bt_delete.TabIndex = 9;
            aj_bt_delete.Text = "delete";
            aj_bt_delete.UseVisualStyleBackColor = true;
            aj_bt_delete.Click += aj_bt_delete_Click;
            // 
            // aj_bt_edit
            // 
            aj_bt_edit.Location = new Point(781, 19);
            aj_bt_edit.Name = "aj_bt_edit";
            aj_bt_edit.Size = new Size(63, 29);
            aj_bt_edit.TabIndex = 8;
            aj_bt_edit.Text = "edit";
            aj_bt_edit.UseVisualStyleBackColor = true;
            aj_bt_edit.Click += aj_bt_edit_Click;
            // 
            // aj_cb_status
            // 
            aj_cb_status.FormattingEnabled = true;
            aj_cb_status.Location = new Point(668, 21);
            aj_cb_status.Name = "aj_cb_status";
            aj_cb_status.Size = new Size(107, 28);
            aj_cb_status.TabIndex = 7;
            aj_cb_status.SelectedIndexChanged += aj_cb_status_SelectedIndexChanged;
            // 
            // aj_nup_to_minute
            // 
            aj_nup_to_minute.Location = new Point(611, 21);
            aj_nup_to_minute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            aj_nup_to_minute.Name = "aj_nup_to_minute";
            aj_nup_to_minute.Size = new Size(51, 27);
            aj_nup_to_minute.TabIndex = 6;
            // 
            // aj_nup_to_h
            // 
            aj_nup_to_h.Location = new Point(554, 21);
            aj_nup_to_h.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            aj_nup_to_h.Name = "aj_nup_to_h";
            aj_nup_to_h.Size = new Size(51, 27);
            aj_nup_to_h.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(526, 24);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 4;
            label1.Text = "TO";
            // 
            // aj_nud_from_minute
            // 
            aj_nud_from_minute.Location = new Point(469, 21);
            aj_nud_from_minute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            aj_nud_from_minute.Name = "aj_nud_from_minute";
            aj_nud_from_minute.Size = new Size(51, 27);
            aj_nud_from_minute.TabIndex = 3;
            // 
            // aj_nud_from_h
            // 
            aj_nud_from_h.Location = new Point(412, 21);
            aj_nud_from_h.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            aj_nud_from_h.Name = "aj_nud_from_h";
            aj_nud_from_h.Size = new Size(51, 27);
            aj_nud_from_h.TabIndex = 2;
            // 
            // aj_tb_job
            // 
            aj_tb_job.Location = new Point(25, 21);
            aj_tb_job.Multiline = true;
            aj_tb_job.Name = "aj_tb_job";
            aj_tb_job.Size = new Size(381, 49);
            aj_tb_job.TabIndex = 1;
            // 
            // aj_cb_done
            // 
            aj_cb_done.AutoSize = true;
            aj_cb_done.FlatStyle = FlatStyle.System;
            aj_cb_done.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aj_cb_done.Location = new Point(3, 23);
            aj_cb_done.Name = "aj_cb_done";
            aj_cb_done.Size = new Size(31, 16);
            aj_cb_done.TabIndex = 0;
            aj_cb_done.UseVisualStyleBackColor = true;
            aj_cb_done.CheckedChanged += aj_cb_done_CheckedChanged;
            // 
            // A_job
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "A_job";
            Size = new Size(939, 85);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)aj_nup_to_minute).EndInit();
            ((System.ComponentModel.ISupportInitialize)aj_nup_to_h).EndInit();
            ((System.ComponentModel.ISupportInitialize)aj_nud_from_minute).EndInit();
            ((System.ComponentModel.ISupportInitialize)aj_nud_from_h).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox aj_cb_done;
        private NumericUpDown aj_nup_to_minute;
        private NumericUpDown aj_nup_to_h;
        private Label label1;
        private NumericUpDown aj_nud_from_minute;
        private NumericUpDown aj_nud_from_h;
        private TextBox aj_tb_job;
        private Button aj_bt_delete;
        private Button aj_bt_edit;
        private ComboBox aj_cb_status;
    }
}
