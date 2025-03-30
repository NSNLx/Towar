namespace Towar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToCSV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadCSV = new System.Windows.Forms.ToolStripButton();
            this.nazwa = new System.Windows.Forms.TextBox();
            this.iloscSztuk = new System.Windows.Forms.NumericUpDown();
            this.cena = new System.Windows.Forms.NumericUpDown();
            this.wartosc = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.oplacone = new System.Windows.Forms.CheckBox();
            this.wyslane = new System.Windows.Forms.CheckBox();
            this.dostarczone = new System.Windows.Forms.CheckBox();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.oplac = new System.Windows.Forms.Button();
            this.wyslij = new System.Windows.Forms.Button();
            this.dostarczono = new System.Windows.Forms.Button();
            this.Opis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iloscSztuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cena)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToCSV,
            this.toolStripSeparator1,
            this.loadCSV});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToCSV
            // 
            this.saveToCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveToCSV.Image = ((System.Drawing.Image)(resources.GetObject("saveToCSV.Image")));
            this.saveToCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToCSV.Name = "saveToCSV";
            this.saveToCSV.Size = new System.Drawing.Size(74, 22);
            this.saveToCSV.Text = "Save To CSV";
            this.saveToCSV.Click += new System.EventHandler(this.saveToCSV_Click);
            this.saveToCSV.DoubleClick += new System.EventHandler(this.saveToCSV_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // loadCSV
            // 
            this.loadCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadCSV.Image = ((System.Drawing.Image)(resources.GetObject("loadCSV.Image")));
            this.loadCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadCSV.Name = "loadCSV";
            this.loadCSV.Size = new System.Drawing.Size(61, 22);
            this.loadCSV.Text = "Load CSV";
            this.loadCSV.Click += new System.EventHandler(this.loadCSV_Click);
            this.loadCSV.DoubleClick += new System.EventHandler(this.loadCSV_Click);
            // 
            // nazwa
            // 
            this.nazwa.Location = new System.Drawing.Point(117, 75);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(100, 20);
            this.nazwa.TabIndex = 2;
            // 
            // iloscSztuk
            // 
            this.iloscSztuk.Location = new System.Drawing.Point(117, 102);
            this.iloscSztuk.Name = "iloscSztuk";
            this.iloscSztuk.Size = new System.Drawing.Size(120, 20);
            this.iloscSztuk.TabIndex = 3;
            this.iloscSztuk.ValueChanged += new System.EventHandler(this.iloscSztuk_ValueChanged);
            // 
            // cena
            // 
            this.cena.Location = new System.Drawing.Point(117, 129);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(120, 20);
            this.cena.TabIndex = 4;
            this.cena.ValueChanged += new System.EventHandler(this.cena_ValueChanged);
            // 
            // wartosc
            // 
            this.wartosc.Location = new System.Drawing.Point(117, 156);
            this.wartosc.Name = "wartosc";
            this.wartosc.ReadOnly = true;
            this.wartosc.Size = new System.Drawing.Size(100, 20);
            this.wartosc.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sony",
            "HP",
            "DY",
            "Samsung",
            "Acer",
            "Goodram",
            "Kingston"});
            this.comboBox1.Location = new System.Drawing.Point(117, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // oplacone
            // 
            this.oplacone.AutoSize = true;
            this.oplacone.Enabled = false;
            this.oplacone.Location = new System.Drawing.Point(117, 220);
            this.oplacone.Name = "oplacone";
            this.oplacone.Size = new System.Drawing.Size(72, 17);
            this.oplacone.TabIndex = 7;
            this.oplacone.Text = "Oplacone";
            this.oplacone.UseVisualStyleBackColor = true;
            // 
            // wyslane
            // 
            this.wyslane.AutoSize = true;
            this.wyslane.Enabled = false;
            this.wyslane.Location = new System.Drawing.Point(117, 244);
            this.wyslane.Name = "wyslane";
            this.wyslane.Size = new System.Drawing.Size(69, 17);
            this.wyslane.TabIndex = 8;
            this.wyslane.Text = "Wysłane";
            this.wyslane.UseVisualStyleBackColor = true;
            // 
            // dostarczone
            // 
            this.dostarczone.AutoSize = true;
            this.dostarczone.Enabled = false;
            this.dostarczone.Location = new System.Drawing.Point(117, 290);
            this.dostarczone.Name = "dostarczone";
            this.dostarczone.Size = new System.Drawing.Size(86, 17);
            this.dostarczone.TabIndex = 9;
            this.dostarczone.Text = "Dostarczone";
            this.dostarczone.UseVisualStyleBackColor = true;
            this.dostarczone.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(193, 264);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(200, 20);
            this.data.TabIndex = 10;
            // 
            // oplac
            // 
            this.oplac.Location = new System.Drawing.Point(429, 220);
            this.oplac.Name = "oplac";
            this.oplac.Size = new System.Drawing.Size(75, 23);
            this.oplac.TabIndex = 11;
            this.oplac.Text = "Opłać";
            this.oplac.UseVisualStyleBackColor = true;
            this.oplac.Click += new System.EventHandler(this.button1_Click);
            // 
            // wyslij
            // 
            this.wyslij.Location = new System.Drawing.Point(429, 244);
            this.wyslij.Name = "wyslij";
            this.wyslij.Size = new System.Drawing.Size(75, 23);
            this.wyslij.TabIndex = 12;
            this.wyslij.Text = "Wyslij";
            this.wyslij.UseVisualStyleBackColor = true;
            this.wyslij.Click += new System.EventHandler(this.wyslij_Click);
            // 
            // dostarczono
            // 
            this.dostarczono.Location = new System.Drawing.Point(429, 290);
            this.dostarczono.Name = "dostarczono";
            this.dostarczono.Size = new System.Drawing.Size(75, 23);
            this.dostarczono.TabIndex = 13;
            this.dostarczono.Text = "Dostarczono";
            this.dostarczono.UseVisualStyleBackColor = true;
            this.dostarczono.Click += new System.EventHandler(this.dostarczono_Click);
            // 
            // Opis
            // 
            this.Opis.Location = new System.Drawing.Point(586, 102);
            this.Opis.Multiline = true;
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(100, 50);
            this.Opis.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nazwa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ilość";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Wartość";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Producent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Opis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Data wysyłki";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Opis);
            this.Controls.Add(this.dostarczono);
            this.Controls.Add(this.wyslij);
            this.Controls.Add(this.oplac);
            this.Controls.Add(this.data);
            this.Controls.Add(this.dostarczone);
            this.Controls.Add(this.wyslane);
            this.Controls.Add(this.oplacone);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.wartosc);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.iloscSztuk);
            this.Controls.Add(this.nazwa);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Towary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iloscSztuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToCSV;
        private System.Windows.Forms.ToolStripButton loadCSV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox nazwa;
        private System.Windows.Forms.NumericUpDown iloscSztuk;
        private System.Windows.Forms.NumericUpDown cena;
        private System.Windows.Forms.TextBox wartosc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox oplacone;
        private System.Windows.Forms.CheckBox wyslane;
        private System.Windows.Forms.CheckBox dostarczone;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Button oplac;
        private System.Windows.Forms.Button wyslij;
        private System.Windows.Forms.Button dostarczono;
        private System.Windows.Forms.TextBox Opis;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

