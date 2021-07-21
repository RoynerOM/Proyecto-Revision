
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
            this.CasosAsignadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_JuntasDataSet = new GestionCasos.BD_JuntasDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CasosAsignadosTableAdapter = new GestionCasos.BD_JuntasDataSetTableAdapters.CasosAsignadosTableAdapter();
            this.t_RevisionTableAdapter1 = new GestionCasos.BD_JuntasDataSetTableAdapters.t_RevisionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CasosAsignadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_JuntasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CasosAsignadosBindingSource
            // 
            this.CasosAsignadosBindingSource.DataMember = "CasosAsignados";
            this.CasosAsignadosBindingSource.DataSource = this.BD_JuntasDataSet;
            // 
            // BD_JuntasDataSet
            // 
            this.BD_JuntasDataSet.DataSetName = "BD_JuntasDataSet";
            this.BD_JuntasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // CasosAsignadosTableAdapter
            // 
            this.CasosAsignadosTableAdapter.ClearBeforeFill = true;
            // 
            // t_RevisionTableAdapter1
            // 
            this.t_RevisionTableAdapter1.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.CasosAsignadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_JuntasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CasosAsignadosBindingSource;
        private BD_JuntasDataSet BD_JuntasDataSet;
        private BD_JuntasDataSetTableAdapters.CasosAsignadosTableAdapter CasosAsignadosTableAdapter;
        private BD_JuntasDataSetTableAdapters.t_RevisionTableAdapter t_RevisionTableAdapter1;
    }
}