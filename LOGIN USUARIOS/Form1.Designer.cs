namespace LOGIN_USUARIOS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.acceder = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.nuevo = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROUTER CNC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa tus datos:";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(129, 74);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(144, 20);
            this.usuario.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.contraseña);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.acceder);
            this.groupBox1.Controls.Add(this.usuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(891, 424);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 207);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(129, 107);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(144, 20);
            this.contraseña.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Matricula";
            // 
            // acceder
            // 
            this.acceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceder.Image = global::LOGIN_USUARIOS.Properties.Resources.Button_Ok_icon;
            this.acceder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.acceder.Location = new System.Drawing.Point(129, 146);
            this.acceder.Name = "acceder";
            this.acceder.Size = new System.Drawing.Size(85, 24);
            this.acceder.TabIndex = 2;
            this.acceder.Text = "Acceder";
            this.acceder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acceder.UseVisualStyleBackColor = true;
            this.acceder.Click += new System.EventHandler(this.acceder_Click);
            // 
            // salir
            // 
            this.salir.Image = global::LOGIN_USUARIOS.Properties.Resources.Actions_window_close_icon;
            this.salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salir.Location = new System.Drawing.Point(12, 987);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(52, 34);
            this.salir.TabIndex = 2;
            this.salir.Text = "Salir";
            this.salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1426, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tiempo";
            // 
            // nuevo
            // 
            this.nuevo.Image = global::LOGIN_USUARIOS.Properties.Resources.Actions_contact_new_icon;
            this.nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevo.Location = new System.Drawing.Point(167, 987);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(112, 34);
            this.nuevo.TabIndex = 0;
            this.nuevo.Text = "Nuevo Usuario o Editar Usuario";
            this.nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // admin
            // 
            this.admin.Image = global::LOGIN_USUARIOS.Properties.Resources.Administrator_icon;
            this.admin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.admin.Location = new System.Drawing.Point(70, 987);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(91, 34);
            this.admin.TabIndex = 1;
            this.admin.Text = "Administrador";
            this.admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::LOGIN_USUARIOS.Properties.Resources.forndo_de_pantalla;
            this.ClientSize = new System.Drawing.Size(1822, 1033);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sistema de Monitoreo CNC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Button acceder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button admin;
    }
}

