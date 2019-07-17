namespace WcfEntity
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_rut = new System.Windows.Forms.TextBox();
            this.txt_dvRut = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.btb_listarPorId = new System.Windows.Forms.Button();
            this.dgv_personas = new System.Windows.Forms.DataGridView();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_listar_todos = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rut:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DvRut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Correo:";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(94, 13);
            this.txt_nombres.MaxLength = 250;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(127, 20);
            this.txt_nombres.TabIndex = 7;
            this.txt_nombres.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_nombres_Validating);
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(93, 39);
            this.txt_apellidos.MaxLength = 250;
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(128, 20);
            this.txt_apellidos.TabIndex = 8;
            this.txt_apellidos.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_apellidos_Validating);
            // 
            // txt_rut
            // 
            this.txt_rut.Location = new System.Drawing.Point(93, 65);
            this.txt_rut.MaxLength = 8;
            this.txt_rut.Name = "txt_rut";
            this.txt_rut.Size = new System.Drawing.Size(128, 20);
            this.txt_rut.TabIndex = 9;
            this.txt_rut.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_rut_Validating);
            // 
            // txt_dvRut
            // 
            this.txt_dvRut.Location = new System.Drawing.Point(283, 65);
            this.txt_dvRut.MaxLength = 1;
            this.txt_dvRut.Name = "txt_dvRut";
            this.txt_dvRut.Size = new System.Drawing.Size(40, 20);
            this.txt_dvRut.TabIndex = 10;
            this.txt_dvRut.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_dvRut_Validating);
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(93, 94);
            this.txt_edad.MaxLength = 2;
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(128, 20);
            this.txt_edad.TabIndex = 11;
            this.txt_edad.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_edad_Validating);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(93, 120);
            this.txt_direccion.MaxLength = 250;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(128, 20);
            this.txt_direccion.TabIndex = 12;
            this.txt_direccion.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_direccion_Validating);
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(93, 146);
            this.txt_correo.MaxLength = 250;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(128, 20);
            this.txt_correo.TabIndex = 13;
            this.txt_correo.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_correo_Validating);
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(25, 199);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(75, 23);
            this.btn_insertar.TabIndex = 14;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.Btn_insertar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Busqueda por Id ";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(472, 142);
            this.txt_Id.MaxLength = 3;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(107, 20);
            this.txt_Id.TabIndex = 16;
            // 
            // btb_listarPorId
            // 
            this.btb_listarPorId.Location = new System.Drawing.Point(381, 199);
            this.btb_listarPorId.Name = "btb_listarPorId";
            this.btb_listarPorId.Size = new System.Drawing.Size(75, 23);
            this.btb_listarPorId.TabIndex = 17;
            this.btb_listarPorId.Text = "Listar por Id";
            this.btb_listarPorId.UseVisualStyleBackColor = true;
            this.btb_listarPorId.Click += new System.EventHandler(this.Btb_listarPorId_Click);
            // 
            // dgv_personas
            // 
            this.dgv_personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_personas.Location = new System.Drawing.Point(12, 263);
            this.dgv_personas.Name = "dgv_personas";
            this.dgv_personas.Size = new System.Drawing.Size(841, 150);
            this.dgv_personas.TabIndex = 18;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(106, 199);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 19;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(381, 229);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "Limpiar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(187, 199);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 21;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // btn_listar_todos
            // 
            this.btn_listar_todos.Location = new System.Drawing.Point(472, 199);
            this.btn_listar_todos.Name = "btn_listar_todos";
            this.btn_listar_todos.Size = new System.Drawing.Size(75, 23);
            this.btn_listar_todos.TabIndex = 22;
            this.btn_listar_todos.Text = "Listar Todos";
            this.btn_listar_todos.UseVisualStyleBackColor = true;
            this.btn_listar_todos.Click += new System.EventHandler(this.Btn_listar_todos_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.btn_listar_todos);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.dgv_personas);
            this.Controls.Add(this.btb_listarPorId);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_dvRut);
            this.Controls.Add(this.txt_rut);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formulario de Ingreso de Personas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_rut;
        private System.Windows.Forms.TextBox txt_dvRut;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button btb_listarPorId;
        private System.Windows.Forms.DataGridView dgv_personas;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_listar_todos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

