
namespace GestionCasos
{
    partial class fCasosAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCasosAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblActual = new System.Windows.Forms.Label();
            this.lblPag = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtConsecutivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaAdvenceTileButton1 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cbTramitador = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbRecepcion = new Guna.UI.WinForms.GunaComboBox();
            this.cbEstado = new Guna.UI.WinForms.GunaComboBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.Caso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Junta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Circuito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.lblActual);
            this.panel1.Controls.Add(this.lblPag);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.txtConsecutivo);
            this.panel1.Controls.Add(this.gunaAdvenceTileButton1);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.cbTramitador);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.cbRecepcion);
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.tabla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 561);
            this.panel1.TabIndex = 0;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // lblActual
            // 
            this.lblActual.BackColor = System.Drawing.Color.Transparent;
            this.lblActual.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActual.ForeColor = System.Drawing.Color.White;
            this.lblActual.Location = new System.Drawing.Point(273, 103);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(264, 23);
            this.lblActual.TabIndex = 30;
            this.lblActual.Text = "label1";
            this.lblActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPag
            // 
            this.lblPag.BackColor = System.Drawing.Color.Transparent;
            this.lblPag.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPag.ForeColor = System.Drawing.Color.White;
            this.lblPag.Location = new System.Drawing.Point(3, 103);
            this.lblPag.Name = "lblPag";
            this.lblPag.Size = new System.Drawing.Size(264, 23);
            this.lblPag.TabIndex = 29;
            this.lblPag.Text = "label1";
            this.lblPag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(757, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Anterior";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(855, 103);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "Siguiente";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsecutivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.txtConsecutivo.BorderRadius = 2;
            this.txtConsecutivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsecutivo.DefaultText = "";
            this.txtConsecutivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConsecutivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConsecutivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsecutivo.DisabledState.Parent = this.txtConsecutivo;
            this.txtConsecutivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsecutivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsecutivo.FocusedState.Parent = this.txtConsecutivo;
            this.txtConsecutivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsecutivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsecutivo.HoverState.Parent = this.txtConsecutivo;
            this.txtConsecutivo.Location = new System.Drawing.Point(88, 49);
            this.txtConsecutivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.PasswordChar = '\0';
            this.txtConsecutivo.PlaceholderText = "";
            this.txtConsecutivo.SelectedText = "";
            this.txtConsecutivo.ShadowDecoration.Parent = this.txtConsecutivo;
            this.txtConsecutivo.Size = new System.Drawing.Size(169, 26);
            this.txtConsecutivo.TabIndex = 12;
            this.txtConsecutivo.TextChanged += new System.EventHandler(this.txtConsecutivo_TextChanged);
            this.txtConsecutivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsecutivo_KeyPress);
            // 
            // gunaAdvenceTileButton1
            // 
            this.gunaAdvenceTileButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaAdvenceTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.CheckedImage = global::GestionCasos.Properties.Resources.reload;
            this.gunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaAdvenceTileButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.Image = global::GestionCasos.Properties.Resources.reload;
            this.gunaAdvenceTileButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaAdvenceTileButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.Location = new System.Drawing.Point(22, 35);
            this.gunaAdvenceTileButton1.Name = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnHoverImage = null;
            this.gunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.Radius = 18;
            this.gunaAdvenceTileButton1.Size = new System.Drawing.Size(40, 40);
            this.gunaAdvenceTileButton1.TabIndex = 11;
            this.gunaAdvenceTileButton1.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.gunaLabel4.Location = new System.Drawing.Point(84, 22);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(164, 20);
            this.gunaLabel4.TabIndex = 9;
            this.gunaLabel4.Text = "Filtrar Por Consecutivo";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.gunaLabel3.Location = new System.Drawing.Point(286, 22);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(135, 20);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Filtrar Por Persona";
            // 
            // cbTramitador
            // 
            this.cbTramitador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTramitador.BackColor = System.Drawing.Color.Transparent;
            this.cbTramitador.BaseColor = System.Drawing.Color.White;
            this.cbTramitador.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.cbTramitador.BorderSize = 1;
            this.cbTramitador.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTramitador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTramitador.FocusedColor = System.Drawing.Color.Empty;
            this.cbTramitador.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTramitador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.cbTramitador.FormattingEnabled = true;
            this.cbTramitador.Location = new System.Drawing.Point(290, 49);
            this.cbTramitador.Margin = new System.Windows.Forms.Padding(2);
            this.cbTramitador.Name = "cbTramitador";
            this.cbTramitador.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTramitador.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTramitador.Radius = 2;
            this.cbTramitador.Size = new System.Drawing.Size(255, 26);
            this.cbTramitador.TabIndex = 6;
            this.cbTramitador.SelectionChangeCommitted += new System.EventHandler(this.cbTramitador_SelectionChangeCommitted);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.gunaLabel2.Location = new System.Drawing.Point(753, 22);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(151, 20);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Filtrar Por Recepcion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.gunaLabel1.Location = new System.Drawing.Point(574, 22);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(126, 20);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Filtrar Por Estado";
            // 
            // cbRecepcion
            // 
            this.cbRecepcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRecepcion.BackColor = System.Drawing.Color.Transparent;
            this.cbRecepcion.BaseColor = System.Drawing.Color.White;
            this.cbRecepcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.cbRecepcion.BorderSize = 1;
            this.cbRecepcion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRecepcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecepcion.FocusedColor = System.Drawing.Color.Empty;
            this.cbRecepcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbRecepcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.cbRecepcion.FormattingEnabled = true;
            this.cbRecepcion.Location = new System.Drawing.Point(757, 49);
            this.cbRecepcion.Margin = new System.Windows.Forms.Padding(2);
            this.cbRecepcion.Name = "cbRecepcion";
            this.cbRecepcion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbRecepcion.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbRecepcion.Radius = 2;
            this.cbRecepcion.Size = new System.Drawing.Size(173, 26);
            this.cbRecepcion.TabIndex = 3;
            this.cbRecepcion.SelectionChangeCommitted += new System.EventHandler(this.cbRecepcion_SelectionChangeCommitted);
            // 
            // cbEstado
            // 
            this.cbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cbEstado.BaseColor = System.Drawing.Color.White;
            this.cbEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.cbEstado.BorderSize = 1;
            this.cbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FocusedColor = System.Drawing.Color.Empty;
            this.cbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(578, 49);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbEstado.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbEstado.Radius = 2;
            this.cbEstado.Size = new System.Drawing.Size(141, 26);
            this.cbEstado.TabIndex = 2;
            this.cbEstado.SelectionChangeCommitted += new System.EventHandler(this.cbEstado_SelectionChangeCommitted);
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToResizeColumns = false;
            this.tabla.AllowUserToResizeRows = false;
            this.tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.ColumnHeadersHeight = 50;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Caso,
            this.Fecha,
            this.Codigo,
            this.Junta,
            this.Circuito,
            this.Nombre,
            this.NombreCompleto,
            this.Comentario,
            this.Estado});
            this.tabla.EnableHeadersVisualStyles = false;
            this.tabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.tabla.Location = new System.Drawing.Point(0, 166);
            this.tabla.Margin = new System.Windows.Forms.Padding(2);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tabla.RowTemplate.DividerHeight = 1;
            this.tabla.RowTemplate.Height = 24;
            this.tabla.RowTemplate.ReadOnly = true;
            this.tabla.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.Size = new System.Drawing.Size(938, 395);
            this.tabla.TabIndex = 0;
            this.tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellContentClick);
            this.tabla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellDoubleClick);
            this.tabla.Paint += new System.Windows.Forms.PaintEventHandler(this.tabla_Paint);
            this.tabla.Resize += new System.EventHandler(this.tabla_Resize);
            // 
            // Caso
            // 
            this.Caso.FillWeight = 12.34942F;
            this.Caso.HeaderText = "Consecutivo";
            this.Caso.MinimumWidth = 6;
            this.Caso.Name = "Caso";
            this.Caso.ReadOnly = true;
            this.Caso.Width = 61;
            // 
            // Fecha
            // 
            this.Fecha.FillWeight = 12.34942F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 61;
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 10.34942F;
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 51;
            // 
            // Junta
            // 
            this.Junta.FillWeight = 40.2508F;
            this.Junta.HeaderText = "Junta";
            this.Junta.MinimumWidth = 6;
            this.Junta.Name = "Junta";
            this.Junta.ReadOnly = true;
            this.Junta.Width = 198;
            // 
            // Circuito
            // 
            this.Circuito.FillWeight = 9.96341F;
            this.Circuito.HeaderText = "Circuito";
            this.Circuito.MinimumWidth = 10;
            this.Circuito.Name = "Circuito";
            this.Circuito.ReadOnly = true;
            this.Circuito.Width = 49;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 20.96341F;
            this.Nombre.HeaderText = "Recepción";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 103;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.FillWeight = 40.96341F;
            this.NombreCompleto.HeaderText = "Asignado a";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 202;
            // 
            // Comentario
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            this.Comentario.DefaultCellStyle = dataGridViewCellStyle2;
            this.Comentario.FillWeight = 16.34942F;
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.MinimumWidth = 6;
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            this.Comentario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Comentario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Comentario.Text = "Ver Comentario";
            this.Comentario.ToolTipText = "Ver Comentario Del Caso";
            this.Comentario.UseColumnTextForButtonValue = true;
            this.Comentario.Width = 80;
            // 
            // Estado
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Estado.FillWeight = 12.34942F;
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 61;
            // 
            // fCasosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(938, 561);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "fCasosAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revision de casos";
            this.Load += new System.EventHandler(this.FormStyle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tabla;
        private Guna.UI.WinForms.GunaComboBox cbRecepcion;
        private Guna.UI.WinForms.GunaComboBox cbEstado;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox cbTramitador;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Junta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Circuito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewButtonColumn Comentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton1;
        private Guna.UI2.WinForms.Guna2TextBox txtConsecutivo;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Label lblPag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNext;
    }
}