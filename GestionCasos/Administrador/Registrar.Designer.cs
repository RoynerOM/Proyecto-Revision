
namespace GestionCasos
{
    partial class Registrar
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
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTipoUsuario = new System.Windows.Forms.Label();
            this.cbTipoUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new Guna.UI.WinForms.GunaButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.txtNombreUsuario = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaShadowPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.Controls.Add(this.panel2);
            this.gunaShadowPanel1.Controls.Add(this.btnClose);
            this.gunaShadowPanel1.Controls.Add(this.panel1);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(351, 551);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Location = new System.Drawing.Point(19, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 2);
            this.panel2.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(12, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "x";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.lbTipoUsuario);
            this.panel1.Controls.Add(this.cbTipoUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.gunaTextBox1);
            this.panel1.Controls.Add(this.txtNombreUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 458);
            this.panel1.TabIndex = 0;
            // 
            // lbTipoUsuario
            // 
            this.lbTipoUsuario.AutoSize = true;
            this.lbTipoUsuario.Font = new System.Drawing.Font("Arial", 11F);
            this.lbTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.lbTipoUsuario.Location = new System.Drawing.Point(59, 280);
            this.lbTipoUsuario.Name = "lbTipoUsuario";
            this.lbTipoUsuario.Size = new System.Drawing.Size(109, 17);
            this.lbTipoUsuario.TabIndex = 19;
            this.lbTipoUsuario.Text = "Tipo de Usuario";
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.cbTipoUsuario.BorderColor = System.Drawing.Color.SeaGreen;
            this.cbTipoUsuario.BorderRadius = 5;
            this.cbTipoUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.cbTipoUsuario.FocusedColor = System.Drawing.Color.Empty;
            this.cbTipoUsuario.FocusedState.Parent = this.cbTipoUsuario;
            this.cbTipoUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTipoUsuario.ForeColor = System.Drawing.Color.Lime;
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.HoverState.Parent = this.cbTipoUsuario;
            this.cbTipoUsuario.ItemHeight = 30;
            this.cbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Normal"});
            this.cbTipoUsuario.ItemsAppearance.Parent = this.cbTipoUsuario;
            this.cbTipoUsuario.Location = new System.Drawing.Point(62, 300);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.ShadowDecoration.Parent = this.cbTipoUsuario;
            this.cbTipoUsuario.Size = new System.Drawing.Size(201, 36);
            this.cbTipoUsuario.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F);
            this.label3.ForeColor = System.Drawing.Color.PowderBlue;
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Registrar";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AnimationHoverSpeed = 0.07F;
            this.btnRegistrar.AnimationSpeed = 0.03F;
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BaseColor = System.Drawing.Color.Black;
            this.btnRegistrar.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrar.BorderSize = 1;
            this.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = null;
            this.btnRegistrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRegistrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistrar.Location = new System.Drawing.Point(103, 384);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegistrar.OnHoverImage = null;
            this.btnRegistrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegistrar.Radius = 20;
            this.btnRegistrar.Size = new System.Drawing.Size(118, 40);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.gunaTextBox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.gunaTextBox1.BorderSize = 1;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.Aqua;
            this.gunaTextBox1.FocusedForeColor = System.Drawing.Color.White;
            this.gunaTextBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.gunaTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.gunaTextBox1.Location = new System.Drawing.Point(62, 227);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 5;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(201, 36);
            this.gunaTextBox1.TabIndex = 15;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreUsuario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtNombreUsuario.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNombreUsuario.BorderSize = 1;
            this.txtNombreUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreUsuario.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.txtNombreUsuario.FocusedBorderColor = System.Drawing.Color.Aqua;
            this.txtNombreUsuario.FocusedForeColor = System.Drawing.Color.White;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Arial", 9F);
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.Lime;
            this.txtNombreUsuario.Location = new System.Drawing.Point(62, 156);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PasswordChar = '\0';
            this.txtNombreUsuario.Radius = 5;
            this.txtNombreUsuario.SelectedText = "";
            this.txtNombreUsuario.Size = new System.Drawing.Size(201, 36);
            this.txtNombreUsuario.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula";
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(351, 551);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Registrar_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaTextBox txtNombreUsuario;
        private Guna.UI.WinForms.GunaButton btnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label lbTipoUsuario;
    }
}