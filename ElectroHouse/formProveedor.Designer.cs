namespace ElectroHouse
{
    partial class formProveedor
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
            groupBox1 = new GroupBox();
            txtTelefono = new TextBox();
            label7 = new Label();
            label2 = new Label();
            button2 = new Button();
            txtRuc = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtCiudad = new TextBox();
            button1 = new Button();
            txtDireccion = new TextBox();
            txtNombreProveedor = new TextBox();
            txtCodigoProveedor = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            button3 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtRuc);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCiudad);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtNombreProveedor);
            groupBox1.Controls.Add(txtCodigoProveedor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(41, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 279);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(302, 178);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(164, 23);
            txtTelefono.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(324, 160);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 24;
            label7.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(198, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 30);
            label2.TabIndex = 23;
            label2.Text = "Proveedores";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Location = new Point(293, 222);
            button2.Name = "button2";
            button2.Size = new Size(98, 31);
            button2.TabIndex = 22;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtRuc
            // 
            txtRuc.Location = new Point(55, 178);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(164, 23);
            txtRuc.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(77, 160);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 20;
            label6.Text = "R.U.C:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(75, 104);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 17;
            label5.Text = "Nombre:";
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(302, 69);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(164, 23);
            txtCiudad.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(155, 222);
            button1.Name = "button1";
            button1.Size = new Size(91, 31);
            button1.TabIndex = 10;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(302, 122);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(171, 23);
            txtDireccion.TabIndex = 8;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(55, 122);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(149, 23);
            txtNombreProveedor.TabIndex = 7;
            // 
            // txtCodigoProveedor
            // 
            txtCodigoProveedor.Location = new Point(55, 69);
            txtCodigoProveedor.Name = "txtCodigoProveedor";
            txtCodigoProveedor.Size = new Size(129, 23);
            txtCodigoProveedor.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(322, 104);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(324, 51);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Ciudad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 51);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.Location = new Point(540, 518);
            button3.Name = "button3";
            button3.Size = new Size(91, 31);
            button3.TabIndex = 26;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(41, 325);
            listView1.Name = "listView1";
            listView1.Size = new Size(495, 181);
            listView1.TabIndex = 25;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Codigo";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Telefono";
            columnHeader3.Width = 120;
            // 
            // formProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 561);
            Controls.Add(button3);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Name = "formProveedor";
            Text = "formProveedor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTelefono;
        private Label label7;
        private Label label2;
        private Button button2;
        private TextBox txtRuc;
        private Label label6;
        private Label label5;
        private TextBox txtCiudad;
        private Button button1;
        private TextBox txtDireccion;
        private TextBox txtNombreProveedor;
        private TextBox txtCodigoProveedor;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button button3;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}