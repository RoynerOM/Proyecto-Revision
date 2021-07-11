
namespace GestionCasos
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pnLateralIzquierda = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnCerrarSecion = new System.Windows.Forms.Button();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.process1 = new System.Diagnostics.Process();
            this.pnLateralIzquierda.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLateralIzquierda
            // 
            this.pnLateralIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.pnLateralIzquierda.Controls.Add(this.btnMenu);
            this.pnLateralIzquierda.Controls.Add(this.btnDashBoard);
            this.pnLateralIzquierda.Controls.Add(this.btnCerrarSecion);
            this.pnLateralIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLateralIzquierda.ForeColor = System.Drawing.Color.Black;
            this.pnLateralIzquierda.Location = new System.Drawing.Point(0, 0);
            this.pnLateralIzquierda.Name = "pnLateralIzquierda";
            this.pnLateralIzquierda.Size = new System.Drawing.Size(111, 661);
            this.pnLateralIzquierda.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btnMenu.Image = global::GestionCasos.Properties.Resources.squared_menu_60px;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenu.Location = new System.Drawing.Point(0, 92);
            this.btnMenu.MinimumSize = new System.Drawing.Size(111, 90);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(111, 90);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btnDashBoard.Image = global::GestionCasos.Properties.Resources.dashboard_60px;
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 1);
            this.btnDashBoard.MinimumSize = new System.Drawing.Size(111, 90);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(111, 90);
            this.btnDashBoard.TabIndex = 8;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnCerrarSecion
            // 
            this.btnCerrarSecion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrarSecion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSecion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSecion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCerrarSecion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSecion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btnCerrarSecion.Image = global::GestionCasos.Properties.Resources.sign_out_60px1;
            this.btnCerrarSecion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrarSecion.Location = new System.Drawing.Point(0, 571);
            this.btnCerrarSecion.Name = "btnCerrarSecion";
            this.btnCerrarSecion.Size = new System.Drawing.Size(111, 87);
            this.btnCerrarSecion.TabIndex = 3;
            this.btnCerrarSecion.Text = "Cerrar Seción";
            this.btnCerrarSecion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarSecion.UseVisualStyleBackColor = false;
            this.btnCerrarSecion.Click += new System.EventHandler(this.btnCerrarSecion_Click);
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(111, 0);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(1025, 661);
            this.DesktopPanel.TabIndex = 1;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1136, 661);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.pnLateralIzquierda);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1152, 700);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pnLateralIzquierda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrarSecion;
        private System.Windows.Forms.Panel pnLateralIzquierda;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Panel DesktopPanel;
        private System.Windows.Forms.Button btnMenu;
        private System.Diagnostics.Process process1;
    }
}