
namespace GestionCasos
{
    partial class ReporteAsignarCasos
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
            this.BD_JuntasDataSet = new GestionCasos.BD_JuntasDataSet();
            this.CasosAsignadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CasosAsignadosTableAdapter = new GestionCasos.BD_JuntasDataSetTableAdapters.CasosAsignadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD_JuntasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CasosAsignadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsCasosAsignados";
            reportDataSource1.Value = this.CasosAsignadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionCasos.Reportes.ReporteCasosAsignados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // BD_JuntasDataSet
            // 
            this.BD_JuntasDataSet.DataSetName = "BD_JuntasDataSet";
            this.BD_JuntasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CasosAsignadosBindingSource
            // 
            this.CasosAsignadosBindingSource.DataMember = "CasosAsignados";
            this.CasosAsignadosBindingSource.DataSource = this.BD_JuntasDataSet;
            // 
            // CasosAsignadosTableAdapter
            // 
            this.CasosAsignadosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteAsignarCasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteAsignarCasos";
            this.Text = "ReporteAsignarCasos";
            this.Load += new System.EventHandler(this.ReporteAsignarCasos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD_JuntasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CasosAsignadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CasosAsignadosBindingSource;
        private BD_JuntasDataSet BD_JuntasDataSet;
        private BD_JuntasDataSetTableAdapters.CasosAsignadosTableAdapter CasosAsignadosTableAdapter;
    }
}