namespace ChatClient
{
    partial class MainForm
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
            this.client_ip_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.client_name_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.client_port_tb = new System.Windows.Forms.TextBox();
            this.client_connect_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.client_conversation_Lb = new System.Windows.Forms.ListBox();
            this.client_files = new System.Windows.Forms.ListBox();
            this.client_mb = new System.Windows.Forms.TextBox();
            this.client_selectFile_btn = new System.Windows.Forms.Button();
            this.client_sendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // client_ip_tb
            // 
            this.client_ip_tb.Location = new System.Drawing.Point(76, 21);
            this.client_ip_tb.Name = "client_ip_tb";
            this.client_ip_tb.Size = new System.Drawing.Size(161, 20);
            this.client_ip_tb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server\'s IP";
            // 
            // client_name_tb
            // 
            this.client_name_tb.Location = new System.Drawing.Point(76, 63);
            this.client_name_tb.Name = "client_name_tb";
            this.client_name_tb.Size = new System.Drawing.Size(234, 20);
            this.client_name_tb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server\'s Port";
            // 
            // client_port_tb
            // 
            this.client_port_tb.Location = new System.Drawing.Point(316, 21);
            this.client_port_tb.Name = "client_port_tb";
            this.client_port_tb.Size = new System.Drawing.Size(100, 20);
            this.client_port_tb.TabIndex = 4;
            // 
            // client_connect_btn
            // 
            this.client_connect_btn.Location = new System.Drawing.Point(316, 59);
            this.client_connect_btn.Name = "client_connect_btn";
            this.client_connect_btn.Size = new System.Drawing.Size(100, 23);
            this.client_connect_btn.TabIndex = 5;
            this.client_connect_btn.Text = "Connect";
            this.client_connect_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // client_conversation_Lb
            // 
            this.client_conversation_Lb.FormattingEnabled = true;
            this.client_conversation_Lb.Location = new System.Drawing.Point(18, 115);
            this.client_conversation_Lb.Name = "client_conversation_Lb";
            this.client_conversation_Lb.Size = new System.Drawing.Size(292, 342);
            this.client_conversation_Lb.TabIndex = 7;
            // 
            // client_files
            // 
            this.client_files.FormattingEnabled = true;
            this.client_files.Location = new System.Drawing.Point(316, 115);
            this.client_files.Name = "client_files";
            this.client_files.Size = new System.Drawing.Size(100, 342);
            this.client_files.TabIndex = 8;
            // 
            // client_mb
            // 
            this.client_mb.Location = new System.Drawing.Point(18, 483);
            this.client_mb.Multiline = true;
            this.client_mb.Name = "client_mb";
            this.client_mb.Size = new System.Drawing.Size(292, 81);
            this.client_mb.TabIndex = 9;
            // 
            // client_selectFile_btn
            // 
            this.client_selectFile_btn.Location = new System.Drawing.Point(316, 483);
            this.client_selectFile_btn.Name = "client_selectFile_btn";
            this.client_selectFile_btn.Size = new System.Drawing.Size(100, 23);
            this.client_selectFile_btn.TabIndex = 10;
            this.client_selectFile_btn.Text = "Browse";
            this.client_selectFile_btn.UseVisualStyleBackColor = true;
            // 
            // client_sendBtn
            // 
            this.client_sendBtn.Location = new System.Drawing.Point(317, 522);
            this.client_sendBtn.Name = "client_sendBtn";
            this.client_sendBtn.Size = new System.Drawing.Size(99, 41);
            this.client_sendBtn.TabIndex = 11;
            this.client_sendBtn.Text = "Send";
            this.client_sendBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 587);
            this.Controls.Add(this.client_sendBtn);
            this.Controls.Add(this.client_selectFile_btn);
            this.Controls.Add(this.client_mb);
            this.Controls.Add(this.client_files);
            this.Controls.Add(this.client_conversation_Lb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.client_connect_btn);
            this.Controls.Add(this.client_port_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.client_name_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.client_ip_tb);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox client_ip_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox client_name_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox client_port_tb;
        private System.Windows.Forms.Button client_connect_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox client_conversation_Lb;
        private System.Windows.Forms.ListBox client_files;
        private System.Windows.Forms.TextBox client_mb;
        private System.Windows.Forms.Button client_selectFile_btn;
        private System.Windows.Forms.Button client_sendBtn;
    }
}

