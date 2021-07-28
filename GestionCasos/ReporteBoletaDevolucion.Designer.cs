
namespace GestionCasos
{
    partial class ReporteBoletaDevolucion
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
            this.BD_JuntasDataSet3 = new GestionCasos.BD_JuntasDataSet3();
            this.viewBoletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewBoletaTableAdapter = new GestionCasos.BD_JuntasDataSet3TableAdapters.viewBoletaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD_JuntasDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBoletaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.viewBoletaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionCasos.rptBoleta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(850, 503);
            this.reportViewer1.TabIndex = 0;
            // 
            // BD_JuntasDataSet3
            // 
            this.BD_JuntasDataSet3.DataSetName = "BD_JuntasDataSet3";
            this.BD_JuntasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewBoletaBindingSource
            // 
            this.viewBoletaBindingSource.DataMember = "viewBoleta";
            this.viewBoletaBindingSource.DataSource = this.BD_JuntasDataSet3;
            // 
            // viewBoletaTableAdapter
            // 
            this.viewBoletaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteBoletaDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 503);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReporteBoletaDevolucion";
            this.Text = "ReporteBoletaDevolucion";
            this.Load += new System.EventHandler(this.ReporteBoletaDevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD_JuntasDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBoletaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource viewBoletaBindingSource;
        private BD_JuntasDataSet3 BD_JuntasDataSet3;
        private BD_JuntasDataSet3TableAdapters.viewBoletaTableAdapter viewBoletaTableAdapter;
    }
}