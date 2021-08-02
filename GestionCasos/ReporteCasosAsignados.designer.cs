
namespace GestionCasos
{
    partial class ReporteCasosAsignados
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
            this.CasosTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsCasos = new GestionCasos.dtsCasos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.dtpFechaFinal = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.dtpFechaInicio = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.cbReception = new Guna.UI.WinForms.GunaComboBox();
            this.txtConsecutivo = new Guna.UI.WinForms.GunaTextBox();
            this.txtBuscar1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CasosTableTableAdapter = new GestionCasos.dtsCasosTableAdapters.CasosTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CasosTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCasos)).BeginInit();
            this.panel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CasosTableBindingSource
            // 
            this.CasosTableBindingSource.DataMember = "CasosTable";
            this.CasosTableBindingSource.DataSource = this.dtsCasos;
            // 
            // dtsCasos
            // 
            this.dtsCasos.DataSetName = "dtsCasos";
            this.dtsCasos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dtsCasos";
            reportDataSource1.Value = this.CasosTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionCasos.Reportes.ReporteCasosAsignados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 99);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(820, 501);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gunaLinePanel2);
            this.panel1.Controls.Add(this.gunaLinePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 99);
            this.panel1.TabIndex = 1;
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.btnRefrescar);
            this.gunaLinePanel2.Controls.Add(this.dtpFechaFinal);
            this.gunaLinePanel2.Controls.Add(this.btnBuscar2);
            this.gunaLinePanel2.Controls.Add(this.dtpFechaInicio);
            this.gunaLinePanel2.Controls.Add(this.label6);
            this.gunaLinePanel2.Controls.Add(this.label2);
            this.gunaLinePanel2.Controls.Add(this.label3);
            this.gunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLinePanel2.LineLeft = 1;
            this.gunaLinePanel2.LineRight = 1;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(362, 0);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(458, 99);
            this.gunaLinePanel2.TabIndex = 16;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefrescar.Image = global::GestionCasos.Properties.Resources.synchronize_20px;
            this.btnRefrescar.Location = new System.Drawing.Point(381, 61);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(65, 31);
            this.btnRefrescar.TabIndex = 23;
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.BaseColor = System.Drawing.Color.White;
            this.dtpFechaFinal.BorderColor = System.Drawing.Color.Silver;
            this.dtpFechaFinal.BorderSize = 1;
            this.dtpFechaFinal.CustomFormat = null;
            this.dtpFechaFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaFinal.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaFinal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaFinal.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(151, 62);
            this.dtpFechaFinal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaFinal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFechaFinal.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaFinal.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaFinal.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFechaFinal.Size = new System.Drawing.Size(130, 30);
            this.dtpFechaFinal.TabIndex = 22;
            this.dtpFechaFinal.Text = "02/08/2021";
            this.dtpFechaFinal.Value = new System.DateTime(2021, 8, 2, 16, 18, 30, 574);
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(102)))), ((int)(((byte)(214)))));
            this.btnBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar2.ForeColor = System.Drawing.Color.White;
            this.btnBuscar2.Location = new System.Drawing.Point(292, 61);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(83, 31);
            this.btnBuscar2.TabIndex = 21;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = false;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.BaseColor = System.Drawing.Color.White;
            this.dtpFechaInicio.BorderColor = System.Drawing.Color.Silver;
            this.dtpFechaInicio.BorderSize = 1;
            this.dtpFechaInicio.CustomFormat = null;
            this.dtpFechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaInicio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(15, 62);
            this.dtpFechaInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaInicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFechaInicio.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaInicio.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaInicio.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFechaInicio.Size = new System.Drawing.Size(130, 30);
            this.dtpFechaInicio.TabIndex = 2;
            this.dtpFechaInicio.Text = "02/08/2021";
            this.dtpFechaInicio.Value = new System.DateTime(2021, 8, 2, 16, 17, 47, 487);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Filtrar por rango de fechas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha Final";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinePanel1.Controls.Add(this.cbReception);
            this.gunaLinePanel1.Controls.Add(this.txtConsecutivo);
            this.gunaLinePanel1.Controls.Add(this.txtBuscar1);
            this.gunaLinePanel1.Controls.Add(this.label4);
            this.gunaLinePanel1.Controls.Add(this.label5);
            this.gunaLinePanel1.Controls.Add(this.label1);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.DarkGray;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(362, 99);
            this.gunaLinePanel1.TabIndex = 2;
            // 
            // cbReception
            // 
            this.cbReception.BackColor = System.Drawing.Color.Transparent;
            this.cbReception.BaseColor = System.Drawing.Color.White;
            this.cbReception.BorderColor = System.Drawing.Color.Silver;
            this.cbReception.BorderSize = 1;
            this.cbReception.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbReception.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReception.FocusedColor = System.Drawing.Color.Empty;
            this.cbReception.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReception.ForeColor = System.Drawing.Color.Black;
            this.cbReception.FormattingEnabled = true;
            this.cbReception.Location = new System.Drawing.Point(144, 62);
            this.cbReception.Name = "cbReception";
            this.cbReception.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbReception.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbReception.Size = new System.Drawing.Size(121, 30);
            this.cbReception.TabIndex = 24;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.BaseColor = System.Drawing.Color.White;
            this.txtConsecutivo.BorderColor = System.Drawing.Color.Silver;
            this.txtConsecutivo.BorderSize = 1;
            this.txtConsecutivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsecutivo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtConsecutivo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtConsecutivo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConsecutivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsecutivo.Location = new System.Drawing.Point(8, 62);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.PasswordChar = '\0';
            this.txtConsecutivo.SelectedText = "";
            this.txtConsecutivo.Size = new System.Drawing.Size(129, 30);
            this.txtConsecutivo.TabIndex = 23;
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(102)))), ((int)(((byte)(214)))));
            this.txtBuscar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtBuscar1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar1.ForeColor = System.Drawing.Color.White;
            this.txtBuscar1.Location = new System.Drawing.Point(273, 61);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(81, 31);
            this.txtBuscar1.TabIndex = 22;
            this.txtBuscar1.Text = "Buscar";
            this.txtBuscar1.UseVisualStyleBackColor = false;
            this.txtBuscar1.Click += new System.EventHandler(this.txtBuscar1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Recepción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Filtrar por";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Consecutivo";
            // 
            // CasosTableTableAdapter
            // 
            this.CasosTableTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCasosAsignados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 600);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(820, 600);
            this.Name = "ReporteCasosAsignados";
            this.Text = "ReporteCasosAsignados";
            this.Load += new System.EventHandler(this.ReporteCasosAsignados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CasosTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCasos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Button txtBuscar1;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.BindingSource CasosTableBindingSource;
        private dtsCasos dtsCasos;
        private dtsCasosTableAdapters.CasosTableTableAdapter CasosTableTableAdapter;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFechaFinal;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFechaInicio;
        private Guna.UI.WinForms.GunaTextBox txtConsecutivo;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaComboBox cbReception;
    }
}