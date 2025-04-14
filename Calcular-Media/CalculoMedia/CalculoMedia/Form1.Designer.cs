namespace CalculoMedia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            btnSair = new Button();
            btnLimpar = new Button();
            btnCalcular = new Button();
            label1 = new Label();
            lblNota2 = new Label();
            lblNota3 = new Label();
            txtMedia = new TextBox();
            textBox2 = new TextBox();
            lblMedia = new Label();
            txtStatus = new Label();
            SuspendLayout();
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(88, 61);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(125, 27);
            txtNota1.TabIndex = 0;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(311, 61);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(125, 27);
            txtNota2.TabIndex = 1;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(528, 61);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(125, 27);
            txtNota3.TabIndex = 2;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(694, 12);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(694, 60);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(694, 112);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 69);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 6;
            label1.Text = "Nota1:";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(255, 69);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(53, 20);
            lblNota2.TabIndex = 7;
            lblNota2.Text = "Nota2:";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Location = new Point(472, 68);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(53, 20);
            lblNota3.TabIndex = 8;
            lblNota3.Text = "Nota3:";
            // 
            // txtMedia
            // 
            txtMedia.Enabled = false;
            txtMedia.Location = new Point(88, 242);
            txtMedia.Name = "txtMedia";
            txtMedia.ReadOnly = true;
            txtMedia.Size = new Size(125, 27);
            txtMedia.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(311, 242);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(32, 249);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(54, 20);
            lblMedia.TabIndex = 11;
            lblMedia.Text = "Média:";
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.Location = new Point(253, 249);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(52, 20);
            txtStatus.TabIndex = 12;
            txtStatus.Text = "Status:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStatus);
            Controls.Add(lblMedia);
            Controls.Add(textBox2);
            Controls.Add(txtMedia);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private Button btnSair;
        private Button btnLimpar;
        private Button btnCalcular;
        private Label label1;
        private Label lblNota2;
        private Label lblNota3;
        private TextBox txtMedia;
        private TextBox textBox2;
        private Label lblMedia;
        private Label txtStatus;
    }
}
