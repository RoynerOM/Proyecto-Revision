
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BD_JuntasDataSet2 = new GestionCasos.BD_JuntasDataSet2();
            this.EntregaDeCasosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EntregaDeCasosTableAdapter = new GestionCasos.BD_JuntasDataSet2TableAdapters.EntregaDeCasosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD_JuntasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntregaDeCasosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dtEntregaDeCasos";
            reportDataSource1.Value = this.EntregaDeCasosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionCasos.Reportes.EntragaDeCasos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 1;
            // 
            // BD_JuntasDataSet2
            // 
            this.BD_JuntasDataSet2.DataSetName = "BD_JuntasDataSet2";
            this.BD_JuntasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EntregaDeCasosBindingSource
            // 
            this.EntregaDeCasosBindingSource.DataMember = "EntregaDeCasos";
            this.EntregaDeCasosBindingSource.DataSource = this.BD_JuntasDataSet2;
            // 
            // EntregaDeCasosTableAdapter
            // 
            this.EntregaDeCasosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEntregaDeCasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteEntregaDeCasos";
            this.Text = "ReporteEntregaDeCasos";
            this.Load += new System.EventHandler(this.ReporteEntregaDeCasos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD_JuntasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntregaDeCasosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EntregaDeCasosBindingSource;
        private BD_JuntasDataSet2 BD_JuntasDataSet2;
        private BD_JuntasDataSet2TableAdapters.EntregaDeCasosTableAdapter EntregaDeCasosTableAdapter;
    }
}