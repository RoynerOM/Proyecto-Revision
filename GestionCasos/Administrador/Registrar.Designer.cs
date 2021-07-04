
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTipoUsuario = new System.Windows.Forms.Label();
            this.cbTipoUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new Guna.UI.WinForms.GunaButton();
            this.txtContra = new Guna.UI.WinForms.GunaTextBox();
            this.txtCedula = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbTipoUsuario);
            this.panel3.Controls.Add(this.cbTipoUsuario);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnRegistrar);
            this.panel3.Controls.Add(this.txtContra);
            this.panel3.Controls.Add(this.txtCedula);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(198, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 650);
            this.panel3.TabIndex = 4;
            // 
            // lbTipoUsuario
            // 
            this.lbTipoUsuario.AutoSize = true;
            this.lbTipoUsuario.Font = new System.Drawing.Font("Arial", 13F);
            this.lbTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.lbTipoUsuario.Location = new System.Drawing.Point(183, 376);
            this.lbTipoUsuario.Name = "lbTipoUsuario";
            this.lbTipoUsuario.Size = new System.Drawing.Size(137, 21);
            this.lbTipoUsuario.TabIndex = 19;
            this.lbTipoUsuario.Text = "Tipo de Usuario";
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.BackColor = System.Drawing.Color.White;
            this.cbTipoUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.cbTipoUsuario.BorderRadius = 5;
            this.cbTipoUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoUsuario.FocusedColor = System.Drawing.Color.Empty;
            this.cbTipoUsuario.FocusedState.Parent = this.cbTipoUsuario;
            this.cbTipoUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTipoUsuario.ForeColor = System.Drawing.Color.Black;
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.HoverState.Parent = this.cbTipoUsuario;
            this.cbTipoUsuario.ItemHeight = 30;
            this.cbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Normal"});
            this.cbTipoUsuario.ItemsAppearance.Parent = this.cbTipoUsuario;
            this.cbTipoUsuario.Location = new System.Drawing.Point(187, 400);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.ShadowDecoration.Parent = this.cbTipoUsuario;
            this.cbTipoUsuario.Size = new System.Drawing.Size(263, 36);
            this.cbTipoUsuario.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(55, 42);
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
            this.btnRegistrar.BaseColor = System.Drawing.Color.White;
            this.btnRegistrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.btnRegistrar.BorderSize = 1;
            this.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Image = null;
            this.btnRegistrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRegistrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistrar.Location = new System.Drawing.Point(261, 526);
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
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.Color.Transparent;
            this.txtContra.BaseColor = System.Drawing.Color.White;
            this.txtContra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.txtContra.BorderSize = 1;
            this.txtContra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContra.FocusedBaseColor = System.Drawing.Color.Empty;
            this.txtContra.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.txtContra.FocusedForeColor = System.Drawing.Color.Empty;
            this.txtContra.Font = new System.Drawing.Font("Arial", 9F);
            this.txtContra.ForeColor = System.Drawing.Color.Black;
            this.txtContra.Location = new System.Drawing.Point(187, 265);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '\0';
            this.txtContra.Radius = 5;
            this.txtContra.SelectedText = "";
            this.txtContra.Size = new System.Drawing.Size(263, 36);
            this.txtContra.TabIndex = 15;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.Transparent;
            this.txtCedula.BaseColor = System.Drawing.Color.White;
            this.txtCedula.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.txtCedula.BorderSize = 1;
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.FocusedBaseColor = System.Drawing.Color.Empty;
            this.txtCedula.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.txtCedula.FocusedForeColor = System.Drawing.Color.Empty;
            this.txtCedula.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCedula.ForeColor = System.Drawing.Color.Black;
            this.txtCedula.Location = new System.Drawing.Point(187, 128);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PasswordChar = '\0';
            this.txtCedula.Radius = 5;
            this.txtCedula.SelectedText = "";
            this.txtCedula.Size = new System.Drawing.Size(263, 36);
            this.txtCedula.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(183, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.panel1.Location = new System.Drawing.Point(20, 707);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 4);
            this.panel1.TabIndex = 5;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 860);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Registrar_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTipoUsuario;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton btnRegistrar;
        private Guna.UI.WinForms.GunaTextBox txtContra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtCedula;
        private System.Windows.Forms.Panel panel1;
    }
}