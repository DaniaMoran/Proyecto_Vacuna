
namespace Proyecto_Vacuna
{
    partial class FrmHistirialP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtNomVacuna = new Guna.UI2.WinForms.Guna2Button();
            this.silais = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.cmbsi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtHistorialp = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvHistorialP = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialP)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(176, 287);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "Nuevo Paciente";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Indigo;
            this.guna2GroupBox2.Controls.Add(this.TxtNomVacuna);
            this.guna2GroupBox2.Controls.Add(this.silais);
            this.guna2GroupBox2.Controls.Add(this.guna2Button3);
            this.guna2GroupBox2.Controls.Add(this.cmbsi);
            this.guna2GroupBox2.Controls.Add(this.label2);
            this.guna2GroupBox2.Controls.Add(this.TxtHistorialp);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(15, 2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(518, 262);
            this.guna2GroupBox2.TabIndex = 9;
            this.guna2GroupBox2.Text = "Historial pacientes";
            this.guna2GroupBox2.Click += new System.EventHandler(this.guna2GroupBox2_Click);
            // 
            // TxtNomVacuna
            // 
            this.TxtNomVacuna.CheckedState.Parent = this.TxtNomVacuna;
            this.TxtNomVacuna.CustomImages.Parent = this.TxtNomVacuna;
            this.TxtNomVacuna.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomVacuna.ForeColor = System.Drawing.Color.White;
            this.TxtNomVacuna.HoverState.Parent = this.TxtNomVacuna;
            this.TxtNomVacuna.Location = new System.Drawing.Point(338, 150);
            this.TxtNomVacuna.Name = "TxtNomVacuna";
            this.TxtNomVacuna.ShadowDecoration.Parent = this.TxtNomVacuna;
            this.TxtNomVacuna.Size = new System.Drawing.Size(130, 23);
            this.TxtNomVacuna.TabIndex = 27;
            this.TxtNomVacuna.Text = "Buscar por Nom Vacuna ";
            // 
            // silais
            // 
            this.silais.CheckedState.Parent = this.silais;
            this.silais.CustomImages.Parent = this.silais;
            this.silais.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silais.ForeColor = System.Drawing.Color.White;
            this.silais.HoverState.Parent = this.silais;
            this.silais.Location = new System.Drawing.Point(338, 70);
            this.silais.Name = "silais";
            this.silais.ShadowDecoration.Parent = this.silais;
            this.silais.Size = new System.Drawing.Size(130, 23);
            this.silais.TabIndex = 26;
            this.silais.Text = "Buscar SILAIS";
            this.silais.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(338, 112);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(130, 23);
            this.guna2Button3.TabIndex = 25;
            this.guna2Button3.Text = "Refrescar";
            // 
            // cmbsi
            // 
            this.cmbsi.BackColor = System.Drawing.Color.Transparent;
            this.cmbsi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbsi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsi.FocusedColor = System.Drawing.Color.Empty;
            this.cmbsi.FocusedState.Parent = this.cmbsi;
            this.cmbsi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbsi.FormattingEnabled = true;
            this.cmbsi.HoverState.Parent = this.cmbsi;
            this.cmbsi.ItemHeight = 30;
            this.cmbsi.ItemsAppearance.Parent = this.cmbsi;
            this.cmbsi.Location = new System.Drawing.Point(85, 70);
            this.cmbsi.Name = "cmbsi";
            this.cmbsi.ShadowDecoration.Parent = this.cmbsi;
            this.cmbsi.Size = new System.Drawing.Size(216, 36);
            this.cmbsi.TabIndex = 24;
            this.cmbsi.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarSilais_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 5;
            // 
            // TxtHistorialp
            // 
            this.TxtHistorialp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtHistorialp.DefaultText = "";
            this.TxtHistorialp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtHistorialp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtHistorialp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtHistorialp.DisabledState.Parent = this.TxtHistorialp;
            this.TxtHistorialp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtHistorialp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtHistorialp.FocusedState.Parent = this.TxtHistorialp;
            this.TxtHistorialp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtHistorialp.HoverState.Parent = this.TxtHistorialp;
            this.TxtHistorialp.Location = new System.Drawing.Point(85, 131);
            this.TxtHistorialp.Name = "TxtHistorialp";
            this.TxtHistorialp.PasswordChar = '\0';
            this.TxtHistorialp.PlaceholderText = "";
            this.TxtHistorialp.SelectedText = "";
            this.TxtHistorialp.ShadowDecoration.Parent = this.TxtHistorialp;
            this.TxtHistorialp.Size = new System.Drawing.Size(209, 42);
            this.TxtHistorialp.TabIndex = 0;
            this.TxtHistorialp.TextChanged += new System.EventHandler(this.TxtBuscarHistorial_TextChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Fuchsia;
            this.guna2GroupBox1.Controls.Add(this.dgvHistorialP);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(538, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(518, 265);
            this.guna2GroupBox1.TabIndex = 11;
            this.guna2GroupBox1.Text = "Lista de Pacientes";
            // 
            // dgvHistorialP
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHistorialP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorialP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorialP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialP.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorialP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorialP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistorialP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorialP.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorialP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorialP.EnableHeadersVisualStyles = false;
            this.dgvHistorialP.GridColor = System.Drawing.Color.Fuchsia;
            this.dgvHistorialP.Location = new System.Drawing.Point(3, 43);
            this.dgvHistorialP.Name = "dgvHistorialP";
            this.dgvHistorialP.RowHeadersVisible = false;
            this.dgvHistorialP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialP.Size = new System.Drawing.Size(512, 219);
            this.dgvHistorialP.TabIndex = 1;
            this.dgvHistorialP.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvHistorialP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHistorialP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHistorialP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHistorialP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHistorialP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHistorialP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHistorialP.ThemeStyle.GridColor = System.Drawing.Color.Fuchsia;
            this.dgvHistorialP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHistorialP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHistorialP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvHistorialP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHistorialP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHistorialP.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvHistorialP.ThemeStyle.ReadOnly = false;
            this.dgvHistorialP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHistorialP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistorialP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvHistorialP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHistorialP.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHistorialP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHistorialP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHistorialP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialP_CellContentClick);
            // 
            // FrmHistirialP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 344);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Name = "FrmHistirialP";
            this.Text = "FrmHistirialP";
            this.AutoSizeChanged += new System.EventHandler(this.FrmHistorialP_Load);
            this.Load += new System.EventHandler(this.FrmHistirialP_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button TxtNomVacuna;
        private Guna.UI2.WinForms.Guna2Button silais;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbsi;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxtHistorialp;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHistorialP;
    }
}