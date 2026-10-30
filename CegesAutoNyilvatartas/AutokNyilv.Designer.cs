namespace CegesAutoNyilvatartas
{
    partial class AutokNyilv
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblMarka = new Label();
            lblModel = new Label();
            lblEvjarat = new Label();
            lblRendszam = new Label();
            lblEmber = new Label();
            txtMarka = new TextBox();
            txtModell = new TextBox();
            txtRendszam = new TextBox();
            txtEvjarat = new TextBox();
            txtKereses = new TextBox();
            lblKereses = new Label();
            lstAutok = new ListBox();
            btnMentes = new Button();
            btnModosit = new Button();
            btnTorles = new Button();
            btnMegse = new Button();
            cmbEmber = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 19);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Autók adatai";
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(321, 47);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(40, 15);
            lblMarka.TabIndex = 1;
            lblMarka.Text = "Márka";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(321, 83);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(44, 15);
            lblModel.TabIndex = 2;
            lblModel.Text = "Modell";
            // 
            // lblEvjarat
            // 
            lblEvjarat.AutoSize = true;
            lblEvjarat.Location = new Point(321, 161);
            lblEvjarat.Name = "lblEvjarat";
            lblEvjarat.Size = new Size(42, 15);
            lblEvjarat.TabIndex = 3;
            lblEvjarat.Text = "Évjárat";
            // 
            // lblRendszam
            // 
            lblRendszam.AutoSize = true;
            lblRendszam.Location = new Point(321, 123);
            lblRendszam.Name = "lblRendszam";
            lblRendszam.Size = new Size(61, 15);
            lblRendszam.TabIndex = 4;
            lblRendszam.Text = "Rendszám";
            // 
            // lblEmber
            // 
            lblEmber.AutoSize = true;
            lblEmber.Location = new Point(321, 211);
            lblEmber.Name = "lblEmber";
            lblEmber.Size = new Size(55, 15);
            lblEmber.TabIndex = 5;
            lblEmber.Text = "Használó";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(387, 44);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(154, 23);
            txtMarka.TabIndex = 6;
            // 
            // txtModell
            // 
            txtModell.Location = new Point(387, 82);
            txtModell.Name = "txtModell";
            txtModell.Size = new Size(154, 23);
            txtModell.TabIndex = 6;
            // 
            // txtRendszam
            // 
            txtRendszam.Location = new Point(387, 120);
            txtRendszam.Name = "txtRendszam";
            txtRendszam.Size = new Size(100, 23);
            txtRendszam.TabIndex = 6;
            // 
            // txtEvjarat
            // 
            txtEvjarat.Location = new Point(387, 158);
            txtEvjarat.Name = "txtEvjarat";
            txtEvjarat.Size = new Size(100, 23);
            txtEvjarat.TabIndex = 6;
            // 
            // txtKereses
            // 
            txtKereses.Location = new Point(43, 46);
            txtKereses.Name = "txtKereses";
            txtKereses.Size = new Size(245, 23);
            txtKereses.TabIndex = 7;
            // 
            // lblKereses
            // 
            lblKereses.AutoSize = true;
            lblKereses.Location = new Point(43, 17);
            lblKereses.Name = "lblKereses";
            lblKereses.Size = new Size(245, 15);
            lblKereses.TabIndex = 8;
            lblKereses.Text = "Keresés márka, modell vagy rendszám alapán";
            // 
            // lstAutok
            // 
            lstAutok.FormattingEnabled = true;
            lstAutok.Location = new Point(43, 75);
            lstAutok.Name = "lstAutok";
            lstAutok.Size = new Size(245, 289);
            lstAutok.TabIndex = 9;
            lstAutok.DoubleClick += lstAutok_DoubleClick;
            // 
            // btnMentes
            // 
            btnMentes.Location = new Point(321, 256);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(75, 23);
            btnMentes.TabIndex = 10;
            btnMentes.Text = "Mentés";
            btnMentes.UseVisualStyleBackColor = true;
            btnMentes.Click += btnMentes_Click;
            // 
            // btnModosit
            // 
            btnModosit.Location = new Point(402, 256);
            btnModosit.Name = "btnModosit";
            btnModosit.Size = new Size(75, 23);
            btnModosit.TabIndex = 11;
            btnModosit.Text = "Módosít";
            btnModosit.UseVisualStyleBackColor = true;
            btnModosit.Click += btnModosit_Click;
            // 
            // btnTorles
            // 
            btnTorles.Location = new Point(483, 256);
            btnTorles.Name = "btnTorles";
            btnTorles.Size = new Size(75, 23);
            btnTorles.TabIndex = 12;
            btnTorles.Text = "Törlés";
            btnTorles.UseVisualStyleBackColor = true;
            btnTorles.Click += btnTorles_Click;
            // 
            // btnMegse
            // 
            btnMegse.Location = new Point(403, 285);
            btnMegse.Name = "btnMegse";
            btnMegse.Size = new Size(75, 23);
            btnMegse.TabIndex = 13;
            btnMegse.Text = "Mégse";
            btnMegse.UseVisualStyleBackColor = true;
            btnMegse.Click += btnMegse_Click;
            // 
            // cmbEmber
            // 
            cmbEmber.FormattingEnabled = true;
            cmbEmber.Location = new Point(387, 208);
            cmbEmber.Name = "cmbEmber";
            cmbEmber.Size = new Size(154, 23);
            cmbEmber.TabIndex = 14;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AutokNyilv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 444);
            Controls.Add(cmbEmber);
            Controls.Add(btnMegse);
            Controls.Add(btnTorles);
            Controls.Add(btnModosit);
            Controls.Add(btnMentes);
            Controls.Add(lstAutok);
            Controls.Add(lblKereses);
            Controls.Add(txtKereses);
            Controls.Add(txtEvjarat);
            Controls.Add(txtRendszam);
            Controls.Add(txtModell);
            Controls.Add(txtMarka);
            Controls.Add(lblEmber);
            Controls.Add(lblRendszam);
            Controls.Add(lblEvjarat);
            Controls.Add(lblModel);
            Controls.Add(lblMarka);
            Controls.Add(label1);
            Name = "AutokNyilv";
            Text = "Autók nyílvántartása";
            Load += AutokNyilv_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMarka;
        private Label lblModel;
        private Label lblEvjarat;
        private Label lblRendszam;
        private Label lblEmber;
        private TextBox txtMarka;
        private TextBox txtModell;
        private TextBox txtRendszam;
        private TextBox txtEvjarat;
        private TextBox txtKereses;
        private Label lblKereses;
        private ListBox lstAutok;
        private Button btnMentes;
        private Button btnModosit;
        private Button btnTorles;
        private Button btnMegse;
        private ComboBox cmbEmber;
        private ErrorProvider errorProvider1;
    }
}