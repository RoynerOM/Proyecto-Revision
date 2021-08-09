
namespace GestionCasos
{
    partial class AsignarCaso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarCaso));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReasignarCaso = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaAdvenceTileButton2 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.txtCaso = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbAsignados = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbTipoRecepcion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtCircuito = new Guna.UI.WinForms.GunaTextBox();
            this.txtJuntaAdm = new Guna.UI.WinForms.GunaTextBox();
            this.txtConsecutivo = new Guna.UI.WinForms.GunaTextBox();
            this.lbAsignado = new System.Windows.Forms.Label();
            this.lbMedioReceptivo = new System.Windows.Forms.Label();
            this.lbCircuiton = new System.Windows.Forms.Label();
            this.lbJunta = new System.Windows.Forms.Label();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.dtpFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbConsecutivo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.btnReasignarCaso);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(582, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 790);
            this.panel2.TabIndex = 57;
            // 
            // btnReasignarCaso
            // 
            this.btnReasignarCaso.BackColor = System.Drawing.Color.Transparent;
            this.btnReasignarCaso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReasignarCaso.FlatAppearance.BorderSize = 0;
            this.btnReasignarCaso.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReasignarCaso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.btnReasignarCaso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnReasignarCaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReasignarCaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReasignarCaso.ForeColor = System.Drawing.Color.White;
            this.btnReasignarCaso.Location = new System.Drawing.Point(0, 50);
            this.btnReasignarCaso.Name = "btnReasignarCaso";
            this.btnReasignarCaso.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnReasignarCaso.Size = new System.Drawing.Size(160, 50);
            this.btnReasignarCaso.TabIndex = 1;
            this.btnReasignarCaso.Text = "Reasignar caso";
            this.btnReasignarCaso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReasignarCaso.UseVisualStyleBackColor = false;
            this.btnReasignarCaso.Click += new System.EventHandler(this.btnReasignarCaso_ClickAsync);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(0, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnGuardar.Size = new System.Drawing.Size(160, 50);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.gunaAdvenceTileButton2);
            this.panel1.Controls.Add(this.txtCaso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cbAsignados);
            this.panel1.Controls.Add(this.cbTipoRecepcion);
            this.panel1.Controls.Add(this.txtCircuito);
            this.panel1.Controls.Add(this.txtJuntaAdm);
            this.panel1.Controls.Add(this.txtConsecutivo);
            this.panel1.Controls.Add(this.lbAsignado);
            this.panel1.Controls.Add(this.lbMedioReceptivo);
            this.panel1.Controls.Add(this.lbCircuiton);
            this.panel1.Controls.Add(this.lbJunta);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lbCodigo);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.lbFecha);
            this.panel1.Controls.Add(this.lbConsecutivo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 790);
            this.panel1.TabIndex = 58;
            // 
            // gunaAdvenceTileButton2
            // 
            this.gunaAdvenceTileButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceTileButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.gunaAdvenceTileButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.gunaAdvenceTileButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.gunaAdvenceTileButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton2.CheckedImage")));
            this.gunaAdvenceTileButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceTileButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaAdvenceTileButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.Image = global::GestionCasos.Properties.Resources.buscar;
            this.gunaAdvenceTileButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaAdvenceTileButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton2.Location = new System.Drawing.Point(463, 632);
            this.gunaAdvenceTileButton2.Name = "gunaAdvenceTileButton2";
            this.gunaAdvenceTileButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.gunaAdvenceTileButton2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton2.OnHoverForeColor = System.Drawing.Color.YellowGreen;
            this.gunaAdvenceTileButton2.OnHoverImage = null;
            this.gunaAdvenceTileButton2.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton2.OnPressedColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton2.Radius = 5;
            this.gunaAdvenceTileButton2.Size = new System.Drawing.Size(36, 36);
            this.gunaAdvenceTileButton2.TabIndex = 8;
            this.gunaAdvenceTileButton2.Click += new System.EventHandler(this.gunaAdvenceTileButton2_Click);
            // 
            // txtCaso
            // 
            this.txtCaso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCaso.BackColor = System.Drawing.Color.Transparent;
            this.txtCaso.BaseColor = System.Drawing.Color.White;
            this.txtCaso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.txtCaso.BorderSize = 1;
            this.txtCaso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCaso.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCaso.FocusedBorderColor = System.Drawing.Color.YellowGreen;
            this.txtCaso.FocusedForeColor = System.Drawing.Color.Black;
            this.txtCaso.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCaso.ForeColor = System.Drawing.Color.Black;
            this.txtCaso.Location = new System.Drawing.Point(186, 632);
            this.txtCaso.Name = "txtCaso";
            this.txtCaso.PasswordChar = '\0';
            this.txtCaso.Radius = 5;
            this.txtCaso.SelectedText = "";
            this.txtCaso.Size = new System.Drawing.Size(313, 36);
            this.txtCaso.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 95;
            this.label1.Text = "Buscar Caso:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::GestionCasos.Properties.Resources.Logo_AMCONSULTORES1;
            this.pictureBox1.Location = new System.Drawing.Point(187, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // cbAsignados
            // 
            this.cbAsignados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAsignados.BackColor = System.Drawing.Color.Transparent;
            this.cbAsignados.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.cbAsignados.BorderRadius = 5;
            this.cbAsignados.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAsignados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsignados.FocusedColor = System.Drawing.Color.Empty;
            this.cbAsignados.FocusedState.Parent = this.cbAsignados;
            this.cbAsignados.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAsignados.ForeColor = System.Drawing.Color.Black;
            this.cbAsignados.FormattingEnabled = true;
            this.cbAsignados.HoverState.Parent = this.cbAsignados;
            this.cbAsignados.ItemHeight = 30;
            this.cbAsignados.Items.AddRange(new object[] {
            "Administrador",
            "Normal"});
            this.cbAsignados.ItemsAppearance.Parent = this.cbAsignados;
            this.cbAsignados.Location = new System.Drawing.Point(186, 572);
            this.cbAsignados.Name = "cbAsignados";
            this.cbAsignados.ShadowDecoration.Parent = this.cbAsignados;
            this.cbAsignados.Size = new System.Drawing.Size(313, 36);
            this.cbAsignados.TabIndex = 6;
            // 
            // cbTipoRecepcion
            // 
            this.cbTipoRecepcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipoRecepcion.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoRecepcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.cbTipoRecepcion.BorderRadius = 5;
            this.cbTipoRecepcion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoRecepcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRecepcion.FocusedColor = System.Drawing.Color.Empty;
            this.cbTipoRecepcion.FocusedState.Parent = this.cbTipoRecepcion;
            this.cbTipoRecepcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTipoRecepcion.ForeColor = System.Drawing.Color.Black;
            this.cbTipoRecepcion.FormattingEnabled = true;
            this.cbTipoRecepcion.HoverState.Parent = this.cbTipoRecepcion;
            this.cbTipoRecepcion.ItemHeight = 30;
            this.cbTipoRecepcion.ItemsAppearance.Parent = this.cbTipoRecepcion;
            this.cbTipoRecepcion.Location = new System.Drawing.Point(186, 512);
            this.cbTipoRecepcion.Name = "cbTipoRecepcion";
            this.cbTipoRecepcion.ShadowDecoration.Parent = this.cbTipoRecepcion;
            this.cbTipoRecepcion.Size = new System.Drawing.Size(313, 36);
            this.cbTipoRecepcion.TabIndex = 5;
            // 
            // txtCircuito
            // 
            this.txtCircuito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCircuito.BackColor = System.Drawing.Color.Transparent;
            this.txtCircuito.BaseColor = System.Drawing.Color.White;
            this.txtCircuito.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.txtCircuito.BorderSize = 1;
            this.txtCircuito.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCircuito.Enabled = false;
            this.txtCircuito.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCircuito.FocusedBorderColor = System.Drawing.Color.Aqua;
            this.txtCircuito.FocusedForeColor = System.Drawing.Color.Yellow;
            this.txtCircuito.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCircuito.ForeColor = System.Drawing.Color.Lime;
            this.txtCircuito.Location = new System.Drawing.Point(186, 452);
            this.txtCircuito.Name = "txtCircuito";
            this.txtCircuito.PasswordChar = '\0';
            this.txtCircuito.Radius = 5;
            this.txtCircuito.SelectedText = "";
            this.txtCircuito.Size = new System.Drawing.Size(313, 36);
            this.txtCircuito.TabIndex = 4;
            // 
            // txtJuntaAdm
            // 
            this.txtJuntaAdm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJuntaAdm.BackColor = System.Drawing.Color.Transparent;
            this.txtJuntaAdm.BaseColor = System.Drawing.Color.White;
            this.txtJuntaAdm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.txtJuntaAdm.BorderSize = 1;
            this.txtJuntaAdm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJuntaAdm.Enabled = false;
            this.txtJuntaAdm.FocusedBaseColor = System.Drawing.Color.White;
            this.txtJuntaAdm.FocusedBorderColor = System.Drawing.Color.Aqua;
            this.txtJuntaAdm.FocusedForeColor = System.Drawing.Color.Yellow;
            this.txtJuntaAdm.Font = new System.Drawing.Font("Arial", 9F);
            this.txtJuntaAdm.ForeColor = System.Drawing.Color.Lime;
            this.txtJuntaAdm.Location = new System.Drawing.Point(186, 391);
            this.txtJuntaAdm.Name = "txtJuntaAdm";
            this.txtJuntaAdm.PasswordChar = '\0';
            this.txtJuntaAdm.Radius = 5;
            this.txtJuntaAdm.SelectedText = "";
            this.txtJuntaAdm.Size = new System.Drawing.Size(313, 36);
            this.txtJuntaAdm.TabIndex = 3;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConsecutivo.BackColor = System.Drawing.Color.Transparent;
            this.txtConsecutivo.BaseColor = System.Drawing.Color.White;
            this.txtConsecutivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.txtConsecutivo.BorderSize = 1;
            this.txtConsecutivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsecutivo.Enabled = false;
            this.txtConsecutivo.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.txtConsecutivo.FocusedBorderColor = System.Drawing.Color.Aqua;
            this.txtConsecutivo.FocusedForeColor = System.Drawing.Color.Yellow;
            this.txtConsecutivo.Font = new System.Drawing.Font("Arial", 9F);
            this.txtConsecutivo.ForeColor = System.Drawing.Color.Lime;
            this.txtConsecutivo.Location = new System.Drawing.Point(186, 210);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.PasswordChar = '\0';
            this.txtConsecutivo.Radius = 5;
            this.txtConsecutivo.SelectedText = "";
            this.txtConsecutivo.Size = new System.Drawing.Size(313, 36);
            this.txtConsecutivo.TabIndex = 0;
            // 
            // lbAsignado
            // 
            this.lbAsignado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAsignado.AutoSize = true;
            this.lbAsignado.BackColor = System.Drawing.Color.Transparent;
            this.lbAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAsignado.ForeColor = System.Drawing.Color.White;
            this.lbAsignado.Location = new System.Drawing.Point(84, 572);
            this.lbAsignado.Name = "lbAsignado";
            this.lbAsignado.Size = new System.Drawing.Size(96, 18);
            this.lbAsignado.TabIndex = 87;
            this.lbAsignado.Text = "Asignado a:";
            // 
            // lbMedioReceptivo
            // 
            this.lbMedioReceptivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMedioReceptivo.AutoSize = true;
            this.lbMedioReceptivo.BackColor = System.Drawing.Color.Transparent;
            this.lbMedioReceptivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedioReceptivo.ForeColor = System.Drawing.Color.White;
            this.lbMedioReceptivo.Location = new System.Drawing.Point(41, 512);
            this.lbMedioReceptivo.Name = "lbMedioReceptivo";
            this.lbMedioReceptivo.Size = new System.Drawing.Size(139, 18);
            this.lbMedioReceptivo.TabIndex = 86;
            this.lbMedioReceptivo.Text = "Medio Receptivo:";
            // 
            // lbCircuiton
            // 
            this.lbCircuiton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCircuiton.AutoSize = true;
            this.lbCircuiton.BackColor = System.Drawing.Color.Transparent;
            this.lbCircuiton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCircuiton.ForeColor = System.Drawing.Color.White;
            this.lbCircuiton.Location = new System.Drawing.Point(108, 452);
            this.lbCircuiton.Name = "lbCircuiton";
            this.lbCircuiton.Size = new System.Drawing.Size(72, 18);
            this.lbCircuiton.TabIndex = 85;
            this.lbCircuiton.Text = "Circuito:";
            // 
            // lbJunta
            // 
            this.lbJunta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbJunta.AutoSize = true;
            this.lbJunta.BackColor = System.Drawing.Color.Transparent;
            this.lbJunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJunta.ForeColor = System.Drawing.Color.White;
            this.lbJunta.Location = new System.Drawing.Point(67, 391);
            this.lbJunta.Name = "lbJunta";
            this.lbJunta.Size = new System.Drawing.Size(117, 18);
            this.lbJunta.TabIndex = 84;
            this.lbJunta.Text = "Jta Educ/Adm:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.BackColor = System.Drawing.Color.Wheat;
            this.txtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.txtCodigo.BorderRadius = 4;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "";
            this.txtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.DisabledState.Parent = this.txtCodigo;
            this.txtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.FocusedState.Parent = this.txtCodigo;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.HoverState.Parent = this.txtCodigo;
            this.txtCodigo.Location = new System.Drawing.Point(186, 330);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.ShadowDecoration.Parent = this.txtCodigo;
            this.txtCodigo.Size = new System.Drawing.Size(313, 36);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AsignarCaso_KeyPress);
            // 
            // lbCodigo
            // 
            this.lbCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.White;
            this.lbCodigo.Location = new System.Drawing.Point(114, 330);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(67, 18);
            this.lbCodigo.TabIndex = 82;
            this.lbCodigo.Text = "Código:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.dtpFecha.BorderRadius = 5;
            this.dtpFecha.BorderThickness = 1;
            this.dtpFecha.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.dtpFecha.CheckedState.Parent = this.dtpFecha;
            this.dtpFecha.FillColor = System.Drawing.Color.White;
            this.dtpFecha.FocusedColor = System.Drawing.Color.White;
            this.dtpFecha.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFecha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.dtpFecha.HoverState.Parent = this.dtpFecha;
            this.dtpFecha.Location = new System.Drawing.Point(186, 270);
            this.dtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.ShadowDecoration.Parent = this.dtpFecha;
            this.dtpFecha.Size = new System.Drawing.Size(313, 36);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2021, 6, 19, 0, 0, 0, 0);
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.Transparent;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(121, 270);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(59, 18);
            this.lbFecha.TabIndex = 80;
            this.lbFecha.Text = "Fecha:";
            // 
            // lbConsecutivo
            // 
            this.lbConsecutivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbConsecutivo.AutoSize = true;
            this.lbConsecutivo.BackColor = System.Drawing.Color.Transparent;
            this.lbConsecutivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsecutivo.ForeColor = System.Drawing.Color.White;
            this.lbConsecutivo.Location = new System.Drawing.Point(73, 210);
            this.lbConsecutivo.Name = "lbConsecutivo";
            this.lbConsecutivo.Size = new System.Drawing.Size(107, 18);
            this.lbConsecutivo.TabIndex = 79;
            this.lbConsecutivo.Text = "Consecutivo:";
            // 
            // AsignarCaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(742, 790);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AsignarCaso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AsignarCaso_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbAsignados;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipoRecepcion;
        private Guna.UI.WinForms.GunaTextBox txtCircuito;
        private Guna.UI.WinForms.GunaTextBox txtJuntaAdm;
        private System.Windows.Forms.Label lbAsignado;
        private System.Windows.Forms.Label lbMedioReceptivo;
        private System.Windows.Forms.Label lbCircuiton;
        private System.Windows.Forms.Label lbJunta;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbConsecutivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox txtConsecutivo;
        private Guna.UI.WinForms.GunaTextBox txtCaso;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton2;
        private System.Windows.Forms.Button btnReasignarCaso;
    }
}