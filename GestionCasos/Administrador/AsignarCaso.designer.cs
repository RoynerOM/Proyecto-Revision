﻿
namespace GestionCasos
{
    partial class AsignarCaso
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAsignados = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbTipoUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtCircuito = new Guna.UI.WinForms.GunaTextBox();
            this.txtJuntaAdm = new Guna.UI.WinForms.GunaTextBox();
            this.txtConsecutivo = new Guna.UI.WinForms.GunaTextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbAsignado = new System.Windows.Forms.Label();
            this.lbMedioReceptivo = new System.Windows.Forms.Label();
            this.lbCircuiton = new System.Windows.Forms.Label();
            this.lbJunta = new System.Windows.Forms.Label();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.dtpFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbConsecutivo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(881, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 860);
            this.panel2.TabIndex = 57;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(0, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnBuscar.Size = new System.Drawing.Size(160, 50);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(0, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnGuardar.Size = new System.Drawing.Size(160, 50);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbAsignados);
            this.panel1.Controls.Add(this.cbTipoUsuario);
            this.panel1.Controls.Add(this.txtCircuito);
            this.panel1.Controls.Add(this.txtJuntaAdm);
            this.panel1.Controls.Add(this.txtConsecutivo);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.lbAsignado);
            this.panel1.Controls.Add(this.lbMedioReceptivo);
            this.panel1.Controls.Add(this.lbCircuiton);
            this.panel1.Controls.Add(this.lbJunta);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lbCodigo);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.lbFecha);
            this.panel1.Controls.Add(this.lbConsecutivo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 860);
            this.panel1.TabIndex = 58;
            // 
            // cbAsignados
            // 
            this.cbAsignados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAsignados.BackColor = System.Drawing.Color.Transparent;
            this.cbAsignados.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.cbAsignados.BorderRadius = 5;
            this.cbAsignados.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAsignados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsignados.FocusedColor = System.Drawing.Color.Empty;
            this.cbAsignados.FocusedState.Parent = this.cbAsignados;
            this.cbAsignados.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAsignados.ForeColor = System.Drawing.Color.Black;
            this.cbAsignados.FormattingEnabled = true;
            this.cbAsignados.HoverState.Parent = this.cbAsignados;
            this.cbAsignados.ItemHeight = 30;
            this.cbAsignados.Items.AddRange(new object[] {
            "Administrador",
            "Normal"});
            this.cbAsignados.ItemsAppearance.Parent = this.cbAsignados;
            this.cbAsignados.Location = new System.Drawing.Point(356, 632);
            this.cbAsignados.Name = "cbAsignados";
            this.cbAsignados.ShadowDecoration.Parent = this.cbAsignados;
            this.cbAsignados.Size = new System.Drawing.Size(248, 36);
            this.cbAsignados.TabIndex = 93;
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.cbTipoUsuario.BorderRadius = 5;
            this.cbTipoUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoUsuario.FocusedColor = System.Drawing.Color.Empty;
            this.cbTipoUsuario.FocusedState.Parent = this.cbTipoUsuario;
            this.cbTipoUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTipoUsuario.ForeColor = System.Drawing.Color.Black;
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.HoverState.Parent = this.cbTipoUsuario;
            this.cbTipoUsuario.ItemHeight = 30;
            this.cbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Normal"});
            this.cbTipoUsuario.ItemsAppearance.Parent = this.cbTipoUsuario;
            this.cbTipoUsuario.Location = new System.Drawing.Point(356, 568);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.ShadowDecoration.Parent = this.cbTipoUsuario;
            this.cbTipoUsuario.Size = new System.Drawing.Size(248, 36);
            this.cbTipoUsuario.TabIndex = 92;
            // 
            // txtCircuito
            // 
            this.txtCircuito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCircuito.BackColor = System.Drawing.Color.Transparent;
            this.txtCircuito.BaseColor = System.Drawing.Color.White;
            this.txtCircuito.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.txtCircuito.BorderSize = 1;
            this.txtCircuito.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCircuito.Enabled = false;
            this.txtCircuito.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCircuito.FocusedBorderColor = System.Drawing.Color.Aqua;
            this.txtCircuito.FocusedForeColor = System.Drawing.Color.Yellow;
            this.txtCircuito.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCircuito.ForeColor = System.Drawing.Color.Lime;
            this.txtCircuito.Location = new System.Drawing.Point(356, 501);
            this.txtCircuito.Name = "txtCircuito";
            this.txtCircuito.PasswordChar = '\0';
            this.txtCircuito.Radius = 5;
            this.txtCircuito.SelectedText = "";
            this.txtCircuito.Size = new System.Drawing.Size(248, 36);
            this.txtCircuito.TabIndex = 91;
            // 
            // txtJuntaAdm
            // 
            this.txtJuntaAdm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJuntaAdm.BackColor = System.Drawing.Color.Transparent;
            this.txtJuntaAdm.BaseColor = System.Drawing.Color.White;
            this.txtJuntaAdm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.txtJuntaAdm.BorderSize = 1;
            this.txtJuntaAdm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJuntaAdm.Enabled = false;
            this.txtJuntaAdm.FocusedBaseColor = System.Drawing.Color.White;
            this.txtJuntaAdm.FocusedBorderColor = System.Drawing.Color.Aqua;
            this.txtJuntaAdm.FocusedForeColor = System.Drawing.Color.Yellow;
            this.txtJuntaAdm.Font = new System.Drawing.Font("Arial", 9F);
            this.txtJuntaAdm.ForeColor = System.Drawing.Color.Lime;
            this.txtJuntaAdm.Location = new System.Drawing.Point(356, 440);
            this.txtJuntaAdm.Name = "txtJuntaAdm";
            this.txtJuntaAdm.PasswordChar = '\0';
            this.txtJuntaAdm.Radius = 5;
            this.txtJuntaAdm.SelectedText = "";
            this.txtJuntaAdm.Size = new System.Drawing.Size(248, 36);
            this.txtJuntaAdm.TabIndex = 90;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConsecutivo.BackColor = System.Drawing.Color.Transparent;
            this.txtConsecutivo.BaseColor = System.Drawing.Color.White;
            this.txtConsecutivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.txtConsecutivo.BorderSize = 1;
            this.txtConsecutivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsecutivo.Enabled = false;
            this.txtConsecutivo.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.txtConsecutivo.FocusedBorderColor = System.Drawing.Color.Aqua;
            this.txtConsecutivo.FocusedForeColor = System.Drawing.Color.Yellow;
            this.txtConsecutivo.Font = new System.Drawing.Font("Arial", 9F);
            this.txtConsecutivo.ForeColor = System.Drawing.Color.Lime;
            this.txtConsecutivo.Location = new System.Drawing.Point(356, 260);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.PasswordChar = '\0';
            this.txtConsecutivo.Radius = 5;
            this.txtConsecutivo.SelectedText = "";
            this.txtConsecutivo.Size = new System.Drawing.Size(248, 36);
            this.txtConsecutivo.TabIndex = 89;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.lbTitulo.Location = new System.Drawing.Point(235, 193);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(434, 29);
            this.lbTitulo.TabIndex = 88;
            this.lbTitulo.Text = "Registro de revisión AM consultores";
            // 
            // lbAsignado
            // 
            this.lbAsignado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAsignado.AutoSize = true;
            this.lbAsignado.BackColor = System.Drawing.Color.Transparent;
            this.lbAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAsignado.ForeColor = System.Drawing.Color.Black;
            this.lbAsignado.Location = new System.Drawing.Point(254, 632);
            this.lbAsignado.Name = "lbAsignado";
            this.lbAsignado.Size = new System.Drawing.Size(96, 18);
            this.lbAsignado.TabIndex = 87;
            this.lbAsignado.Text = "Asignado a:";
            // 
            // lbMedioReceptivo
            // 
            this.lbMedioReceptivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMedioReceptivo.AutoSize = true;
            this.lbMedioReceptivo.BackColor = System.Drawing.Color.Transparent;
            this.lbMedioReceptivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedioReceptivo.ForeColor = System.Drawing.Color.Black;
            this.lbMedioReceptivo.Location = new System.Drawing.Point(211, 559);
            this.lbMedioReceptivo.Name = "lbMedioReceptivo";
            this.lbMedioReceptivo.Size = new System.Drawing.Size(139, 18);
            this.lbMedioReceptivo.TabIndex = 86;
            this.lbMedioReceptivo.Text = "Medio Receptivo:";
            // 
            // lbCircuiton
            // 
            this.lbCircuiton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCircuiton.AutoSize = true;
            this.lbCircuiton.BackColor = System.Drawing.Color.Transparent;
            this.lbCircuiton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCircuiton.ForeColor = System.Drawing.Color.Black;
            this.lbCircuiton.Location = new System.Drawing.Point(278, 501);
            this.lbCircuiton.Name = "lbCircuiton";
            this.lbCircuiton.Size = new System.Drawing.Size(72, 18);
            this.lbCircuiton.TabIndex = 85;
            this.lbCircuiton.Text = "Circuito:";
            // 
            // lbJunta
            // 
            this.lbJunta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbJunta.AutoSize = true;
            this.lbJunta.BackColor = System.Drawing.Color.Transparent;
            this.lbJunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJunta.ForeColor = System.Drawing.Color.Black;
            this.lbJunta.Location = new System.Drawing.Point(237, 440);
            this.lbJunta.Name = "lbJunta";
            this.lbJunta.Size = new System.Drawing.Size(117, 18);
            this.lbJunta.TabIndex = 84;
            this.lbJunta.Text = "Jta Educ/Adm:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.BackColor = System.Drawing.Color.Wheat;
            this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.txtCodigo.BorderRadius = 4;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "";
            this.txtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.DisabledState.Parent = this.txtCodigo;
            this.txtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.FocusedState.Parent = this.txtCodigo;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.HoverState.Parent = this.txtCodigo;
            this.txtCodigo.Location = new System.Drawing.Point(356, 375);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.ShadowDecoration.Parent = this.txtCodigo;
            this.txtCodigo.Size = new System.Drawing.Size(248, 36);
            this.txtCodigo.TabIndex = 83;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AsignarCaso_KeyPress);
            // 
            // lbCodigo
            // 
            this.lbCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.Black;
            this.lbCodigo.Location = new System.Drawing.Point(284, 375);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(67, 18);
            this.lbCodigo.TabIndex = 82;
            this.lbCodigo.Text = "Codigo:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.BorderColor = System.Drawing.Color.White;
            this.dtpFecha.BorderRadius = 5;
            this.dtpFecha.BorderThickness = 1;
            this.dtpFecha.CheckedState.Parent = this.dtpFecha;
            this.dtpFecha.FillColor = System.Drawing.Color.White;
            this.dtpFecha.FocusedColor = System.Drawing.Color.White;
            this.dtpFecha.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFecha.HoverState.Parent = this.dtpFecha;
            this.dtpFecha.Location = new System.Drawing.Point(356, 318);
            this.dtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.ShadowDecoration.Parent = this.dtpFecha;
            this.dtpFecha.Size = new System.Drawing.Size(248, 36);
            this.dtpFecha.TabIndex = 81;
            this.dtpFecha.Value = new System.DateTime(2021, 6, 19, 0, 0, 0, 0);
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.Transparent;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.Black;
            this.lbFecha.Location = new System.Drawing.Point(291, 318);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(59, 18);
            this.lbFecha.TabIndex = 80;
            this.lbFecha.Text = "Fecha:";
            // 
            // lbConsecutivo
            // 
            this.lbConsecutivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbConsecutivo.AutoSize = true;
            this.lbConsecutivo.BackColor = System.Drawing.Color.Transparent;
            this.lbConsecutivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsecutivo.ForeColor = System.Drawing.Color.Black;
            this.lbConsecutivo.Location = new System.Drawing.Point(243, 260);
            this.lbConsecutivo.Name = "lbConsecutivo";
            this.lbConsecutivo.Size = new System.Drawing.Size(107, 18);
            this.lbConsecutivo.TabIndex = 79;
            this.lbConsecutivo.Text = "Consecutivo:";
            // 
            // AsignarCaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1041, 860);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AsignarCaso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AsignarCaso_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbAsignados;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipoUsuario;
        private Guna.UI.WinForms.GunaTextBox txtCircuito;
        private Guna.UI.WinForms.GunaTextBox txtJuntaAdm;
        private Guna.UI.WinForms.GunaTextBox txtConsecutivo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbAsignado;
        private System.Windows.Forms.Label lbMedioReceptivo;
        private System.Windows.Forms.Label lbCircuiton;
        private System.Windows.Forms.Label lbJunta;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbConsecutivo;
    }
}