
namespace GestionCasos
{
    partial class ReporteJuntas
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
            this.dbsJuntas = new GestionCasos.dbsJuntas();
            this.dbsJuntasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dbsJuntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsJuntasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsJuntas";
            reportDataSource1.Value = this.dbsJuntasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionCasos.Reportes.ReporteJuntas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(884, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbsJuntas
            // 
            this.dbsJuntas.DataSetName = "dbsJuntas";
            this.dbsJuntas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbsJuntasBindingSource
            // 
            this.dbsJuntasBindingSource.DataSource = this.dbsJuntas;
            this.dbsJuntasBindingSource.Position = 0;
            // 
            // ReporteJuntas
            // 
            this.ClientSize = new System.Drawing.Size(884, 446);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteJuntas";
            this.Load += new System.EventHandler(this.ReporteJuntas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dbsJuntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsJuntasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource JuntasBindingSource;
        private BD_JuntasDataSet1 BD_JuntasDataSet1;
        private BD_JuntasDataSet1TableAdapters.JuntasTableAdapter JuntasTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dbsJuntas dbsJuntas;
        private System.Windows.Forms.BindingSource dbsJuntasBindingSource;
    }
}