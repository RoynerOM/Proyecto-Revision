﻿
namespace GestionCasos
{
    partial class ReporteEntregaDeCasos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EntregaTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsEntregaCasos = new GestionCasos.dtsEntregaCasos();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.cbContadores = new System.Windows.Forms.ComboBox();
            this.txtInstitucion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbCircuito = new System.Windows.Forms.ComboBox();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EntregaTableTableAdapter = new GestionCasos.dtsEntregaCasosTableAdapters.EntregaTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EntregaTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsEntregaCasos)).BeginInit();
            this.panel1.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntregaTableBindingSource
            // 
            this.EntregaTableBindingSource.DataMember = "EntregaTable";
            this.EntregaTableBindingSource.DataSource = this.dtsEntregaCasos;
            // 
            // dtsEntregaCasos
            // 
            this.dtsEntregaCasos.DataSetName = "dtsEntregaCasos";
            this.dtsEntregaCasos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gunaLinePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 93);
            this.panel1.TabIndex = 3;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinePanel1.Controls.Add(this.btnRefrescar);
            this.gunaLinePanel1.Controls.Add(this.cbContadores);
            this.gunaLinePanel1.Controls.Add(this.txtInstitucion);
            this.gunaLinePanel1.Controls.Add(this.txtCodigo);
            this.gunaLinePanel1.Controls.Add(this.cbCircuito);
            this.gunaLinePanel1.Controls.Add(this.txtConsecutivo);
            this.gunaLinePanel1.Controls.Add(this.label7);
            this.gunaLinePanel1.Controls.Add(this.label3);
            this.gunaLinePanel1.Controls.Add(this.label2);
            this.gunaLinePanel1.Controls.Add(this.label4);
            this.gunaLinePanel1.Controls.Add(this.label5);
            this.gunaLinePanel1.Controls.Add(this.label1);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLinePanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLinePanel1.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(834, 93);
            this.gunaLinePanel1.TabIndex = 2;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Image = global::GestionCasos.Properties.Resources.synchronize_20px;
            this.btnRefrescar.Location = new System.Drawing.Point(773, 5);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(57, 30);
            this.btnRefrescar.TabIndex = 39;
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // cbContadores
            // 
            this.cbContadores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbContadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContadores.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbContadores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContadores.ForeColor = System.Drawing.Color.Black;
            this.cbContadores.FormattingEnabled = true;
            this.cbContadores.Items.AddRange(new object[] {
            ""});
            this.cbContadores.Location = new System.Drawing.Point(599, 57);
            this.cbContadores.Name = "cbContadores";
            this.cbContadores.Size = new System.Drawing.Size(231, 25);
            this.cbContadores.TabIndex = 4;
            this.cbContadores.SelectedIndexChanged += new System.EventHandler(this.cbContadores_SelectedIndexChanged);
            // 
            // txtInstitucion
            // 
            this.txtInstitucion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstitucion.ForeColor = System.Drawing.Color.Black;
            this.txtInstitucion.Location = new System.Drawing.Point(422, 57);
            this.txtInstitucion.Name = "txtInstitucion";
            this.txtInstitucion.Size = new System.Drawing.Size(146, 25);
            this.txtInstitucion.TabIndex = 3;
            this.txtInstitucion.TextChanged += new System.EventHandler(this.txtInstitucion_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.Location = new System.Drawing.Point(274, 57);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(117, 25);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // cbCircuito
            // 
            this.cbCircuito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCircuito.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCircuito.ForeColor = System.Drawing.Color.Black;
            this.cbCircuito.FormattingEnabled = true;
            this.cbCircuito.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbCircuito.Location = new System.Drawing.Point(159, 57);
            this.cbCircuito.Name = "cbCircuito";
            this.cbCircuito.Size = new System.Drawing.Size(78, 25);
            this.cbCircuito.TabIndex = 1;
            this.cbCircuito.SelectedIndexChanged += new System.EventHandler(this.cbCircuito_SelectedIndexChanged);
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsecutivo.ForeColor = System.Drawing.Color.Black;
            this.txtConsecutivo.Location = new System.Drawing.Point(7, 58);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(119, 25);
            this.txtConsecutivo.TabIndex = 0;
            this.txtConsecutivo.TextChanged += new System.EventHandler(this.txtConsecutivo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(596, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Persona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(419, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Institución";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(271, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(156, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Circuito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Filtrar por";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Consecutivo";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 66;
            reportDataSource1.Name = "dtsEntregaCasos";
            reportDataSource1.Value = this.EntregaTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionCasos.Reportes.ReporteEntregaDeCasos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 93);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(834, 468);
            this.reportViewer1.TabIndex = 4;
            // 
            // EntregaTableTableAdapter
            // 
            this.EntregaTableTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEntregaDeCasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "ReporteEntregaDeCasos";
            this.Text = "ReporteEntregaDeCasos";
            this.Load += new System.EventHandler(this.ReporteEntregaDeCasos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EntregaTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsEntregaCasos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbCircuito;
        private System.Windows.Forms.TextBox txtInstitucion;
        private System.Windows.Forms.ComboBox cbContadores;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.BindingSource EntregaTableBindingSource;
        private dtsEntregaCasos dtsEntregaCasos;
        private dtsEntregaCasosTableAdapters.EntregaTableTableAdapter EntregaTableTableAdapter;
    }
}