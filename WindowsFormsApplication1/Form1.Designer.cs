namespace WindowsFormsApplication1
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
            this.Info_connect = new System.Windows.Forms.ListBox();
            this.Button_connect = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.My_Port = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.My_Port)).BeginInit();
            this.SuspendLayout();
            // 
            // Info_connect
            // 
            this.Info_connect.FormattingEnabled = true;
            this.Info_connect.Location = new System.Drawing.Point(85, 59);
            this.Info_connect.Name = "Info_connect";
            this.Info_connect.Size = new System.Drawing.Size(680, 381);
            this.Info_connect.TabIndex = 0;
            // 
            // Button_connect
            // 
            this.Button_connect.Location = new System.Drawing.Point(367, 446);
            this.Button_connect.Name = "Button_connect";
            this.Button_connect.Size = new System.Drawing.Size(142, 34);
            this.Button_connect.TabIndex = 1;
            this.Button_connect.Text = "Connect";
            this.Button_connect.UseVisualStyleBackColor = true;
            this.Button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(72, 33);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(141, 20);
            this.Address.TabIndex = 2;
            this.Address.Text = "Adres";
            // 
            // My_Port
            // 
            this.My_Port.Location = new System.Drawing.Point(392, 27);
            this.My_Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.My_Port.Name = "My_Port";
            this.My_Port.Size = new System.Drawing.Size(372, 20);
            this.My_Port.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 497);
            this.Controls.Add(this.My_Port);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Button_connect);
            this.Controls.Add(this.Info_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.My_Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Info_connect;
        private System.Windows.Forms.Button Button_connect;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.NumericUpDown My_Port;
    }
}

