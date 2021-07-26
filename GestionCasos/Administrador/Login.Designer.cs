
namespace GestionCasos
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIdentificacion = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.MaskedTextBox();
            this.lbIniciarSecion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.btnLLamar = new Guna.UI.WinForms.GunaCircleButton();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pbLogo = new Guna.UI.WinForms.GunaPictureBox();
            this.btnIniciarSecion = new Guna.UI.WinForms.GunaButton();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.btnIniciarSecion);
            this.pnTop.Controls.Add(this.label3);
            this.pnTop.Controls.Add(this.cbIdentificacion);
            this.pnTop.Controls.Add(this.btnRegistrar);
            this.pnTop.Controls.Add(this.txtContraseña);
            this.pnTop.Controls.Add(this.txtNombreUsuario);
            this.pnTop.Controls.Add(this.lbIniciarSecion);
            this.pnTop.Controls.Add(this.label2);
            this.pnTop.Controls.Add(this.lbNombreUsuario);
            this.pnTop.Location = new System.Drawing.Point(290, 365);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(298, 326);
            this.pnTop.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Identificación";
            // 
            // cbIdentificacion
            // 
            this.cbIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdentificacion.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdentificacion.FormattingEnabled = true;
            this.cbIdentificacion.Items.AddRange(new object[] {
            "Nacional",
            "Index"});
            this.cbIdentificacion.Location = new System.Drawing.Point(33, 82);
            this.cbIdentificacion.Name = "cbIdentificacion";
            this.cbIdentificacion.Size = new System.Drawing.Size(243, 27);
            this.cbIdentificacion.TabIndex = 19;
            this.cbIdentificacion.SelectedIndexChanged += new System.EventHandler(this.cbIdentificacion_SelectedIndexChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Cyan;
            this.btnRegistrar.Location = new System.Drawing.Point(105, 250);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(95, 18);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(33, 206);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(243, 27);
            this.txtContraseña.TabIndex = 17;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(33, 144);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(243, 27);
            this.txtNombreUsuario.TabIndex = 16;
            // 
            // lbIniciarSecion
            // 
            this.lbIniciarSecion.AutoSize = true;
            this.lbIniciarSecion.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIniciarSecion.ForeColor = System.Drawing.Color.White;
            this.lbIniciarSecion.Location = new System.Drawing.Point(74, 10);
            this.lbIniciarSecion.Name = "lbIniciarSecion";
            this.lbIniciarSecion.Size = new System.Drawing.Size(148, 26);
            this.lbIniciarSecion.TabIndex = 15;
            this.lbIniciarSecion.Text = "Iniciar Sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contraseña";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lbNombreUsuario.Location = new System.Drawing.Point(29, 118);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(70, 21);
            this.lbNombreUsuario.TabIndex = 11;
            this.lbNombreUsuario.Text = "Cédula";
            // 
            // btnLLamar
            // 
            this.btnLLamar.AnimationHoverSpeed = 0.07F;
            this.btnLLamar.AnimationSpeed = 0.03F;
            this.btnLLamar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLLamar.BaseColor = System.Drawing.Color.White;
            this.btnLLamar.BorderColor = System.Drawing.Color.Black;
            this.btnLLamar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLLamar.FocusedColor = System.Drawing.Color.Empty;
            this.btnLLamar.Font = new System.Drawing.Font("Arial", 18F);
            this.btnLLamar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.btnLLamar.Image = null;
            this.btnLLamar.ImageSize = new System.Drawing.Size(52, 52);
            this.btnLLamar.Location = new System.Drawing.Point(369, 102);
            this.btnLLamar.Name = "btnLLamar";
            this.btnLLamar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.btnLLamar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.btnLLamar.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.btnLLamar.OnHoverImage = null;
            this.btnLLamar.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLLamar.Size = new System.Drawing.Size(140, 141);
            this.btnLLamar.TabIndex = 13;
            this.btnLLamar.Text = "Login";
            this.btnLLamar.Click += new System.EventHandler(this.btnLLamar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Image = global::GestionCasos.Properties.Resources.close;
            this.btnCerrar.Location = new System.Drawing.Point(12, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 28);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.BaseColor = System.Drawing.Color.White;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Image = global::GestionCasos.Properties.Resources.Logo_AMCONSULTORES1;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(273, 350);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 14;
            this.pbLogo.TabStop = false;
            // 
            // btnIniciarSecion
            // 
            this.btnIniciarSecion.AnimationHoverSpeed = 0.07F;
            this.btnIniciarSecion.AnimationSpeed = 0.03F;
            this.btnIniciarSecion.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSecion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.btnIniciarSecion.BorderColor = System.Drawing.Color.Empty;
            this.btnIniciarSecion.BorderSize = 1;
            this.btnIniciarSecion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIniciarSecion.FocusedColor = System.Drawing.Color.Empty;
            this.btnIniciarSecion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSecion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSecion.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciarSecion.Image")));
            this.btnIniciarSecion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnIniciarSecion.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIniciarSecion.Location = new System.Drawing.Point(84, 285);
            this.btnIniciarSecion.Name = "btnIniciarSecion";
            this.btnIniciarSecion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.btnIniciarSecion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIniciarSecion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIniciarSecion.OnHoverImage = null;
            this.btnIniciarSecion.OnPressedColor = System.Drawing.Color.Black;
            this.btnIniciarSecion.Radius = 20;
            this.btnIniciarSecion.Size = new System.Drawing.Size(138, 38);
            this.btnIniciarSecion.TabIndex = 21;
            this.btnIniciarSecion.Text = "ACCEDER";
            this.btnIniciarSecion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIniciarSecion.Click += new System.EventHandler(this.btnIniciarSecion_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.btnLLamar);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbIniciarSecion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNombreUsuario;
        private Guna.UI.WinForms.GunaCircleButton btnLLamar;
        private Guna.UI.WinForms.GunaPictureBox pbLogo;
        private System.Windows.Forms.MaskedTextBox txtNombreUsuario;
        private System.Windows.Forms.Label btnRegistrar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIdentificacion;
        private Guna.UI.WinForms.GunaButton btnIniciarSecion;
    }
}