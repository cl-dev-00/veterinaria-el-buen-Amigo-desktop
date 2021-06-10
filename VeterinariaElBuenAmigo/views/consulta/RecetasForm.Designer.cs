﻿
namespace VeterinariaElBuenAmigo.views.consulta
{
    partial class RecetasForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_Control = new Guna.UI.WinForms.GunaDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_Padecimineto = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Producto = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Dosis = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Refuerzo = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_Guardar = new Guna.UI.WinForms.GunaButton();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Control)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.titulo);
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1191, 57);
            this.panelTop.TabIndex = 1;
            // 
            // titulo
            // 
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.titulo.Location = new System.Drawing.Point(572, 11);
            this.titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(212, 47);
            this.titulo.TabIndex = 19;
            this.titulo.Text = "Vitaminas";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 32;
            this.btnMin.Location = new System.Drawing.Point(1088, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(64, 57);
            this.btnMin.TabIndex = 12;
            this.btnMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 32;
            this.btnClose.Location = new System.Drawing.Point(1152, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 57);
            this.btnClose.TabIndex = 5;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(373, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 47);
            this.label1.TabIndex = 16;
            this.label1.Text = "Control de";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbl_Control
            // 
            this.tbl_Control.AllowUserToAddRows = false;
            this.tbl_Control.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.tbl_Control.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbl_Control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Control.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_Control.BackgroundColor = System.Drawing.Color.White;
            this.tbl_Control.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_Control.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbl_Control.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_Control.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbl_Control.ColumnHeadersHeight = 40;
            this.tbl_Control.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.ColumnSelect});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_Control.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbl_Control.EnableHeadersVisualStyles = false;
            this.tbl_Control.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.tbl_Control.Location = new System.Drawing.Point(97, 107);
            this.tbl_Control.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbl_Control.Name = "tbl_Control";
            this.tbl_Control.RowHeadersVisible = false;
            this.tbl_Control.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tbl_Control.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tbl_Control.RowTemplate.Height = 40;
            this.tbl_Control.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_Control.Size = new System.Drawing.Size(971, 263);
            this.tbl_Control.TabIndex = 36;
            this.tbl_Control.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal;
            this.tbl_Control.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.tbl_Control.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tbl_Control.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tbl_Control.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tbl_Control.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tbl_Control.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tbl_Control.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.tbl_Control.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tbl_Control.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tbl_Control.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbl_Control.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tbl_Control.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tbl_Control.ThemeStyle.HeaderStyle.Height = 40;
            this.tbl_Control.ThemeStyle.ReadOnly = false;
            this.tbl_Control.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.tbl_Control.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbl_Control.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbl_Control.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbl_Control.ThemeStyle.RowsStyle.Height = 40;
            this.tbl_Control.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.tbl_Control.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Paciente";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Padecimineto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 75F;
            this.Column3.HeaderText = "Producto";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 75F;
            this.Column4.HeaderText = "Dosis";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Refuerzo";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.FillWeight = 25F;
            this.ColumnSelect.HeaderText = "";
            this.ColumnSelect.MinimumWidth = 6;
            this.ColumnSelect.Name = "ColumnSelect";
            // 
            // txt_Padecimineto
            // 
            this.txt_Padecimineto.BackColor = System.Drawing.Color.Transparent;
            this.txt_Padecimineto.BaseColor = System.Drawing.Color.White;
            this.txt_Padecimineto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Padecimineto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Padecimineto.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Padecimineto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Padecimineto.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Padecimineto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_Padecimineto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Padecimineto.Location = new System.Drawing.Point(97, 439);
            this.txt_Padecimineto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Padecimineto.Name = "txt_Padecimineto";
            this.txt_Padecimineto.PasswordChar = '\0';
            this.txt_Padecimineto.Radius = 15;
            this.txt_Padecimineto.Size = new System.Drawing.Size(416, 52);
            this.txt_Padecimineto.TabIndex = 38;
            this.txt_Padecimineto.TextOffsetX = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label3.Location = new System.Drawing.Point(92, 394);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "Padecimiento";
            // 
            // txt_Producto
            // 
            this.txt_Producto.BackColor = System.Drawing.Color.Transparent;
            this.txt_Producto.BaseColor = System.Drawing.Color.White;
            this.txt_Producto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Producto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Producto.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Producto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Producto.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Producto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_Producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Producto.Location = new System.Drawing.Point(675, 439);
            this.txt_Producto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.PasswordChar = '\0';
            this.txt_Producto.Radius = 15;
            this.txt_Producto.Size = new System.Drawing.Size(416, 52);
            this.txt_Producto.TabIndex = 40;
            this.txt_Producto.TextOffsetX = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(669, 394);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Producto";
            // 
            // txt_Dosis
            // 
            this.txt_Dosis.BackColor = System.Drawing.Color.Transparent;
            this.txt_Dosis.BaseColor = System.Drawing.Color.White;
            this.txt_Dosis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Dosis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Dosis.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Dosis.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Dosis.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Dosis.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_Dosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Dosis.Location = new System.Drawing.Point(675, 561);
            this.txt_Dosis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Dosis.Name = "txt_Dosis";
            this.txt_Dosis.PasswordChar = '\0';
            this.txt_Dosis.Radius = 15;
            this.txt_Dosis.Size = new System.Drawing.Size(120, 52);
            this.txt_Dosis.TabIndex = 42;
            this.txt_Dosis.TextOffsetX = 10;
            this.txt_Dosis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dosis_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label4.Location = new System.Drawing.Point(669, 516);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 41;
            this.label4.Text = "Dosis";
            // 
            // txt_Refuerzo
            // 
            this.txt_Refuerzo.BackColor = System.Drawing.Color.Transparent;
            this.txt_Refuerzo.BaseColor = System.Drawing.Color.White;
            this.txt_Refuerzo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Refuerzo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Refuerzo.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Refuerzo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Refuerzo.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Refuerzo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_Refuerzo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txt_Refuerzo.Location = new System.Drawing.Point(97, 561);
            this.txt_Refuerzo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Refuerzo.Name = "txt_Refuerzo";
            this.txt_Refuerzo.PasswordChar = '\0';
            this.txt_Refuerzo.Radius = 15;
            this.txt_Refuerzo.Size = new System.Drawing.Size(416, 52);
            this.txt_Refuerzo.TabIndex = 44;
            this.txt_Refuerzo.TextOffsetX = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label5.Location = new System.Drawing.Point(92, 516);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 43;
            this.label5.Text = "Refuerzo";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.iconButton2);
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Location = new System.Drawing.Point(799, 561);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(69, 49);
            this.panel4.TabIndex = 45;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.Location = new System.Drawing.Point(0, 22);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(69, 27);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(69, 27);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.AnimationHoverSpeed = 0.07F;
            this.btn_Guardar.AnimationSpeed = 0.03F;
            this.btn_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btn_Guardar.BorderColor = System.Drawing.Color.Black;
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Guardar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Guardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Image = null;
            this.btn_Guardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Guardar.Location = new System.Drawing.Point(299, 650);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btn_Guardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Guardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Guardar.OnHoverImage = null;
            this.btn_Guardar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Guardar.Radius = 5;
            this.btn_Guardar.Size = new System.Drawing.Size(593, 43);
            this.btn_Guardar.TabIndex = 46;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::VeterinariaElBuenAmigo.Properties.Resources.delete;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(929, 57);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(139, 43);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Eliminar ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // RecetasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 725);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_Refuerzo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Dosis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Producto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Padecimineto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbl_Control);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecetasForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecetasForm";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Control)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label titulo;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView tbl_Control;
        private Guna.UI.WinForms.GunaTextBox txt_Padecimineto;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txt_Producto;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txt_Dosis;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txt_Refuerzo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI.WinForms.GunaButton btn_Guardar;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelect;
    }
}