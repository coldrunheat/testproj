namespace ERS
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dashbtn = new System.Windows.Forms.Button();
            this.generatebtn = new System.Windows.Forms.Button();
            this.addrecordbtn = new System.Windows.Forms.Button();
            this.GenerateCOEID1 = new ERS.GenerateCOEID();
            this.addRecord1 = new ERS.AddRecord();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 28);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Record System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1051, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dashbtn);
            this.panel2.Controls.Add(this.generatebtn);
            this.panel2.Controls.Add(this.addrecordbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 549);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 493);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dashbtn
            // 
            this.dashbtn.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbtn.Location = new System.Drawing.Point(22, 314);
            this.dashbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashbtn.Name = "dashbtn";
            this.dashbtn.Size = new System.Drawing.Size(154, 44);
            this.dashbtn.TabIndex = 7;
            this.dashbtn.Text = "Dashboard";
            this.dashbtn.UseVisualStyleBackColor = true;
            this.dashbtn.Click += new System.EventHandler(this.dashbtn_Click);
            // 
            // generatebtn
            // 
            this.generatebtn.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatebtn.Location = new System.Drawing.Point(22, 252);
            this.generatebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(154, 44);
            this.generatebtn.TabIndex = 6;
            this.generatebtn.Text = "Generate COE/ID";
            this.generatebtn.UseVisualStyleBackColor = true;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click_1);
            // 
            // addrecordbtn
            // 
            this.addrecordbtn.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrecordbtn.Location = new System.Drawing.Point(22, 189);
            this.addrecordbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addrecordbtn.Name = "addrecordbtn";
            this.addrecordbtn.Size = new System.Drawing.Size(154, 44);
            this.addrecordbtn.TabIndex = 5;
            this.addrecordbtn.Text = "Add Record";
            this.addrecordbtn.UseVisualStyleBackColor = true;
            this.addrecordbtn.Click += new System.EventHandler(this.addrecordbtn_Click);
            // 
            // GenerateCOEID1
            // 
            this.GenerateCOEID1.Location = new System.Drawing.Point(203, 28);
            this.GenerateCOEID1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenerateCOEID1.Name = "GenerateCOEID1";
            this.GenerateCOEID1.Size = new System.Drawing.Size(872, 560);
            this.GenerateCOEID1.TabIndex = 4;
            // 
            // addRecord1
            // 
            this.addRecord1.Location = new System.Drawing.Point(206, 28);
            this.addRecord1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addRecord1.Name = "addRecord1";
            this.addRecord1.Size = new System.Drawing.Size(875, 560);
            this.addRecord1.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 577);
            this.Controls.Add(this.GenerateCOEID1);
            this.Controls.Add(this.addRecord1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dashbtn;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.Button addrecordbtn;
        private AddRecord addRecord1;
        private GenerateCOEID GenerateCOEID1;
    }
}