namespace DboxLinkMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LinkList = new System.Windows.Forms.ListBox();
            this.StatusPanel = new System.Windows.Forms.GroupBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.LinkListPanel = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.GroupBox();
            this.OutTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OutputLinkBox = new System.Windows.Forms.TextBox();
            this.InputLinkBox = new System.Windows.Forms.TextBox();
            this.StatusPanel.SuspendLayout();
            this.LinkListPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LinkList
            // 
            this.LinkList.FormattingEnabled = true;
            this.LinkList.Location = new System.Drawing.Point(12, 19);
            this.LinkList.Name = "LinkList";
            this.LinkList.Size = new System.Drawing.Size(420, 17);
            this.LinkList.TabIndex = 2;
            this.LinkList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // StatusPanel
            // 
            this.StatusPanel.Controls.Add(this.OutTxt);
            this.StatusPanel.Controls.Add(this.StatusTextBox);
            this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusPanel.Location = new System.Drawing.Point(0, 108);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(488, 29);
            this.StatusPanel.TabIndex = 3;
            this.StatusPanel.TabStop = false;
            this.StatusPanel.Text = "Status";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.StatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.StatusTextBox.ForeColor = System.Drawing.Color.Lime;
            this.StatusTextBox.Location = new System.Drawing.Point(12, 12);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(458, 13);
            this.StatusTextBox.TabIndex = 0;
            // 
            // LinkListPanel
            // 
            this.LinkListPanel.Controls.Add(this.button2);
            this.LinkListPanel.Controls.Add(this.LinkList);
            this.LinkListPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LinkListPanel.Location = new System.Drawing.Point(0, 65);
            this.LinkListPanel.Name = "LinkListPanel";
            this.LinkListPanel.Size = new System.Drawing.Size(488, 43);
            this.LinkListPanel.TabIndex = 4;
            this.LinkListPanel.TabStop = false;
            this.LinkListPanel.Text = "Converted Links";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(435, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.button1);
            this.MainPanel.Controls.Add(this.OutputLinkBox);
            this.MainPanel.Controls.Add(this.InputLinkBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(488, 63);
            this.MainPanel.TabIndex = 5;
            this.MainPanel.TabStop = false;
            // 
            // OutTxt
            // 
            this.OutTxt.Location = new System.Drawing.Point(478, 19);
            this.OutTxt.Multiline = true;
            this.OutTxt.Name = "OutTxt";
            this.OutTxt.ReadOnly = true;
            this.OutTxt.Size = new System.Drawing.Size(10, 10);
            this.OutTxt.TabIndex = 9;
            this.OutTxt.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Do It!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OutputLinkBox
            // 
            this.OutputLinkBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OutputLinkBox.Location = new System.Drawing.Point(12, 38);
            this.OutputLinkBox.Name = "OutputLinkBox";
            this.OutputLinkBox.ReadOnly = true;
            this.OutputLinkBox.Size = new System.Drawing.Size(420, 20);
            this.OutputLinkBox.TabIndex = 6;
            // 
            // InputLinkBox
            // 
            this.InputLinkBox.Location = new System.Drawing.Point(12, 12);
            this.InputLinkBox.Name = "InputLinkBox";
            this.InputLinkBox.Size = new System.Drawing.Size(420, 20);
            this.InputLinkBox.TabIndex = 7;
            this.InputLinkBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InputLinkBox_MouseClick);
            this.InputLinkBox.Leave += new System.EventHandler(this.InputLinkBox_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 137);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LinkListPanel);
            this.Controls.Add(this.StatusPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DropBox Link Converter v1.0 by |ZoidberG|";
            this.TopMost = true;
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.LinkListPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox LinkList;
        private System.Windows.Forms.GroupBox StatusPanel;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.GroupBox LinkListPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox OutTxt;
        private System.Windows.Forms.GroupBox MainPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OutputLinkBox;
        private System.Windows.Forms.TextBox InputLinkBox;
    }
}

