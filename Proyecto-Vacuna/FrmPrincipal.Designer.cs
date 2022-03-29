namespace Proyecto_Vacuna
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lote = new Guna.UI2.WinForms.Guna2Button();
            this.vacuna = new Guna.UI2.WinForms.Guna2Button();
            this.estadisticas = new Guna.UI2.WinForms.Guna2Button();
            this.vacunacion = new Guna.UI2.WinForms.Guna2Button();
            this.usuario = new Guna.UI2.WinForms.Guna2Button();
            this.pacientes = new Guna.UI2.WinForms.Guna2Button();
            this.jornada = new Guna.UI2.WinForms.Guna2Button();
            this.nuevaunidad = new Guna.UI2.WinForms.Guna2Button();
            this.cerrar = new Guna.UI2.WinForms.Guna2Button();
            this.distribucion = new Guna.UI2.WinForms.Guna2GroupBox();
            this.datoslotes = new Guna.UI2.WinForms.Guna2CheckBox();
            this.loteunidades = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lotesilais = new Guna.UI2.WinForms.Guna2CheckBox();
            this.distribucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lote
            // 
            this.lote.CheckedState.Parent = this.lote;
            this.lote.CustomImages.Parent = this.lote;
            this.lote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lote.ForeColor = System.Drawing.Color.White;
            this.lote.HoverState.Parent = this.lote;
            this.lote.Image = ((System.Drawing.Image)(resources.GetObject("lote.Image")));
            this.lote.ImageSize = new System.Drawing.Size(55, 55);
            this.lote.Location = new System.Drawing.Point(27, 25);
            this.lote.Name = "lote";
            this.lote.ShadowDecoration.Parent = this.lote;
            this.lote.Size = new System.Drawing.Size(180, 59);
            this.lote.TabIndex = 0;
            this.lote.Text = "Registro de Lotes";
            this.lote.Click += new System.EventHandler(this.lote_Click);
            // 
            // vacuna
            // 
            this.vacuna.CheckedState.Parent = this.vacuna;
            this.vacuna.CustomImages.Parent = this.vacuna;
            this.vacuna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vacuna.ForeColor = System.Drawing.Color.White;
            this.vacuna.HoverState.Parent = this.vacuna;
            this.vacuna.Image = ((System.Drawing.Image)(resources.GetObject("vacuna.Image")));
            this.vacuna.ImageSize = new System.Drawing.Size(55, 55);
            this.vacuna.Location = new System.Drawing.Point(314, 25);
            this.vacuna.Name = "vacuna";
            this.vacuna.ShadowDecoration.Parent = this.vacuna;
            this.vacuna.Size = new System.Drawing.Size(180, 59);
            this.vacuna.TabIndex = 1;
            this.vacuna.Text = "Registro Vacuna";
            this.vacuna.Click += new System.EventHandler(this.vacuna_Click);
            // 
            // estadisticas
            // 
            this.estadisticas.CheckedState.Parent = this.estadisticas;
            this.estadisticas.CustomImages.Parent = this.estadisticas;
            this.estadisticas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.estadisticas.ForeColor = System.Drawing.Color.White;
            this.estadisticas.HoverState.Parent = this.estadisticas;
            this.estadisticas.Image = ((System.Drawing.Image)(resources.GetObject("estadisticas.Image")));
            this.estadisticas.ImageSize = new System.Drawing.Size(55, 55);
            this.estadisticas.Location = new System.Drawing.Point(27, 218);
            this.estadisticas.Name = "estadisticas";
            this.estadisticas.ShadowDecoration.Parent = this.estadisticas;
            this.estadisticas.Size = new System.Drawing.Size(180, 60);
            this.estadisticas.TabIndex = 2;
            this.estadisticas.Text = "Estadisticas";
            this.estadisticas.Click += new System.EventHandler(this.estadisticas_Click);
            // 
            // vacunacion
            // 
            this.vacunacion.CheckedState.Parent = this.vacunacion;
            this.vacunacion.CustomImages.Parent = this.vacunacion;
            this.vacunacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vacunacion.ForeColor = System.Drawing.Color.White;
            this.vacunacion.HoverState.Parent = this.vacunacion;
            this.vacunacion.Image = ((System.Drawing.Image)(resources.GetObject("vacunacion.Image")));
            this.vacunacion.ImageSize = new System.Drawing.Size(55, 55);
            this.vacunacion.Location = new System.Drawing.Point(27, 120);
            this.vacunacion.Name = "vacunacion";
            this.vacunacion.ShadowDecoration.Parent = this.vacunacion;
            this.vacunacion.Size = new System.Drawing.Size(180, 61);
            this.vacunacion.TabIndex = 3;
            this.vacunacion.Text = "Agregar Vacunacion";
            this.vacunacion.Click += new System.EventHandler(this.vacunacion_Click);
            // 
            // usuario
            // 
            this.usuario.CheckedState.Parent = this.usuario;
            this.usuario.CustomImages.Parent = this.usuario;
            this.usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usuario.ForeColor = System.Drawing.Color.White;
            this.usuario.HoverState.Parent = this.usuario;
            this.usuario.Image = ((System.Drawing.Image)(resources.GetObject("usuario.Image")));
            this.usuario.ImageSize = new System.Drawing.Size(55, 55);
            this.usuario.Location = new System.Drawing.Point(608, 25);
            this.usuario.Name = "usuario";
            this.usuario.ShadowDecoration.Parent = this.usuario;
            this.usuario.Size = new System.Drawing.Size(180, 59);
            this.usuario.TabIndex = 4;
            this.usuario.Text = "Usuario";
            // 
            // pacientes
            // 
            this.pacientes.CheckedState.Parent = this.pacientes;
            this.pacientes.CustomImages.Parent = this.pacientes;
            this.pacientes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pacientes.ForeColor = System.Drawing.Color.White;
            this.pacientes.HoverState.Parent = this.pacientes;
            this.pacientes.Image = ((System.Drawing.Image)(resources.GetObject("pacientes.Image")));
            this.pacientes.ImageSize = new System.Drawing.Size(55, 55);
            this.pacientes.Location = new System.Drawing.Point(314, 120);
            this.pacientes.Name = "pacientes";
            this.pacientes.ShadowDecoration.Parent = this.pacientes;
            this.pacientes.Size = new System.Drawing.Size(180, 61);
            this.pacientes.TabIndex = 5;
            this.pacientes.Text = "Pacientes";
            this.pacientes.Click += new System.EventHandler(this.pacientes_Click);
            // 
            // jornada
            // 
            this.jornada.CheckedState.Parent = this.jornada;
            this.jornada.CustomImages.Parent = this.jornada;
            this.jornada.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.jornada.ForeColor = System.Drawing.Color.White;
            this.jornada.HoverState.Parent = this.jornada;
            this.jornada.Image = ((System.Drawing.Image)(resources.GetObject("jornada.Image")));
            this.jornada.ImageSize = new System.Drawing.Size(55, 55);
            this.jornada.Location = new System.Drawing.Point(608, 120);
            this.jornada.Name = "jornada";
            this.jornada.ShadowDecoration.Parent = this.jornada;
            this.jornada.Size = new System.Drawing.Size(180, 61);
            this.jornada.TabIndex = 6;
            this.jornada.Text = "Ingresar Jornada";
            this.jornada.Click += new System.EventHandler(this.jornada_Click);
            // 
            // nuevaunidad
            // 
            this.nuevaunidad.CheckedState.Parent = this.nuevaunidad;
            this.nuevaunidad.CustomImages.Parent = this.nuevaunidad;
            this.nuevaunidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nuevaunidad.ForeColor = System.Drawing.Color.White;
            this.nuevaunidad.HoverState.Parent = this.nuevaunidad;
            this.nuevaunidad.Image = ((System.Drawing.Image)(resources.GetObject("nuevaunidad.Image")));
            this.nuevaunidad.ImageSize = new System.Drawing.Size(55, 55);
            this.nuevaunidad.Location = new System.Drawing.Point(314, 218);
            this.nuevaunidad.Name = "nuevaunidad";
            this.nuevaunidad.ShadowDecoration.Parent = this.nuevaunidad;
            this.nuevaunidad.Size = new System.Drawing.Size(180, 61);
            this.nuevaunidad.TabIndex = 7;
            this.nuevaunidad.Text = "Nueva Unidad";
            this.nuevaunidad.Click += new System.EventHandler(this.nuevaunidad_Click);
            // 
            // cerrar
            // 
            this.cerrar.CheckedState.Parent = this.cerrar;
            this.cerrar.CustomImages.Parent = this.cerrar;
            this.cerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cerrar.ForeColor = System.Drawing.Color.White;
            this.cerrar.HoverState.Parent = this.cerrar;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.ImageSize = new System.Drawing.Size(55, 55);
            this.cerrar.Location = new System.Drawing.Point(608, 218);
            this.cerrar.Name = "cerrar";
            this.cerrar.ShadowDecoration.Parent = this.cerrar;
            this.cerrar.Size = new System.Drawing.Size(180, 61);
            this.cerrar.TabIndex = 8;
            this.cerrar.Text = "Cerrar Sesion";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // distribucion
            // 
            this.distribucion.Controls.Add(this.datoslotes);
            this.distribucion.Controls.Add(this.loteunidades);
            this.distribucion.Controls.Add(this.lotesilais);
            this.distribucion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.distribucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.distribucion.Location = new System.Drawing.Point(368, 311);
            this.distribucion.Name = "distribucion";
            this.distribucion.ShadowDecoration.Parent = this.distribucion;
            this.distribucion.Size = new System.Drawing.Size(300, 200);
            this.distribucion.TabIndex = 9;
            this.distribucion.Text = "Distribucion";
            // 
            // datoslotes
            // 
            this.datoslotes.AutoSize = true;
            this.datoslotes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.datoslotes.CheckedState.BorderRadius = 2;
            this.datoslotes.CheckedState.BorderThickness = 0;
            this.datoslotes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.datoslotes.Location = new System.Drawing.Point(23, 141);
            this.datoslotes.Name = "datoslotes";
            this.datoslotes.Size = new System.Drawing.Size(135, 19);
            this.datoslotes.TabIndex = 2;
            this.datoslotes.Text = "Datos lotes unidades";
            this.datoslotes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.datoslotes.UncheckedState.BorderRadius = 2;
            this.datoslotes.UncheckedState.BorderThickness = 0;
            this.datoslotes.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.datoslotes.UseVisualStyleBackColor = true;
            this.datoslotes.CheckedChanged += new System.EventHandler(this.datoslotes_CheckedChanged);
            // 
            // loteunidades
            // 
            this.loteunidades.AutoSize = true;
            this.loteunidades.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loteunidades.CheckedState.BorderRadius = 2;
            this.loteunidades.CheckedState.BorderThickness = 0;
            this.loteunidades.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loteunidades.Location = new System.Drawing.Point(23, 100);
            this.loteunidades.Name = "loteunidades";
            this.loteunidades.Size = new System.Drawing.Size(182, 19);
            this.loteunidades.TabIndex = 1;
            this.loteunidades.Text = "Distribucion Lotes a Unidades";
            this.loteunidades.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.loteunidades.UncheckedState.BorderRadius = 2;
            this.loteunidades.UncheckedState.BorderThickness = 0;
            this.loteunidades.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.loteunidades.UseVisualStyleBackColor = true;
            this.loteunidades.CheckedChanged += new System.EventHandler(this.loteunidades_CheckedChanged);
            // 
            // lotesilais
            // 
            this.lotesilais.AutoSize = true;
            this.lotesilais.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lotesilais.CheckedState.BorderRadius = 2;
            this.lotesilais.CheckedState.BorderThickness = 0;
            this.lotesilais.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lotesilais.Location = new System.Drawing.Point(23, 58);
            this.lotesilais.Name = "lotesilais";
            this.lotesilais.Size = new System.Drawing.Size(154, 19);
            this.lotesilais.TabIndex = 0;
            this.lotesilais.Text = "Distribucion Lote a Silais";
            this.lotesilais.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lotesilais.UncheckedState.BorderRadius = 2;
            this.lotesilais.UncheckedState.BorderThickness = 0;
            this.lotesilais.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lotesilais.UseVisualStyleBackColor = true;
            this.lotesilais.CheckedChanged += new System.EventHandler(this.lotesilais_CheckedChanged);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 513);
            this.Controls.Add(this.distribucion);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.nuevaunidad);
            this.Controls.Add(this.jornada);
            this.Controls.Add(this.pacientes);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.vacunacion);
            this.Controls.Add(this.estadisticas);
            this.Controls.Add(this.vacuna);
            this.Controls.Add(this.lote);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.distribucion.ResumeLayout(false);
            this.distribucion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button lote;
        private Guna.UI2.WinForms.Guna2Button vacuna;
        private Guna.UI2.WinForms.Guna2Button estadisticas;
        private Guna.UI2.WinForms.Guna2Button vacunacion;
        private Guna.UI2.WinForms.Guna2Button usuario;
        private Guna.UI2.WinForms.Guna2Button pacientes;
        private Guna.UI2.WinForms.Guna2Button jornada;
        private Guna.UI2.WinForms.Guna2Button nuevaunidad;
        private Guna.UI2.WinForms.Guna2Button cerrar;
        private Guna.UI2.WinForms.Guna2GroupBox distribucion;
        private Guna.UI2.WinForms.Guna2CheckBox datoslotes;
        private Guna.UI2.WinForms.Guna2CheckBox loteunidades;
        private Guna.UI2.WinForms.Guna2CheckBox lotesilais;
    }
}