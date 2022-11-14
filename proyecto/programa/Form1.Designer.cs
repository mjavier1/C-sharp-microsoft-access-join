namespace access_windows_form
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_bottone = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnreporte = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btndrop = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.pnl_detalle = new System.Windows.Forms.Panel();
            this.pnlcat = new System.Windows.Forms.Panel();
            this.btncat = new System.Windows.Forms.Button();
            this.dvgcat = new System.Windows.Forms.DataGridView();
            this.pan_me = new System.Windows.Forms.Panel();
            this.btnCam = new System.Windows.Forms.Button();
            this.dgv_me = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnca = new System.Windows.Forms.Button();
            this.btnmedidas = new System.Windows.Forms.Button();
            this.btncancela = new System.Windows.Forms.Button();
            this.txtmedida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_resumen = new System.Windows.Forms.Panel();
            this.data = new System.Windows.Forms.DataGridView();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_bottone.SuspendLayout();
            this.pnl_detalle.SuspendLayout();
            this.pnlcat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcat)).BeginInit();
            this.pan_me.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_me)).BeginInit();
            this.pnl_resumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.Controls.Add(this.label1);
            this.pnl_titulo.Controls.Add(this.pictureBox1);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1441, 65);
            this.pnl_titulo.TabIndex = 0;
            this.pnl_titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_titulo_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Articulos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_bottone
            // 
            this.pnl_bottone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_bottone.Controls.Add(this.btnexit);
            this.pnl_bottone.Controls.Add(this.btnreporte);
            this.pnl_bottone.Controls.Add(this.btnup);
            this.pnl_bottone.Controls.Add(this.btndrop);
            this.pnl_bottone.Controls.Add(this.btnnew);
            this.pnl_bottone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottone.Location = new System.Drawing.Point(0, 566);
            this.pnl_bottone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_bottone.Name = "pnl_bottone";
            this.pnl_bottone.Size = new System.Drawing.Size(1441, 130);
            this.pnl_bottone.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ImageKey = "logout.png";
            this.btnexit.ImageList = this.imageList1;
            this.btnexit.Location = new System.Drawing.Point(950, 3);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(96, 82);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Salir";
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "archivo.png");
            this.imageList1.Images.SetKeyName(1, "editar-documento.png");
            this.imageList1.Images.SetKeyName(2, "expediente.png");
            this.imageList1.Images.SetKeyName(3, "imagen.png");
            this.imageList1.Images.SetKeyName(4, "logout.png");
            this.imageList1.Images.SetKeyName(5, "nuevo-documento.png");
            this.imageList1.Images.SetKeyName(6, "rompecabezas.png");
            this.imageList1.Images.SetKeyName(7, "rompecabezas2.png");
            // 
            // btnreporte
            // 
            this.btnreporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreporte.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporte.ImageKey = "editar-documento.png";
            this.btnreporte.ImageList = this.imageList1;
            this.btnreporte.Location = new System.Drawing.Point(822, 3);
            this.btnreporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(92, 82);
            this.btnreporte.TabIndex = 3;
            this.btnreporte.Text = "Reporte";
            this.btnreporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnreporte.UseVisualStyleBackColor = true;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // btnup
            // 
            this.btnup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.ImageKey = "editar-documento.png";
            this.btnup.ImageList = this.imageList1;
            this.btnup.Location = new System.Drawing.Point(531, 3);
            this.btnup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(104, 82);
            this.btnup.TabIndex = 2;
            this.btnup.Text = "Actualizar";
            this.btnup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btndrop
            // 
            this.btndrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndrop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndrop.ImageKey = "expediente.png";
            this.btndrop.ImageList = this.imageList1;
            this.btndrop.Location = new System.Drawing.Point(674, 3);
            this.btndrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndrop.Name = "btndrop";
            this.btndrop.Size = new System.Drawing.Size(103, 82);
            this.btndrop.TabIndex = 1;
            this.btndrop.Text = "Eliminar";
            this.btndrop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btndrop.UseVisualStyleBackColor = true;
            this.btndrop.Click += new System.EventHandler(this.btndrop_Click);
            // 
            // btnnew
            // 
            this.btnnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ImageKey = "nuevo-documento.png";
            this.btnnew.ImageList = this.imageList1;
            this.btnnew.Location = new System.Drawing.Point(394, 3);
            this.btnnew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(85, 82);
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "nuevo";
            this.btnnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // pnl_detalle
            // 
            this.pnl_detalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_detalle.Controls.Add(this.pnlcat);
            this.pnl_detalle.Controls.Add(this.pan_me);
            this.pnl_detalle.Controls.Add(this.btnsave);
            this.pnl_detalle.Controls.Add(this.btnca);
            this.pnl_detalle.Controls.Add(this.btnmedidas);
            this.pnl_detalle.Controls.Add(this.btncancela);
            this.pnl_detalle.Controls.Add(this.txtmedida);
            this.pnl_detalle.Controls.Add(this.label6);
            this.pnl_detalle.Controls.Add(this.txtcat);
            this.pnl_detalle.Controls.Add(this.label5);
            this.pnl_detalle.Controls.Add(this.txtmar);
            this.pnl_detalle.Controls.Add(this.label4);
            this.pnl_detalle.Controls.Add(this.txtdescar);
            this.pnl_detalle.Controls.Add(this.label3);
            this.pnl_detalle.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_detalle.Location = new System.Drawing.Point(1140, 65);
            this.pnl_detalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_detalle.Name = "pnl_detalle";
            this.pnl_detalle.Size = new System.Drawing.Size(301, 501);
            this.pnl_detalle.TabIndex = 2;
            // 
            // pnlcat
            // 
            this.pnlcat.Controls.Add(this.btncat);
            this.pnlcat.Controls.Add(this.dvgcat);
            this.pnlcat.Location = new System.Drawing.Point(12, 321);
            this.pnlcat.Name = "pnlcat";
            this.pnlcat.Size = new System.Drawing.Size(210, 123);
            this.pnlcat.TabIndex = 13;
            this.pnlcat.Visible = false;
            this.pnlcat.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlcat_MouseDoubleClick);
            // 
            // btncat
            // 
            this.btncat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncat.Location = new System.Drawing.Point(9, 90);
            this.btncat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncat.Name = "btncat";
            this.btncat.Size = new System.Drawing.Size(161, 30);
            this.btncat.TabIndex = 4;
            this.btncat.Text = "Cambiar";
            this.btncat.UseVisualStyleBackColor = true;
            this.btncat.Click += new System.EventHandler(this.btncat_Click);
            // 
            // dvgcat
            // 
            this.dvgcat.AllowUserToAddRows = false;
            this.dvgcat.AllowUserToDeleteRows = false;
            this.dvgcat.AllowUserToOrderColumns = true;
            this.dvgcat.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgcat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgcat.ColumnHeadersHeight = 29;
            this.dvgcat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgcat.Location = new System.Drawing.Point(-3, 0);
            this.dvgcat.Name = "dvgcat";
            this.dvgcat.ReadOnly = true;
            this.dvgcat.RowHeadersWidth = 51;
            this.dvgcat.RowTemplate.Height = 24;
            this.dvgcat.Size = new System.Drawing.Size(209, 82);
            this.dvgcat.TabIndex = 0;
            this.dvgcat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgcat_CellDoubleClick);
            // 
            // pan_me
            // 
            this.pan_me.Controls.Add(this.btnCam);
            this.pan_me.Controls.Add(this.dgv_me);
            this.pan_me.Location = new System.Drawing.Point(14, 151);
            this.pan_me.Name = "pan_me";
            this.pan_me.Size = new System.Drawing.Size(210, 132);
            this.pan_me.TabIndex = 4;
            this.pan_me.Visible = false;
            // 
            // btnCam
            // 
            this.btnCam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCam.Location = new System.Drawing.Point(9, 90);
            this.btnCam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(161, 30);
            this.btnCam.TabIndex = 4;
            this.btnCam.Text = "Cambiar";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // dgv_me
            // 
            this.dgv_me.AllowUserToAddRows = false;
            this.dgv_me.AllowUserToDeleteRows = false;
            this.dgv_me.AllowUserToOrderColumns = true;
            this.dgv_me.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_me.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_me.ColumnHeadersHeight = 29;
            this.dgv_me.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_me.Location = new System.Drawing.Point(-2, 3);
            this.dgv_me.Name = "dgv_me";
            this.dgv_me.ReadOnly = true;
            this.dgv_me.RowHeadersWidth = 51;
            this.dgv_me.RowTemplate.Height = 24;
            this.dgv_me.Size = new System.Drawing.Size(209, 82);
            this.dgv_me.TabIndex = 0;
            this.dgv_me.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_me_CellContentClick);
            this.dgv_me.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_me_CellDoubleClick);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(148, 466);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(104, 30);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Visible = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnca
            // 
            this.btnca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnca.Location = new System.Drawing.Point(228, 320);
            this.btnca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnca.Name = "btnca";
            this.btnca.Size = new System.Drawing.Size(45, 30);
            this.btnca.TabIndex = 11;
            this.btnca.Text = "::";
            this.btnca.UseVisualStyleBackColor = true;
            this.btnca.Visible = false;
            this.btnca.Click += new System.EventHandler(this.btnca_Click);
            // 
            // btnmedidas
            // 
            this.btnmedidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnmedidas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmedidas.Location = new System.Drawing.Point(230, 151);
            this.btnmedidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmedidas.Name = "btnmedidas";
            this.btnmedidas.Size = new System.Drawing.Size(45, 30);
            this.btnmedidas.TabIndex = 11;
            this.btnmedidas.Text = "::";
            this.btnmedidas.UseVisualStyleBackColor = true;
            this.btnmedidas.Visible = false;
            this.btnmedidas.Click += new System.EventHandler(this.btnmedidas_Click);
            // 
            // btncancela
            // 
            this.btncancela.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancela.Location = new System.Drawing.Point(5, 466);
            this.btncancela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancela.Name = "btncancela";
            this.btncancela.Size = new System.Drawing.Size(104, 30);
            this.btncancela.TabIndex = 12;
            this.btncancela.Text = "Cancelar";
            this.btncancela.UseVisualStyleBackColor = true;
            this.btncancela.Visible = false;
            this.btncancela.Click += new System.EventHandler(this.btncancela_Click);
            // 
            // txtmedida
            // 
            this.txtmedida.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedida.Location = new System.Drawing.Point(17, 180);
            this.txtmedida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmedida.Name = "txtmedida";
            this.txtmedida.Size = new System.Drawing.Size(197, 30);
            this.txtmedida.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Medida:";
            // 
            // txtcat
            // 
            this.txtcat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcat.Location = new System.Drawing.Point(17, 321);
            this.txtcat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcat.Name = "txtcat";
            this.txtcat.Size = new System.Drawing.Size(197, 30);
            this.txtcat.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Categorias:";
            // 
            // txtmar
            // 
            this.txtmar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmar.Location = new System.Drawing.Point(16, 81);
            this.txtmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmar.Name = "txtmar";
            this.txtmar.Size = new System.Drawing.Size(197, 30);
            this.txtmar.TabIndex = 6;
            this.txtmar.TextChanged += new System.EventHandler(this.txtmar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Marca:";
            // 
            // txtdescar
            // 
            this.txtdescar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescar.Location = new System.Drawing.Point(17, 23);
            this.txtdescar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescar.Name = "txtdescar";
            this.txtdescar.Size = new System.Drawing.Size(197, 30);
            this.txtdescar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Articulo:";
            // 
            // pnl_resumen
            // 
            this.pnl_resumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_resumen.Controls.Add(this.data);
            this.pnl_resumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_resumen.Location = new System.Drawing.Point(0, 65);
            this.pnl_resumen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_resumen.Name = "pnl_resumen";
            this.pnl_resumen.Size = new System.Drawing.Size(1140, 501);
            this.pnl_resumen.TabIndex = 3;
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToOrderColumns = true;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(30, 74);
            this.data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(1109, 422);
            this.data.TabIndex = 0;
            this.data.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1441, 696);
            this.Controls.Add(this.pnl_resumen);
            this.Controls.Add(this.pnl_detalle);
            this.Controls.Add(this.pnl_bottone);
            this.Controls.Add(this.pnl_titulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "frm_Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_bottone.ResumeLayout(false);
            this.pnl_detalle.ResumeLayout(false);
            this.pnl_detalle.PerformLayout();
            this.pnlcat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgcat)).EndInit();
            this.pan_me.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_me)).EndInit();
            this.pnl_resumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_bottone;
        private System.Windows.Forms.Panel pnl_detalle;
        private System.Windows.Forms.Panel pnl_resumen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btndrop;
        private System.Windows.Forms.TextBox txtmedida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancela;
        private System.Windows.Forms.Button btnca;
        private System.Windows.Forms.Button btnmedidas;
        private System.Windows.Forms.Panel pan_me;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.DataGridView dgv_me;
        private System.Windows.Forms.Panel pnlcat;
        private System.Windows.Forms.Button btncat;
        private System.Windows.Forms.DataGridView dvgcat;
    }
}

