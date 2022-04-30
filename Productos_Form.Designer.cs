namespace Ferreteria_Garabito_Pichardo
{
    partial class Productos_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos_Form));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Boton_Consulta = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.texto_Codigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.Boton_Guardar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgVista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgVista)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(906, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 38);
            this.button3.TabIndex = 58;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 38);
            this.button2.TabIndex = 57;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Boton_Consulta
            // 
            this.Boton_Consulta.Location = new System.Drawing.Point(171, 489);
            this.Boton_Consulta.Name = "Boton_Consulta";
            this.Boton_Consulta.Size = new System.Drawing.Size(78, 38);
            this.Boton_Consulta.TabIndex = 56;
            this.Boton_Consulta.Text = "Consultar";
            this.Boton_Consulta.UseVisualStyleBackColor = true;
            this.Boton_Consulta.Click += new System.EventHandler(this.Boton_Consulta_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(140, 101);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(146, 20);
            this.txtCodigo.TabIndex = 54;
            // 
            // texto_Codigo
            // 
            this.texto_Codigo.AutoSize = true;
            this.texto_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_Codigo.ForeColor = System.Drawing.Color.White;
            this.texto_Codigo.Location = new System.Drawing.Point(47, 97);
            this.texto_Codigo.Name = "texto_Codigo";
            this.texto_Codigo.Size = new System.Drawing.Size(71, 24);
            this.texto_Codigo.TabIndex = 53;
            this.texto_Codigo.Text = "Codigo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 158);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 52;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.White;
            this.Nombre.Location = new System.Drawing.Point(47, 153);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(79, 24);
            this.Nombre.TabIndex = 51;
            this.Nombre.Text = "Nombre";
            // 
            // Boton_Guardar
            // 
            this.Boton_Guardar.Location = new System.Drawing.Point(46, 489);
            this.Boton_Guardar.Name = "Boton_Guardar";
            this.Boton_Guardar.Size = new System.Drawing.Size(78, 38);
            this.Boton_Guardar.TabIndex = 50;
            this.Boton_Guardar.Text = "Guardar";
            this.Boton_Guardar.UseVisualStyleBackColor = true;
            this.Boton_Guardar.Click += new System.EventHandler(this.Boton_Guardar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(140, 387);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(146, 20);
            this.txtPrecio.TabIndex = 49;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(140, 324);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(146, 20);
            this.txtCantidad.TabIndex = 48;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(140, 269);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(146, 20);
            this.txtMarca.TabIndex = 47;
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(140, 216);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(146, 20);
            this.txtDetalles.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(47, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 24);
            this.label11.TabIndex = 45;
            this.label11.Text = "Precio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(47, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 24);
            this.label10.TabIndex = 44;
            this.label10.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(47, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Detalles";
            // 
            // DgVista
            // 
            this.DgVista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgVista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DgVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgVista.EnableHeadersVisualStyles = false;
            this.DgVista.Location = new System.Drawing.Point(337, 62);
            this.DgVista.Name = "DgVista";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DgVista.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgVista.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.DgVista.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgVista.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DgVista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.DgVista.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DgVista.Size = new System.Drawing.Size(626, 410);
            this.DgVista.TabIndex = 59;
            // 
            // Productos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1031, 614);
            this.Controls.Add(this.DgVista);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Boton_Consulta);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.texto_Codigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Boton_Guardar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Productos_Form";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgVista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Boton_Consulta;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label texto_Codigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button Boton_Guardar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgVista;
    }
}