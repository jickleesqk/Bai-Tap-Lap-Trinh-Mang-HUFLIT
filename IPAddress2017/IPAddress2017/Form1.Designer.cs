﻿namespace IPAddress2017
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.iputbx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hostbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Aliasbx = new System.Windows.Forms.TextBox();
            this.ipbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxResolve = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // iputbx
            // 
            this.iputbx.Location = new System.Drawing.Point(112, 10);
            this.iputbx.Name = "iputbx";
            this.iputbx.Size = new System.Drawing.Size(274, 20);
            this.iputbx.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Resolve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hostname";
            // 
            // hostbx
            // 
            this.hostbx.Location = new System.Drawing.Point(129, 68);
            this.hostbx.Name = "hostbx";
            this.hostbx.ReadOnly = true;
            this.hostbx.Size = new System.Drawing.Size(257, 20);
            this.hostbx.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alias";
            // 
            // Aliasbx
            // 
            this.Aliasbx.Location = new System.Drawing.Point(217, 118);
            this.Aliasbx.Multiline = true;
            this.Aliasbx.Name = "Aliasbx";
            this.Aliasbx.ReadOnly = true;
            this.Aliasbx.Size = new System.Drawing.Size(280, 233);
            this.Aliasbx.TabIndex = 8;
            // 
            // ipbx
            // 
            this.ipbx.Location = new System.Drawing.Point(15, 119);
            this.ipbx.Multiline = true;
            this.ipbx.Name = "ipbx";
            this.ipbx.ReadOnly = true;
            this.ipbx.Size = new System.Drawing.Size(169, 232);
            this.ipbx.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type";
            // 
            // cbxResolve
            // 
            this.cbxResolve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResolve.FormattingEnabled = true;
            this.cbxResolve.Items.AddRange(new object[] {
            "To Hostname",
            "To IP Address"});
            this.cbxResolve.Location = new System.Drawing.Point(112, 41);
            this.cbxResolve.Name = "cbxResolve";
            this.cbxResolve.Size = new System.Drawing.Size(274, 21);
            this.cbxResolve.TabIndex = 11;
            this.cbxResolve.SelectedIndexChanged += new System.EventHandler(this.cbxResolve_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 380);
            this.Controls.Add(this.cbxResolve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ipbx);
            this.Controls.Add(this.Aliasbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hostbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iputbx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iputbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hostbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Aliasbx;
        private System.Windows.Forms.TextBox ipbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxResolve;
    }
}

