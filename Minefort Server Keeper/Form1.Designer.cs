namespace Minefort_Server_Keeper
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
            this.components = new System.ComponentModel.Container();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ConsoleBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.StartBTN = new Guna.UI2.WinForms.Guna2Button();
            this.StopBTN = new Guna.UI2.WinForms.Guna2Button();
            this.ServerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.Cookie = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(11, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(216, 31);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Status: Not Running";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.Animated = true;
            this.ConsoleBox.BorderColor = System.Drawing.Color.Gray;
            this.ConsoleBox.BorderRadius = 5;
            this.ConsoleBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConsoleBox.CustomizableEdges.BottomLeft = false;
            this.ConsoleBox.DefaultText = "";
            this.ConsoleBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConsoleBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConsoleBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConsoleBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConsoleBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ConsoleBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConsoleBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsoleBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConsoleBox.Location = new System.Drawing.Point(14, 45);
            this.ConsoleBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsoleBox.Multiline = true;
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.PasswordChar = '\0';
            this.ConsoleBox.PlaceholderText = "";
            this.ConsoleBox.SelectedText = "";
            this.ConsoleBox.Size = new System.Drawing.Size(429, 282);
            this.ConsoleBox.TabIndex = 3;
            // 
            // StartBTN
            // 
            this.StartBTN.Animated = true;
            this.StartBTN.BackColor = System.Drawing.Color.Transparent;
            this.StartBTN.BorderColor = System.Drawing.Color.Gray;
            this.StartBTN.BorderRadius = 3;
            this.StartBTN.BorderThickness = 1;
            this.StartBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.StartBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartBTN.ForeColor = System.Drawing.Color.White;
            this.StartBTN.Location = new System.Drawing.Point(120, 425);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(108, 36);
            this.StartBTN.TabIndex = 5;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseTransparentBackground = true;
            this.StartBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // StopBTN
            // 
            this.StopBTN.Animated = true;
            this.StopBTN.BackColor = System.Drawing.Color.Transparent;
            this.StopBTN.BorderColor = System.Drawing.Color.Gray;
            this.StopBTN.BorderRadius = 3;
            this.StopBTN.BorderThickness = 1;
            this.StopBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StopBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StopBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StopBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StopBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.StopBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StopBTN.ForeColor = System.Drawing.Color.White;
            this.StopBTN.Location = new System.Drawing.Point(234, 425);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(103, 36);
            this.StopBTN.TabIndex = 6;
            this.StopBTN.Text = "Stop";
            this.StopBTN.UseTransparentBackground = true;
            this.StopBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // ServerID
            // 
            this.ServerID.Animated = true;
            this.ServerID.BorderColor = System.Drawing.Color.Gray;
            this.ServerID.BorderRadius = 5;
            this.ServerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerID.DefaultText = "";
            this.ServerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ServerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServerID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ServerID.ForeColor = System.Drawing.Color.White;
            this.ServerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServerID.Location = new System.Drawing.Point(14, 335);
            this.ServerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServerID.Name = "ServerID";
            this.ServerID.PasswordChar = '\0';
            this.ServerID.PlaceholderText = "Server ID";
            this.ServerID.SelectedText = "";
            this.ServerID.Size = new System.Drawing.Size(429, 36);
            this.ServerID.TabIndex = 7;
            this.ServerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cookie
            // 
            this.Cookie.Animated = true;
            this.Cookie.BorderColor = System.Drawing.Color.Gray;
            this.Cookie.BorderRadius = 5;
            this.Cookie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Cookie.DefaultText = "";
            this.Cookie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Cookie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Cookie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Cookie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Cookie.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Cookie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cookie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Cookie.ForeColor = System.Drawing.Color.White;
            this.Cookie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cookie.Location = new System.Drawing.Point(14, 376);
            this.Cookie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cookie.Name = "Cookie";
            this.Cookie.PasswordChar = '\0';
            this.Cookie.PlaceholderText = "Cookie";
            this.Cookie.SelectedText = "";
            this.Cookie.Size = new System.Drawing.Size(429, 36);
            this.Cookie.TabIndex = 8;
            this.Cookie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(456, 476);
            this.Controls.Add(this.Cookie);
            this.Controls.Add(this.ServerID);
            this.Controls.Add(this.StopBTN);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.ConsoleBox);
            this.Controls.Add(this.StatusLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minefort Server Booster";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TextBox ConsoleBox;
        private Guna.UI2.WinForms.Guna2Button StartBTN;
        private Guna.UI2.WinForms.Guna2Button StopBTN;
        private Guna.UI2.WinForms.Guna2TextBox ServerID;
        private Guna.UI2.WinForms.Guna2TextBox Cookie;
    }
}

