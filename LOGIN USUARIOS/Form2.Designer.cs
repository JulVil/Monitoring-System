namespace LOGIN_USUARIOS
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.idalumno = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.carrera = new System.Windows.Forms.TextBox();
            this.semestre = new System.Windows.Forms.TextBox();
            this.tiempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cerrar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Completa los siguientes campos con tu información";
            // 
            // idalumno
            // 
            this.idalumno.Location = new System.Drawing.Point(138, 21);
            this.idalumno.Name = "idalumno";
            this.idalumno.Size = new System.Drawing.Size(148, 22);
            this.idalumno.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(138, 92);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(148, 22);
            this.nombre.TabIndex = 2;
            // 
            // apellidos
            // 
            this.apellidos.Location = new System.Drawing.Point(138, 126);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(148, 22);
            this.apellidos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carrera";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 48);
            this.label6.TabIndex = 9;
            this.label6.Text = "Semestre\r\n(número)";
            // 
            // carrera
            // 
            this.carrera.Location = new System.Drawing.Point(138, 160);
            this.carrera.Name = "carrera";
            this.carrera.Size = new System.Drawing.Size(148, 22);
            this.carrera.TabIndex = 4;
            // 
            // semestre
            // 
            this.semestre.Location = new System.Drawing.Point(138, 197);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(148, 22);
            this.semestre.TabIndex = 5;
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.BackColor = System.Drawing.Color.White;
            this.tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo.Location = new System.Drawing.Point(112, 423);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(89, 16);
            this.tiempo.TabIndex = 12;
            this.tiempo.Text = "Fecha y Hora";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.contraseña);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idalumno);
            this.groupBox1.Controls.Add(this.semestre);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.carrera);
            this.groupBox1.Controls.Add(this.apellidos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(115, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 255);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(138, 57);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(148, 22);
            this.contraseña.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contraseña";
            // 
            // cerrar
            // 
            this.cerrar.Image = global::LOGIN_USUARIOS.Properties.Resources.Actions_window_close_icon;
            this.cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cerrar.Location = new System.Drawing.Point(723, 412);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(61, 39);
            this.cerrar.TabIndex = 2;
            this.cerrar.Text = "Cerrar";
            this.cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // editar
            // 
            this.editar.Image = global::LOGIN_USUARIOS.Properties.Resources.Pencil_icon;
            this.editar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editar.Location = new System.Drawing.Point(562, 412);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(66, 39);
            this.editar.TabIndex = 0;
            this.editar.Text = "Editar";
            this.editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // guardar
            // 
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Image = global::LOGIN_USUARIOS.Properties.Resources.Save_icon;
            this.guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardar.Location = new System.Drawing.Point(634, 412);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(83, 39);
            this.guardar.TabIndex = 1;
            this.guardar.Text = "Guardar";
            this.guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LOGIN_USUARIOS.Properties.Resources.logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(889, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 247);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(42, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(752, 427);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1148, 524);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form2";
            this.Text = " Registro de Datos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox idalumno;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox carrera;
        private System.Windows.Forms.TextBox semestre;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button cerrar;

    }
}