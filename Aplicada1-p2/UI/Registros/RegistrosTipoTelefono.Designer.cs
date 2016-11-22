namespace Aplicada1_p2.UI.Registros
{
    partial class RegistrosTipoTelefono
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
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClientescomboBox = new System.Windows.Forms.ComboBox();
            this.ClientesdataGridView = new System.Windows.Forms.DataGridView();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.TipoIdtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(410, 397);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 21;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(271, 397);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(75, 23);
            this.Modificarbutton.TabIndex = 20;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(145, 397);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 19;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(31, 397);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 18;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClientescomboBox);
            this.groupBox1.Controls.Add(this.ClientesdataGridView);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Location = new System.Drawing.Point(24, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 229);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes:";
            // 
            // ClientescomboBox
            // 
            this.ClientescomboBox.FormattingEnabled = true;
            this.ClientescomboBox.Location = new System.Drawing.Point(7, 20);
            this.ClientescomboBox.Name = "ClientescomboBox";
            this.ClientescomboBox.Size = new System.Drawing.Size(121, 21);
            this.ClientescomboBox.TabIndex = 2;
            // 
            // ClientesdataGridView
            // 
            this.ClientesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesdataGridView.Location = new System.Drawing.Point(7, 57);
            this.ClientesdataGridView.Name = "ClientesdataGridView";
            this.ClientesdataGridView.Size = new System.Drawing.Size(476, 133);
            this.ClientesdataGridView.TabIndex = 1;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(408, 3);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 23);
            this.Agregarbutton.TabIndex = 0;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(152, 34);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 16;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(46, 89);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(174, 20);
            this.DescripciontextBox.TabIndex = 15;
            // 
            // TipoIdtextBox
            // 
            this.TipoIdtextBox.Location = new System.Drawing.Point(46, 37);
            this.TipoIdtextBox.Name = "TipoIdtextBox";
            this.TipoIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.TipoIdtextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "TipoId:";
            // 
            // RegistrosTipoTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 477);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.TipoIdtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrosTipoTelefono";
            this.Text = "RegistrosTipoTelefono";
            this.Load += new System.EventHandler(this.RegistrosTipoTelefono_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ClientescomboBox;
        private System.Windows.Forms.DataGridView ClientesdataGridView;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox TipoIdtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}