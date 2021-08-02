
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLinePanel3 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.txtBuscar1 = new System.Windows.Forms.Button();
            this.cbReception = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtsCasos = new GestionCasos.dtsCasos();
            this.CasosTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CasosTableTableAdapter = new GestionCasos.dtsCasosTableAdapters.CasosTableTableAdapter();
            this.panel1.SuspendLayout();
            this.gunaLinePanel3.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCasos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CasosTableBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.reportViewer1.Size = new System.Drawing.Size(800, 351);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gunaLinePanel3);
            this.panel1.Controls.Add(this.gunaLinePanel2);
            this.panel1.Controls.Add(this.gunaLinePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 99);
            this.panel1.TabIndex = 1;
            // 
            // gunaLinePanel3
            // 
            this.gunaLinePanel3.Controls.Add(this.btnRefrescar);
            this.gunaLinePanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLinePanel3.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel3.LineRight = 2;
            this.gunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel3.Location = new System.Drawing.Point(719, 0);
            this.gunaLinePanel3.Name = "gunaLinePanel3";
            this.gunaLinePanel3.Size = new System.Drawing.Size(78, 99);
            this.gunaLinePanel3.TabIndex = 23;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(0, 52);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(76, 47);
            this.btnRefrescar.TabIndex = 23;
            this.btnRefrescar.Text = "Refrescar ";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Controls.Add(this.btnBuscar2);
            this.gunaLinePanel2.Controls.Add(this.label6);
            this.gunaLinePanel2.Controls.Add(this.dtpFechaInicio);
            this.gunaLinePanel2.Controls.Add(this.label2);
            this.gunaLinePanel2.Controls.Add(this.dtpFechaFinal);
            this.gunaLinePanel2.Controls.Add(this.label3);
            this.gunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel2.LineRight = 2;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(290, 0);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(429, 99);
            this.gunaLinePanel2.TabIndex = 16;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Location = new System.Drawing.Point(335, 75);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(83, 21);
            this.btnBuscar2.TabIndex = 21;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Filtrar por rango de fechas:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(12, 49);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 18;
            this.dtpFechaInicio.Value = new System.DateTime(2021, 7, 27, 20, 12, 13, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha de inicio";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(218, 49);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 17;
            this.dtpFechaFinal.Value = new System.DateTime(2021, 7, 27, 20, 12, 19, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha Final";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinePanel1.Controls.Add(this.txtBuscar1);
            this.gunaLinePanel1.Controls.Add(this.cbReception);
            this.gunaLinePanel1.Controls.Add(this.label4);
            this.gunaLinePanel1.Controls.Add(this.label5);
            this.gunaLinePanel1.Controls.Add(this.txtConsecutivo);
            this.gunaLinePanel1.Controls.Add(this.label1);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineRight = 2;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(290, 99);
            this.gunaLinePanel1.TabIndex = 2;
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Location = new System.Drawing.Point(197, 75);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(81, 21);
            this.txtBuscar1.TabIndex = 22;
            this.txtBuscar1.Text = "Buscar";
            this.txtBuscar1.UseVisualStyleBackColor = true;
            this.txtBuscar1.Click += new System.EventHandler(this.txtBuscar1_Click);
            // 
            // cbReception
            // 
            this.cbReception.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReception.FormattingEnabled = true;
            this.cbReception.Items.AddRange(new object[] {
            "",
            "MENSAJERO",
            "CORREO",
            "WHATSAPP",
            "OFICINA"});
            this.cbReception.Location = new System.Drawing.Point(125, 49);
            this.cbReception.Name = "cbReception";
            this.cbReception.Size = new System.Drawing.Size(153, 21);
            this.cbReception.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Recepción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Filtrar por:";
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Location = new System.Drawing.Point(7, 49);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(107, 20);
            this.txtConsecutivo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Consecutivo";
            // 
            // dtsCasos
            // 
            this.dtsCasos.DataSetName = "dtsCasos";
            this.dtsCasos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CasosTableBindingSource
            // 
            this.CasosTableBindingSource.DataMember = "CasosTable";
            this.CasosTableBindingSource.DataSource = this.dtsCasos;
            // 
            // CasosTableTableAdapter
            // 
            this.CasosTableTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCasosAsignados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "ReporteCasosAsignados";
            this.Text = "ReporteCasosAsignados";
            this.Load += new System.EventHandler(this.ReporteCasosAsignados_Load);
            this.panel1.ResumeLayout(false);
            this.gunaLinePanel3.ResumeLayout(false);
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCasos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CasosTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.ComboBox cbReception;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Button txtBuscar1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel3;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.BindingSource CasosTableBindingSource;
        private dtsCasos dtsCasos;
        private dtsCasosTableAdapters.CasosTableTableAdapter CasosTableTableAdapter;
    }
}