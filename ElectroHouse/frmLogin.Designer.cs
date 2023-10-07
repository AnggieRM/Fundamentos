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
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(401, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.Location = new Point(489, 271);
            button4.Name = "button4";
            button4.Size = new Size(87, 22);
            button4.TabIndex = 41;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.Location = new Point(344, 271);
            button5.Name = "button5";
            button5.Size = new Size(87, 22);
            button5.TabIndex = 40;
            button5.Text = "Entrar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(367, 213);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(170, 23);
            txtContraseña.TabIndex = 39;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(367, 159);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(170, 23);
            txtUsuario.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(367, 195);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 37;
            label10.Text = "Contraseña:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(367, 141);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 36;
            label11.Text = "Usuario:";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(284, 325);
            label1.TabIndex = 43;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.MenuHighlight;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(12, 204);
            label2.Name = "label2";
            label2.Size = new Size(262, 32);
            label2.TabIndex = 44;
            label2.Text = "Sistema de Inventario";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.MenuHighlight;
            pictureBox2.Image = Properties.Resources.kisspng_inventory_management_software_warehouse_management_warehouse_5ac5d4a20a7bb9_278567911522914466043;
            pictureBox2.Location = new Point(64, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(147, 134);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(616, 325);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label10);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}