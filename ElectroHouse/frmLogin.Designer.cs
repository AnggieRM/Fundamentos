namespace ElectroHouse
{
    partial class frmLogin
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
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button5 = new Button();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label10 = new Label();
            label11 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(121, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(207, 283);
            button4.Name = "button4";
            button4.Size = new Size(87, 22);
            button4.TabIndex = 41;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(62, 283);
            button5.Name = "button5";
            button5.Size = new Size(87, 22);
            button5.TabIndex = 40;
            button5.Text = "Entrar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(87, 214);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(170, 23);
            txtContraseña.TabIndex = 39;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(87, 160);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(170, 23);
            txtUsuario.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(87, 196);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 37;
            label10.Text = "Contraseña:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(87, 142);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 36;
            label11.Text = "Usuario:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(314, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(330, 223);
            dataGridView1.TabIndex = 43;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(671, 344);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label10);
            Controls.Add(label11);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button4;
        private Button button5;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label10;
        private Label label11;
        private DataGridView dataGridView1;
    }
}