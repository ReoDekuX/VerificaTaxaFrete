namespace VerificaTaxaFrete.View
{
    partial class TelaPrincipal
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnLimpar = new Button();
            tbxFrete = new TextBox();
            label5 = new Label();
            btnCalcular = new Button();
            tbxGramas = new TextBox();
            cbxDestino = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            tbxNome = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 43);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 0;
            label1.Text = "Calcular Frete";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 99);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(tbxFrete);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(tbxGramas);
            groupBox1.Controls.Add(cbxDestino);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(85, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 237);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informções do Pacote";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(315, 44);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(92, 44);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += button2_Click;
            // 
            // tbxFrete
            // 
            tbxFrete.Location = new Point(152, 154);
            tbxFrete.Name = "tbxFrete";
            tbxFrete.ReadOnly = true;
            tbxFrete.Size = new Size(119, 29);
            tbxFrete.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 157);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 5;
            label5.Text = "Valor do Frete:";
            // 
            // btnCalcular
            // 
            btnCalcular.Image = Properties.Resources.icons8_caminhão_de_carga_50;
            btnCalcular.Location = new Point(305, 111);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(124, 112);
            btnCalcular.TabIndex = 4;
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // tbxGramas
            // 
            tbxGramas.Location = new Point(159, 89);
            tbxGramas.Name = "tbxGramas";
            tbxGramas.Size = new Size(119, 29);
            tbxGramas.TabIndex = 3;
            // 
            // cbxDestino
            // 
            cbxDestino.FormattingEnabled = true;
            cbxDestino.Items.AddRange(new object[] { "SP", "RJ", "MG", "BA", "PE", "PB" });
            cbxDestino.Location = new Point(93, 28);
            cbxDestino.Name = "cbxDestino";
            cbxDestino.Size = new Size(88, 29);
            cbxDestino.TabIndex = 2;
            cbxDestino.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(24, 92);
            label4.Name = "label4";
            label4.Size = new Size(129, 21);
            label4.TabIndex = 1;
            label4.Text = "Peso em Gramas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(15, 31);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 0;
            label3.Text = "Destino:";
            // 
            // tbxNome
            // 
            tbxNome.Location = new Point(85, 126);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(368, 23);
            tbxNome.TabIndex = 3;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(562, 483);
            Controls.Add(tbxNome);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema do Calculo de Frete";
            Load += TelaPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private TextBox tbxNome;
        private ComboBox cbxDestino;
        private TextBox tbxGramas;
        private Button btnCalcular;
        private TextBox tbxFrete;
        private Label label5;
        private Button btnLimpar;
    }
}