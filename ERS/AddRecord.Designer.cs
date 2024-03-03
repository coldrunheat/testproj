namespace ERS
{
    partial class AddRecord
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.emppos = new System.Windows.Forms.ComboBox();
            this.empposition = new System.Windows.Forms.Label();
            this.bdaydp = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.delrecordbtn = new System.Windows.Forms.Button();
            this.clearrecordbtn = new System.Windows.Forms.Button();
            this.updaterecordbtn = new System.Windows.Forms.Button();
            this.addrecordbtn = new System.Windows.Forms.Button();
            this.importbtn = new System.Windows.Forms.Button();
            this.profpic = new System.Windows.Forms.PictureBox();
            this.empcontactnum = new System.Windows.Forms.TextBox();
            this.emcontactnum = new System.Windows.Forms.Label();
            this.empcontactname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.enddatedp = new System.Windows.Forms.DateTimePicker();
            this.startdatedp = new System.Windows.Forms.DateTimePicker();
            this.projcb = new System.Windows.Forms.ComboBox();
            this.empcontactaddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cnumtb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addresstb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lnametb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mnametb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fnametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.emppos);
            this.panel1.Controls.Add(this.empposition);
            this.panel1.Controls.Add(this.bdaydp);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.delrecordbtn);
            this.panel1.Controls.Add(this.clearrecordbtn);
            this.panel1.Controls.Add(this.updaterecordbtn);
            this.panel1.Controls.Add(this.addrecordbtn);
            this.panel1.Controls.Add(this.importbtn);
            this.panel1.Controls.Add(this.profpic);
            this.panel1.Controls.Add(this.empcontactnum);
            this.panel1.Controls.Add(this.emcontactnum);
            this.panel1.Controls.Add(this.empcontactname);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.enddatedp);
            this.panel1.Controls.Add(this.startdatedp);
            this.panel1.Controls.Add(this.projcb);
            this.panel1.Controls.Add(this.empcontactaddress);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cnumtb);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.addresstb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lnametb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mnametb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.fnametb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.idtb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(14, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 358);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // emppos
            // 
            this.emppos.FormattingEnabled = true;
            this.emppos.Items.AddRange(new object[] {
            "SR",
            "TS",
            "CAS"});
            this.emppos.Location = new System.Drawing.Point(397, 68);
            this.emppos.Name = "emppos";
            this.emppos.Size = new System.Drawing.Size(136, 21);
            this.emppos.TabIndex = 11;
            this.emppos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // empposition
            // 
            this.empposition.AutoSize = true;
            this.empposition.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empposition.Location = new System.Drawing.Point(311, 68);
            this.empposition.Name = "empposition";
            this.empposition.Size = new System.Drawing.Size(54, 17);
            this.empposition.TabIndex = 38;
            this.empposition.Text = "Position";
            this.empposition.Click += new System.EventHandler(this.label14_Click);
            // 
            // bdaydp
            // 
            this.bdaydp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdaydp.Location = new System.Drawing.Point(114, 328);
            this.bdaydp.Name = "bdaydp";
            this.bdaydp.Size = new System.Drawing.Size(200, 25);
            this.bdaydp.TabIndex = 9;
            this.bdaydp.ValueChanged += new System.EventHandler(this.bdaydp_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Date of Birth";
            // 
            // delrecordbtn
            // 
            this.delrecordbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delrecordbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delrecordbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delrecordbtn.Location = new System.Drawing.Point(734, 300);
            this.delrecordbtn.Name = "delrecordbtn";
            this.delrecordbtn.Size = new System.Drawing.Size(84, 37);
            this.delrecordbtn.TabIndex = 35;
            this.delrecordbtn.Text = "Delete";
            this.delrecordbtn.UseVisualStyleBackColor = false;
            this.delrecordbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // clearrecordbtn
            // 
            this.clearrecordbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearrecordbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearrecordbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearrecordbtn.Location = new System.Drawing.Point(734, 255);
            this.clearrecordbtn.Name = "clearrecordbtn";
            this.clearrecordbtn.Size = new System.Drawing.Size(84, 39);
            this.clearrecordbtn.TabIndex = 34;
            this.clearrecordbtn.Text = "Clear";
            this.clearrecordbtn.UseVisualStyleBackColor = false;
            this.clearrecordbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // updaterecordbtn
            // 
            this.updaterecordbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updaterecordbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updaterecordbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updaterecordbtn.Location = new System.Drawing.Point(632, 300);
            this.updaterecordbtn.Name = "updaterecordbtn";
            this.updaterecordbtn.Size = new System.Drawing.Size(84, 37);
            this.updaterecordbtn.TabIndex = 33;
            this.updaterecordbtn.Text = "Update";
            this.updaterecordbtn.UseVisualStyleBackColor = false;
            this.updaterecordbtn.Click += new System.EventHandler(this.updaterecordbtn_Click);
            // 
            // addrecordbtn
            // 
            this.addrecordbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addrecordbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrecordbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrecordbtn.Location = new System.Drawing.Point(632, 255);
            this.addrecordbtn.Name = "addrecordbtn";
            this.addrecordbtn.Size = new System.Drawing.Size(84, 39);
            this.addrecordbtn.TabIndex = 32;
            this.addrecordbtn.Text = "Add";
            this.addrecordbtn.UseVisualStyleBackColor = false;
            this.addrecordbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // importbtn
            // 
            this.importbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.importbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importbtn.Location = new System.Drawing.Point(420, 320);
            this.importbtn.Name = "importbtn";
            this.importbtn.Size = new System.Drawing.Size(113, 31);
            this.importbtn.TabIndex = 31;
            this.importbtn.Text = "Import";
            this.importbtn.UseVisualStyleBackColor = false;
            this.importbtn.Click += new System.EventHandler(this.importbtn_Click);
            // 
            // profpic
            // 
            this.profpic.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.profpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profpic.Location = new System.Drawing.Point(411, 187);
            this.profpic.Name = "profpic";
            this.profpic.Size = new System.Drawing.Size(138, 127);
            this.profpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profpic.TabIndex = 30;
            this.profpic.TabStop = false;
            // 
            // empcontactnum
            // 
            this.empcontactnum.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empcontactnum.Location = new System.Drawing.Point(662, 108);
            this.empcontactnum.Name = "empcontactnum";
            this.empcontactnum.Size = new System.Drawing.Size(170, 25);
            this.empcontactnum.TabIndex = 15;
            this.empcontactnum.TextChanged += new System.EventHandler(this.empcontactnum_TextChanged);
            // 
            // emcontactnum
            // 
            this.emcontactnum.AutoSize = true;
            this.emcontactnum.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emcontactnum.Location = new System.Drawing.Point(600, 114);
            this.emcontactnum.Name = "emcontactnum";
            this.emcontactnum.Size = new System.Drawing.Size(56, 17);
            this.emcontactnum.TabIndex = 28;
            this.emcontactnum.Text = "Number";
            // 
            // empcontactname
            // 
            this.empcontactname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empcontactname.Location = new System.Drawing.Point(662, 61);
            this.empcontactname.Name = "empcontactname";
            this.empcontactname.Size = new System.Drawing.Size(170, 25);
            this.empcontactname.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(613, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(605, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "In Case of Emergency, please contact:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // enddatedp
            // 
            this.enddatedp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddatedp.Location = new System.Drawing.Point(397, 144);
            this.enddatedp.Name = "enddatedp";
            this.enddatedp.Size = new System.Drawing.Size(200, 25);
            this.enddatedp.TabIndex = 13;
            // 
            // startdatedp
            // 
            this.startdatedp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdatedp.Location = new System.Drawing.Point(397, 106);
            this.startdatedp.Name = "startdatedp";
            this.startdatedp.Size = new System.Drawing.Size(200, 25);
            this.startdatedp.TabIndex = 12;
            // 
            // projcb
            // 
            this.projcb.FormattingEnabled = true;
            this.projcb.Items.AddRange(new object[] {
            "CBMS",
            "NICTHS",
            "FIES",
            "AgStat"});
            this.projcb.Location = new System.Drawing.Point(397, 27);
            this.projcb.Name = "projcb";
            this.projcb.Size = new System.Drawing.Size(136, 21);
            this.projcb.TabIndex = 10;
            this.projcb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // empcontactaddress
            // 
            this.empcontactaddress.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empcontactaddress.Location = new System.Drawing.Point(662, 149);
            this.empcontactaddress.Multiline = true;
            this.empcontactaddress.Name = "empcontactaddress";
            this.empcontactaddress.Size = new System.Drawing.Size(170, 79);
            this.empcontactaddress.TabIndex = 16;
            this.empcontactaddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(600, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(311, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "End Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(311, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Start Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(311, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Project";
            // 
            // cnumtb
            // 
            this.cnumtb.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnumtb.Location = new System.Drawing.Point(114, 196);
            this.cnumtb.Name = "cnumtb";
            this.cnumtb.Size = new System.Drawing.Size(170, 25);
            this.cnumtb.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Contact Number";
            // 
            // addresstb
            // 
            this.addresstb.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstb.Location = new System.Drawing.Point(114, 236);
            this.addresstb.Multiline = true;
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(170, 78);
            this.addresstb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // lnametb
            // 
            this.lnametb.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnametb.Location = new System.Drawing.Point(114, 149);
            this.lnametb.Name = "lnametb";
            this.lnametb.Size = new System.Drawing.Size(170, 25);
            this.lnametb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name";
            // 
            // mnametb
            // 
            this.mnametb.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnametb.Location = new System.Drawing.Point(114, 108);
            this.mnametb.Name = "mnametb";
            this.mnametb.Size = new System.Drawing.Size(170, 25);
            this.mnametb.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Middle Name";
            // 
            // fnametb
            // 
            this.fnametb.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametb.Location = new System.Drawing.Point(114, 65);
            this.fnametb.Name = "fnametb";
            this.fnametb.Size = new System.Drawing.Size(170, 25);
            this.fnametb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // idtb
            // 
            this.idtb.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtb.Location = new System.Drawing.Point(114, 24);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(170, 25);
            this.idtb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(850, 176);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "AddRecord";
            this.Size = new System.Drawing.Size(878, 565);
            this.Load += new System.EventHandler(this.AddRecord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addresstb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lnametb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mnametb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fnametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.ComboBox projcb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cnumtb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker enddatedp;
        private System.Windows.Forms.DateTimePicker startdatedp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button importbtn;
        private System.Windows.Forms.PictureBox profpic;
        private System.Windows.Forms.TextBox empcontactnum;
        private System.Windows.Forms.Label emcontactnum;
        private System.Windows.Forms.TextBox empcontactname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox empcontactaddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addrecordbtn;
        private System.Windows.Forms.Button delrecordbtn;
        private System.Windows.Forms.Button clearrecordbtn;
        private System.Windows.Forms.Button updaterecordbtn;
        private System.Windows.Forms.DateTimePicker bdaydp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox emppos;
        private System.Windows.Forms.Label empposition;
    }
}
