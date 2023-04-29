namespace LOGIN_USUARIOS
{
    partial class Form5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.grafica = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataview
            // 
            this.dataview.BackgroundColor = System.Drawing.Color.White;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Location = new System.Drawing.Point(12, 40);
            this.dataview.Name = "dataview";
            this.dataview.Size = new System.Drawing.Size(577, 311);
            this.dataview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tabla de usuarios registrados";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 40);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(439, 311);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grafica de usarios registrados";
            // 
            // grafica
            // 
            this.grafica.Image = global::LOGIN_USUARIOS.Properties.Resources.chart_icon;
            this.grafica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.grafica.Location = new System.Drawing.Point(383, 396);
            this.grafica.Name = "grafica";
            this.grafica.Size = new System.Drawing.Size(68, 36);
            this.grafica.TabIndex = 0;
            this.grafica.Text = "Mostrar Grafica";
            this.grafica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grafica.UseVisualStyleBackColor = true;
            this.grafica.Click += new System.EventHandler(this.grafica_Click);
            // 
            // tabla
            // 
            this.tabla.Image = global::LOGIN_USUARIOS.Properties.Resources.Table_icon;
            this.tabla.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tabla.Location = new System.Drawing.Point(458, 396);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(66, 36);
            this.tabla.TabIndex = 1;
            this.tabla.Text = "Mostrar Tabla";
            this.tabla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabla.UseVisualStyleBackColor = true;
            this.tabla.Click += new System.EventHandler(this.tabla_Click);
            // 
            // cerrar
            // 
            this.cerrar.Image = global::LOGIN_USUARIOS.Properties.Resources.Actions_window_close_icon;
            this.cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cerrar.Location = new System.Drawing.Point(530, 396);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(61, 36);
            this.cerrar.TabIndex = 2;
            this.cerrar.Text = "Cerrar";
            this.cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(603, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grafica);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.dataview);
            this.Name = "Form5";
            this.Text = "Datos de Usuarios";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button tabla;
        private System.Windows.Forms.Button grafica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
    }
}