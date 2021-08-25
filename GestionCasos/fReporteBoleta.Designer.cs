
namespace GestionCasos
{
    partial class fReporteBoleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReporteBoleta));
            this.BoletaTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsBoleta = new GestionCasos.dtsBoleta();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BoletaTableTableAdapter = new GestionCasos.dtsBoletaTableAdapters.BoletaTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BoletaTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsBoleta)).BeginInit();
            this.SuspendLayout();
            // 
            // BoletaTableBindingSource
            // 
            this.BoletaTableBindingSource.DataMember = "BoletaTable";
            this.BoletaTableBindingSource.DataSource = this.dtsBoleta;
            // 
            // dtsBoleta
            // 
            this.dtsBoleta.DataSetName = "dtsBoleta";
            this.dtsBoleta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dtsBoleta";
            reportDataSource1.Value = this.BoletaTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionCasos.Reportes.rptBoleta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // BoletaTableTableAdapter
            // 
            this.BoletaTableTableAdapter.ClearBeforeFill = true;
            // 
            // fReporteBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fReporteBoleta";
            this.Text = "fReporteBoleta";
            this.Load += new System.EventHandler(this.fReporteBoleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoletaTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsBoleta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BoletaTableBindingSource;
        private dtsBoleta dtsBoleta;
        private dtsBoletaTableAdapters.BoletaTableTableAdapter BoletaTableTableAdapter;
    }
}