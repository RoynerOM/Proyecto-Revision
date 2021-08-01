
namespace GestionCasos
{
    partial class ReporteContadores
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
            this.ContadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_JuntasDataSet1 = new GestionCasos.BD_JuntasDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ContadoresTableAdapter = new GestionCasos.BD_JuntasDataSet1TableAdapters.ContadoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ContadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_JuntasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContadoresBindingSource
            // 
            this.ContadoresBindingSource.DataMember = "Contadores";
            this.ContadoresBindingSource.DataSource = this.BD_JuntasDataSet1;
            // 
            // BD_JuntasDataSet1
            // 
            this.BD_JuntasDataSet1.DataSetName = "BD_JuntasDataSet1";
            this.BD_JuntasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsContadores";
            reportDataSource1.Value = this.ContadoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionCasos.Reportes.ReporteContadores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ContadoresTableAdapter
            // 
            this.ContadoresTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteContadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteContadores";
            this.Text = "ReporteContadores";
            this.Load += new System.EventHandler(this.ReporteContadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_JuntasDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ContadoresBindingSource;
        private BD_JuntasDataSet1 BD_JuntasDataSet1;
        private BD_JuntasDataSet1TableAdapters.ContadoresTableAdapter ContadoresTableAdapter;
    }
}