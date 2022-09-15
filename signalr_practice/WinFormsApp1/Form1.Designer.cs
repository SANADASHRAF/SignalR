namespace WinFormsApp1
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
            this.connection = new System.Windows.Forms.Button();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.txtsend = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // connection
            // 
            this.connection.Location = new System.Drawing.Point(27, 26);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(761, 29);
            this.connection.TabIndex = 0;
            this.connection.Text = "connection";
            this.connection.UseVisualStyleBackColor = true;
            this.connection.Click += new System.EventHandler(this.connection_Click);
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(128, 97);
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(206, 27);
            this.txtmsg.TabIndex = 1;
            // 
            // txtsend
            // 
            this.txtsend.Location = new System.Drawing.Point(415, 97);
            this.txtsend.Name = "txtsend";
            this.txtsend.Size = new System.Drawing.Size(94, 29);
            this.txtsend.TabIndex = 2;
            this.txtsend.Text = "send";
            this.txtsend.UseVisualStyleBackColor = true;
            this.txtsend.Click += new System.EventHandler(this.txtsend_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(210, 157);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 244);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtsend);
            this.Controls.Add(this.txtmsg);
            this.Controls.Add(this.connection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button connection;
        private TextBox txtmsg;
        private Button txtsend;
        private ListBox listBox1;
    }
}