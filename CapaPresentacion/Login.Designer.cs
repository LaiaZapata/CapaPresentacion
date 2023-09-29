namespace CapaPresentacion
{
    partial class Login
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
            btnIniciar = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            btnCerrarprog = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.IndianRed;
            btnIniciar.Font = new Font("Lucida Fax", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.Location = new Point(11, 166);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(160, 55);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "INGRESAR";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.BurlyWood;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 15);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.BurlyWood;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 98);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.f14;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(btnIniciar);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 238);
            panel1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(btnCerrarprog);
            panel2.Location = new Point(-4, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 36);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // btnCerrarprog
            // 
            btnCerrarprog.BackColor = Color.Salmon;
            btnCerrarprog.Location = new Point(27, 3);
            btnCerrarprog.Name = "btnCerrarprog";
            btnCerrarprog.Size = new Size(160, 29);
            btnCerrarprog.TabIndex = 0;
            btnCerrarprog.Text = "SALIR";
            btnCerrarprog.UseVisualStyleBackColor = false;
            btnCerrarprog.Click += btnCerrarprog_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Location = new Point(-4, 286);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 36);
            panel3.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(208, 306);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel2;
        private Button btnCerrarprog;
        private Panel panel3;
    }
}