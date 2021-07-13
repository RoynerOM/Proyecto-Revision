
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
            this.BD_JuntasDataSet1 = new GestionCasos.BD_JuntasDataSet1();
            this.JuntasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JuntasTableAdapter = new GestionCasos.BD_JuntasDataSet1TableAdapters.JuntasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD_JuntasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuntasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsJuntas";
            reportDataSource1.Value = this.JuntasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionCasos.Reportes.ReporteJuntas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // BD_JuntasDataSet1
            // 
            this.BD_JuntasDataSet1.DataSetName = "BD_JuntasDataSet1";
            this.BD_JuntasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // JuntasBindingSource
            // 
            this.JuntasBindingSource.DataMember = "Juntas";
            this.JuntasBindingSource.DataSource = this.BD_JuntasDataSet1;
            // 
            // JuntasTableAdapter
            // 
            this.JuntasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteJuntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteJuntas";
            this.Text = "ReporteJuntas";
            this.Load += new System.EventHandler(this.ReporteJuntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD_JuntasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuntasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource JuntasBindingSource;
        private BD_JuntasDataSet1 BD_JuntasDataSet1;
        private BD_JuntasDataSet1TableAdapters.JuntasTableAdapter JuntasTableAdapter;
    }
}