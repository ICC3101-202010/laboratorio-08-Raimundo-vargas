namespace Lab_8
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Tipos", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Duenos", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Ids", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup16 = new System.Windows.Forms.ListViewGroup("Horarios", System.Windows.Forms.HorizontalAlignment.Left);
            this.Btn_crear = new System.Windows.Forms.Button();
            this.btn_revisar = new System.Windows.Forms.Button();
            this.btn_Ver = new System.Windows.Forms.Button();
            this.panel_Nuevo_Local = new System.Windows.Forms.Panel();
            this.Numero_de_salas = new System.Windows.Forms.NumericUpDown();
            this.Categorias = new System.Windows.Forms.CheckedListBox();
            this.Exclusividad = new System.Windows.Forms.ComboBox();
            this.Eleccion_Local = new System.Windows.Forms.ComboBox();
            this.txt_tipo = new System.Windows.Forms.Label();
            this.Horario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre_Dueño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Atras_1 = new System.Windows.Forms.Button();
            this.panel_Ver_Todos_Los_Locales = new System.Windows.Forms.Panel();
            this.btn_atras_3 = new System.Windows.Forms.Button();
            this.panel_Revisar_Local = new System.Windows.Forms.Panel();
            this.btn_Atras_2 = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.Ver_todo = new System.Windows.Forms.ListView();
            this.Tipos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dueno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ids = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Horarios = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Id_Ver = new System.Windows.Forms.TextBox();
            this.Nombre_Dueno = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Horario_Local = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.Id_Buscado = new System.Windows.Forms.Label();
            this.Texto_Segun_tipo = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.panel_Nuevo_Local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numero_de_salas)).BeginInit();
            this.panel_Ver_Todos_Los_Locales.SuspendLayout();
            this.panel_Revisar_Local.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_crear
            // 
            this.Btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_crear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_crear.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_crear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_crear.Location = new System.Drawing.Point(204, 104);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_crear.Size = new System.Drawing.Size(538, 91);
            this.Btn_crear.TabIndex = 0;
            this.Btn_crear.Text = "Agregar un nuevo Local";
            this.Btn_crear.UseVisualStyleBackColor = false;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // btn_revisar
            // 
            this.btn_revisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_revisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_revisar.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_revisar.Location = new System.Drawing.Point(204, 217);
            this.btn_revisar.Name = "btn_revisar";
            this.btn_revisar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_revisar.Size = new System.Drawing.Size(538, 91);
            this.btn_revisar.TabIndex = 1;
            this.btn_revisar.Text = "Revisar Local Existente";
            this.btn_revisar.UseVisualStyleBackColor = false;
            this.btn_revisar.Click += new System.EventHandler(this.btn_revisar_Click);
            // 
            // btn_Ver
            // 
            this.btn_Ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Ver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ver.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ver.Location = new System.Drawing.Point(204, 331);
            this.btn_Ver.Name = "btn_Ver";
            this.btn_Ver.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Ver.Size = new System.Drawing.Size(538, 91);
            this.btn_Ver.TabIndex = 2;
            this.btn_Ver.Text = "Ver todos los locales";
            this.btn_Ver.UseVisualStyleBackColor = false;
            this.btn_Ver.Click += new System.EventHandler(this.btn_Ver_Click);
            // 
            // panel_Nuevo_Local
            // 
            this.panel_Nuevo_Local.Controls.Add(this.Numero_de_salas);
            this.panel_Nuevo_Local.Controls.Add(this.Categorias);
            this.panel_Nuevo_Local.Controls.Add(this.Exclusividad);
            this.panel_Nuevo_Local.Controls.Add(this.Eleccion_Local);
            this.panel_Nuevo_Local.Controls.Add(this.txt_tipo);
            this.panel_Nuevo_Local.Controls.Add(this.Horario);
            this.panel_Nuevo_Local.Controls.Add(this.label4);
            this.panel_Nuevo_Local.Controls.Add(this.Id);
            this.panel_Nuevo_Local.Controls.Add(this.label3);
            this.panel_Nuevo_Local.Controls.Add(this.Nombre_Dueño);
            this.panel_Nuevo_Local.Controls.Add(this.label2);
            this.panel_Nuevo_Local.Controls.Add(this.label1);
            this.panel_Nuevo_Local.Controls.Add(this.btn_Guardar);
            this.panel_Nuevo_Local.Controls.Add(this.btn_Atras_1);
            this.panel_Nuevo_Local.Location = new System.Drawing.Point(686, 104);
            this.panel_Nuevo_Local.Name = "panel_Nuevo_Local";
            this.panel_Nuevo_Local.Size = new System.Drawing.Size(56, 49);
            this.panel_Nuevo_Local.TabIndex = 3;
            this.panel_Nuevo_Local.Visible = false;
            this.panel_Nuevo_Local.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Nuevo_Local_Paint);
            // 
            // Numero_de_salas
            // 
            this.Numero_de_salas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Numero_de_salas.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero_de_salas.Location = new System.Drawing.Point(548, 158);
            this.Numero_de_salas.Name = "Numero_de_salas";
            this.Numero_de_salas.Size = new System.Drawing.Size(78, 45);
            this.Numero_de_salas.TabIndex = 121;
            this.Numero_de_salas.Visible = false;
            // 
            // Categorias
            // 
            this.Categorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Categorias.Font = new System.Drawing.Font("Broadway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorias.FormattingEnabled = true;
            this.Categorias.Items.AddRange(new object[] {
            "Ropa",
            "Infantil",
            "Hogar",
            "Electronica",
            "Outlet",
            "Hobbies",
            "Libreria",
            "Otros"});
            this.Categorias.Location = new System.Drawing.Point(548, 158);
            this.Categorias.Name = "Categorias";
            this.Categorias.Size = new System.Drawing.Size(371, 70);
            this.Categorias.TabIndex = 120;
            this.Categorias.Visible = false;
            // 
            // Exclusividad
            // 
            this.Exclusividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exclusividad.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exclusividad.FormattingEnabled = true;
            this.Exclusividad.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.Exclusividad.Location = new System.Drawing.Point(548, 158);
            this.Exclusividad.Margin = new System.Windows.Forms.Padding(4);
            this.Exclusividad.Name = "Exclusividad";
            this.Exclusividad.Size = new System.Drawing.Size(126, 45);
            this.Exclusividad.TabIndex = 119;
            this.Exclusividad.Visible = false;
            // 
            // Eleccion_Local
            // 
            this.Eleccion_Local.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Eleccion_Local.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eleccion_Local.FormattingEnabled = true;
            this.Eleccion_Local.Items.AddRange(new object[] {
            "Restaurante",
            "Tienda",
            "Cine",
            "Recreacional"});
            this.Eleccion_Local.Location = new System.Drawing.Point(47, 113);
            this.Eleccion_Local.Margin = new System.Windows.Forms.Padding(4);
            this.Eleccion_Local.Name = "Eleccion_Local";
            this.Eleccion_Local.Size = new System.Drawing.Size(405, 45);
            this.Eleccion_Local.TabIndex = 118;
            this.Eleccion_Local.SelectedIndexChanged += new System.EventHandler(this.Eleccion_Local_SelectedIndexChanged);
            // 
            // txt_tipo
            // 
            this.txt_tipo.AutoSize = true;
            this.txt_tipo.Font = new System.Drawing.Font("Broadway", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo.Location = new System.Drawing.Point(540, 111);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(0, 43);
            this.txt_tipo.TabIndex = 16;
            this.txt_tipo.Click += new System.EventHandler(this.txt_tipo_Click);
            // 
            // Horario
            // 
            this.Horario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Horario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Horario.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horario.Location = new System.Drawing.Point(47, 398);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(445, 45);
            this.Horario.TabIndex = 15;
            this.Horario.TextChanged += new System.EventHandler(this.Horario_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Broadway", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 43);
            this.label4.TabIndex = 14;
            this.label4.Text = "Horario:";
            // 
            // Id
            // 
            this.Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Id.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(47, 297);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(445, 45);
            this.Id.TabIndex = 13;
            this.Id.TextChanged += new System.EventHandler(this.Id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 43);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID:";
            // 
            // Nombre_Dueño
            // 
            this.Nombre_Dueño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Nombre_Dueño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nombre_Dueño.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Dueño.Location = new System.Drawing.Point(47, 203);
            this.Nombre_Dueño.Name = "Nombre_Dueño";
            this.Nombre_Dueño.Size = new System.Drawing.Size(445, 45);
            this.Nombre_Dueño.TabIndex = 11;
            this.Nombre_Dueño.TextChanged += new System.EventHandler(this.Nombre_Dueño_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 43);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre del dueño:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "Eliga el tipo de Local:";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Guardar.Location = new System.Drawing.Point(719, 340);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Guardar.Size = new System.Drawing.Size(200, 84);
            this.btn_Guardar.TabIndex = 7;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Atras_1
            // 
            this.btn_Atras_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Atras_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Atras_1.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atras_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Atras_1.Location = new System.Drawing.Point(801, 478);
            this.btn_Atras_1.Name = "btn_Atras_1";
            this.btn_Atras_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Atras_1.Size = new System.Drawing.Size(154, 48);
            this.btn_Atras_1.TabIndex = 6;
            this.btn_Atras_1.Text = "Atrás";
            this.btn_Atras_1.UseVisualStyleBackColor = false;
            this.btn_Atras_1.Click += new System.EventHandler(this.btn_Atras_1_Click);
            // 
            // panel_Ver_Todos_Los_Locales
            // 
            this.panel_Ver_Todos_Los_Locales.Controls.Add(this.Ver_todo);
            this.panel_Ver_Todos_Los_Locales.Controls.Add(this.btn_atras_3);
            this.panel_Ver_Todos_Los_Locales.Location = new System.Drawing.Point(683, 331);
            this.panel_Ver_Todos_Los_Locales.Name = "panel_Ver_Todos_Los_Locales";
            this.panel_Ver_Todos_Los_Locales.Size = new System.Drawing.Size(59, 51);
            this.panel_Ver_Todos_Los_Locales.TabIndex = 4;
            this.panel_Ver_Todos_Los_Locales.Visible = false;
            this.panel_Ver_Todos_Los_Locales.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Ver_Todos_Los_Locales_Paint);
            // 
            // btn_atras_3
            // 
            this.btn_atras_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_atras_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atras_3.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras_3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_atras_3.Location = new System.Drawing.Point(808, 478);
            this.btn_atras_3.Name = "btn_atras_3";
            this.btn_atras_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_atras_3.Size = new System.Drawing.Size(147, 48);
            this.btn_atras_3.TabIndex = 7;
            this.btn_atras_3.Text = "Atrás";
            this.btn_atras_3.UseVisualStyleBackColor = false;
            this.btn_atras_3.Click += new System.EventHandler(this.btn_atras_3_Click);
            // 
            // panel_Revisar_Local
            // 
            this.panel_Revisar_Local.Controls.Add(this.Buscar);
            this.panel_Revisar_Local.Controls.Add(this.Id_Buscado);
            this.panel_Revisar_Local.Controls.Add(this.Texto_Segun_tipo);
            this.panel_Revisar_Local.Controls.Add(this.Horario_Local);
            this.panel_Revisar_Local.Controls.Add(this.label12);
            this.panel_Revisar_Local.Controls.Add(this.Tipo);
            this.panel_Revisar_Local.Controls.Add(this.label9);
            this.panel_Revisar_Local.Controls.Add(this.label8);
            this.panel_Revisar_Local.Controls.Add(this.Nombre_Dueno);
            this.panel_Revisar_Local.Controls.Add(this.Id_Ver);
            this.panel_Revisar_Local.Controls.Add(this.label6);
            this.panel_Revisar_Local.Controls.Add(this.label5);
            this.panel_Revisar_Local.Controls.Add(this.btn_Atras_2);
            this.panel_Revisar_Local.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Revisar_Local.Location = new System.Drawing.Point(0, 0);
            this.panel_Revisar_Local.Name = "panel_Revisar_Local";
            this.panel_Revisar_Local.Size = new System.Drawing.Size(967, 538);
            this.panel_Revisar_Local.TabIndex = 4;
            this.panel_Revisar_Local.Visible = false;
            this.panel_Revisar_Local.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Revisar_Local_Paint);
            // 
            // btn_Atras_2
            // 
            this.btn_Atras_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Atras_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Atras_2.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atras_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Atras_2.Location = new System.Drawing.Point(800, 478);
            this.btn_Atras_2.Name = "btn_Atras_2";
            this.btn_Atras_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Atras_2.Size = new System.Drawing.Size(155, 48);
            this.btn_Atras_2.TabIndex = 7;
            this.btn_Atras_2.Text = "Atrás";
            this.btn_Atras_2.UseVisualStyleBackColor = false;
            this.btn_Atras_2.Click += new System.EventHandler(this.btn_Atras_2_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Salir.Location = new System.Drawing.Point(822, 480);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Salir.Size = new System.Drawing.Size(133, 48);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Ver_todo
            // 
            this.Ver_todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Ver_todo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tipos,
            this.Dueno,
            this.Ids,
            this.Horarios});
            this.Ver_todo.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup13.Header = "Tipos";
            listViewGroup13.Name = "Tipos";
            listViewGroup14.Header = "Duenos";
            listViewGroup14.Name = "Duenos";
            listViewGroup15.Header = "Ids";
            listViewGroup15.Name = "Ids";
            listViewGroup15.Tag = "Ids";
            listViewGroup16.Header = "Horarios";
            listViewGroup16.Name = "Horarios";
            this.Ver_todo.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup13,
            listViewGroup14,
            listViewGroup15,
            listViewGroup16});
            this.Ver_todo.HideSelection = false;
            this.Ver_todo.Location = new System.Drawing.Point(12, 12);
            this.Ver_todo.Name = "Ver_todo";
            this.Ver_todo.Size = new System.Drawing.Size(943, 448);
            this.Ver_todo.TabIndex = 8;
            this.Ver_todo.UseCompatibleStateImageBehavior = false;
            this.Ver_todo.View = System.Windows.Forms.View.Details;
            // 
            // Tipos
            // 
            this.Tipos.Text = "Tipo";
            this.Tipos.Width = 168;
            // 
            // Dueno
            // 
            this.Dueno.Text = "Dueño";
            this.Dueno.Width = 217;
            // 
            // Ids
            // 
            this.Ids.Text = "ID";
            this.Ids.Width = 142;
            // 
            // Horarios
            // 
            this.Horarios.Text = "Horarios";
            this.Horarios.Width = 152;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre Dueño:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(634, 38);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ingrese ID del Local que desea ver";
            // 
            // Id_Ver
            // 
            this.Id_Ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Id_Ver.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Ver.Location = new System.Drawing.Point(53, 63);
            this.Id_Ver.Name = "Id_Ver";
            this.Id_Ver.Size = new System.Drawing.Size(392, 45);
            this.Id_Ver.TabIndex = 10;
            this.Id_Ver.TextChanged += new System.EventHandler(this.Id_Ver_TextChanged);
            // 
            // Nombre_Dueno
            // 
            this.Nombre_Dueno.AutoSize = true;
            this.Nombre_Dueno.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Dueno.Location = new System.Drawing.Point(110, 221);
            this.Nombre_Dueno.Name = "Nombre_Dueno";
            this.Nombre_Dueno.Size = new System.Drawing.Size(0, 38);
            this.Nombre_Dueno.TabIndex = 11;
            this.Nombre_Dueno.Click += new System.EventHandler(this.Nombre_Dueno_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(110, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 38);
            this.label8.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(110, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 38);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tipo:";
            // 
            // Horario_Local
            // 
            this.Horario_Local.AutoSize = true;
            this.Horario_Local.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horario_Local.Location = new System.Drawing.Point(574, 224);
            this.Horario_Local.Name = "Horario_Local";
            this.Horario_Local.Size = new System.Drawing.Size(0, 38);
            this.Horario_Local.TabIndex = 16;
            this.Horario_Local.Click += new System.EventHandler(this.Horario_Local_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(574, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 38);
            this.label12.TabIndex = 15;
            this.label12.Text = "Horario:";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.Location = new System.Drawing.Point(110, 329);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(0, 38);
            this.Tipo.TabIndex = 14;
            this.Tipo.Click += new System.EventHandler(this.Tipo_Click);
            // 
            // Id_Buscado
            // 
            this.Id_Buscado.AutoSize = true;
            this.Id_Buscado.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Buscado.Location = new System.Drawing.Point(574, 334);
            this.Id_Buscado.Name = "Id_Buscado";
            this.Id_Buscado.Size = new System.Drawing.Size(0, 38);
            this.Id_Buscado.TabIndex = 18;
            this.Id_Buscado.Click += new System.EventHandler(this.Valor_segun_tipo_Click);
            // 
            // Texto_Segun_tipo
            // 
            this.Texto_Segun_tipo.AutoSize = true;
            this.Texto_Segun_tipo.CausesValidation = false;
            this.Texto_Segun_tipo.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_Segun_tipo.Location = new System.Drawing.Point(574, 289);
            this.Texto_Segun_tipo.Name = "Texto_Segun_tipo";
            this.Texto_Segun_tipo.Size = new System.Drawing.Size(70, 38);
            this.Texto_Segun_tipo.TabIndex = 17;
            this.Texto_Segun_tipo.Text = "ID:";
            this.Texto_Segun_tipo.Click += new System.EventHandler(this.Texto_Segun_tipo_Click);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Buscar.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(581, 63);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(254, 44);
            this.Buscar.TabIndex = 19;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(967, 538);
            this.Controls.Add(this.panel_Nuevo_Local);
            this.Controls.Add(this.panel_Revisar_Local);
            this.Controls.Add(this.panel_Ver_Todos_Los_Locales);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Ver);
            this.Controls.Add(this.btn_revisar);
            this.Controls.Add(this.Btn_crear);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.Text = "Gestor de Locales";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel_Nuevo_Local.ResumeLayout(false);
            this.panel_Nuevo_Local.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numero_de_salas)).EndInit();
            this.panel_Ver_Todos_Los_Locales.ResumeLayout(false);
            this.panel_Revisar_Local.ResumeLayout(false);
            this.panel_Revisar_Local.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.Button btn_revisar;
        private System.Windows.Forms.Button btn_Ver;
        private System.Windows.Forms.Panel panel_Nuevo_Local;
        private System.Windows.Forms.Panel panel_Revisar_Local;
        private System.Windows.Forms.Panel panel_Ver_Todos_Los_Locales;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Atras_1;
        private System.Windows.Forms.Button btn_Atras_2;
        private System.Windows.Forms.Button btn_atras_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nombre_Dueño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Horario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label txt_tipo;
        private System.Windows.Forms.ComboBox Eleccion_Local;
        private System.Windows.Forms.ComboBox Exclusividad;
        private System.Windows.Forms.CheckedListBox Categorias;
        private System.Windows.Forms.NumericUpDown Numero_de_salas;
        private System.Windows.Forms.ListView Ver_todo;
        private System.Windows.Forms.ColumnHeader Tipos;
        private System.Windows.Forms.ColumnHeader Dueno;
        private System.Windows.Forms.ColumnHeader Ids;
        public System.Windows.Forms.ColumnHeader Horarios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Nombre_Dueno;
        private System.Windows.Forms.TextBox Id_Ver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Horario_Local;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Label Id_Buscado;
        private System.Windows.Forms.Label Texto_Segun_tipo;
        private System.Windows.Forms.Button Buscar;
    }
}

