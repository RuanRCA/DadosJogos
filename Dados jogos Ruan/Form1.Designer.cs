namespace WinFormsApp9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gpbNomeUsuario = new GroupBox();
            btnOk = new Button();
            textBox1 = new TextBox();
            lblNome = new Label();
            gpbPlacar = new GroupBox();
            lblPontosMaquina = new Label();
            lblPontosSapiens = new Label();
            pcbMaquina = new PictureBox();
            pcbVS = new PictureBox();
            pcbHomoSapiens = new PictureBox();
            gpbStop = new GroupBox();
            btnStop = new Button();
            gpbUsuario = new GroupBox();
            pcbDados = new PictureBox();
            gpbMaquina = new GroupBox();
            pcbDados1 = new PictureBox();
            gpbNomeUsuario.SuspendLayout();
            gpbPlacar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMaquina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbVS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbHomoSapiens).BeginInit();
            gpbStop.SuspendLayout();
            gpbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbDados).BeginInit();
            gpbMaquina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbDados1).BeginInit();
            SuspendLayout();
            // 
            // gpbNomeUsuario
            // 
            gpbNomeUsuario.Controls.Add(btnOk);
            gpbNomeUsuario.Controls.Add(textBox1);
            gpbNomeUsuario.Controls.Add(lblNome);
            gpbNomeUsuario.Location = new Point(12, 22);
            gpbNomeUsuario.Name = "gpbNomeUsuario";
            gpbNomeUsuario.Size = new Size(336, 191);
            gpbNomeUsuario.TabIndex = 0;
            gpbNomeUsuario.TabStop = false;
            gpbNomeUsuario.Text = "Player1";
            // 
            // btnOk
            // 
            btnOk.BackColor = SystemColors.HighlightText;
            btnOk.Image = Properties.Resources.botao_iniciar_resized;
            btnOk.Location = new Point(22, 81);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(148, 103);
            btnOk.TabIndex = 2;
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += txtnome;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 44);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(130, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do Jogador";
            // 
            // gpbPlacar
            // 
            gpbPlacar.Controls.Add(lblPontosMaquina);
            gpbPlacar.Controls.Add(lblPontosSapiens);
            gpbPlacar.Controls.Add(pcbMaquina);
            gpbPlacar.Controls.Add(pcbVS);
            gpbPlacar.Controls.Add(pcbHomoSapiens);
            gpbPlacar.Location = new Point(387, 22);
            gpbPlacar.Name = "gpbPlacar";
            gpbPlacar.Size = new Size(483, 229);
            gpbPlacar.TabIndex = 1;
            gpbPlacar.TabStop = false;
            gpbPlacar.Text = "Placar";
            // 
            // lblPontosMaquina
            // 
            lblPontosMaquina.AutoSize = true;
            lblPontosMaquina.Location = new Point(405, 206);
            lblPontosMaquina.Name = "lblPontosMaquina";
            lblPontosMaquina.Size = new Size(17, 20);
            lblPontosMaquina.TabIndex = 4;
            lblPontosMaquina.Text = "0";
            // 
            // lblPontosSapiens
            // 
            lblPontosSapiens.AutoSize = true;
            lblPontosSapiens.Location = new Point(71, 206);
            lblPontosSapiens.Name = "lblPontosSapiens";
            lblPontosSapiens.Size = new Size(17, 20);
            lblPontosSapiens.TabIndex = 3;
            lblPontosSapiens.Text = "0";
            // 
            // pcbMaquina
            // 
            pcbMaquina.Image = Properties.Resources.robos_pensando;
            pcbMaquina.Location = new Point(334, 19);
            pcbMaquina.Name = "pcbMaquina";
            pcbMaquina.Size = new Size(143, 184);
            pcbMaquina.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbMaquina.TabIndex = 2;
            pcbMaquina.TabStop = false;
            // 
            // pcbVS
            // 
            pcbVS.Image = (Image)resources.GetObject("pcbVS.Image");
            pcbVS.Location = new Point(193, 57);
            pcbVS.Name = "pcbVS";
            pcbVS.Size = new Size(135, 82);
            pcbVS.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbVS.TabIndex = 1;
            pcbVS.TabStop = false;
            // 
            // pcbHomoSapiens
            // 
            pcbHomoSapiens.Image = Properties.Resources.Homos_Sapiens;
            pcbHomoSapiens.Location = new Point(6, 19);
            pcbHomoSapiens.Name = "pcbHomoSapiens";
            pcbHomoSapiens.Size = new Size(181, 184);
            pcbHomoSapiens.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbHomoSapiens.TabIndex = 0;
            pcbHomoSapiens.TabStop = false;
            // 
            // gpbStop
            // 
            gpbStop.Controls.Add(btnStop);
            gpbStop.Location = new Point(18, 275);
            gpbStop.Name = "gpbStop";
            gpbStop.Size = new Size(164, 186);
            gpbStop.TabIndex = 2;
            gpbStop.TabStop = false;
            gpbStop.Text = "Stop";
            // 
            // btnStop
            // 
            btnStop.Image = Properties.Resources.icons8_gesto_de_parar_100;
            btnStop.Location = new Point(16, 48);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(129, 114);
            btnStop.TabIndex = 0;
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // gpbUsuario
            // 
            gpbUsuario.Controls.Add(pcbDados);
            gpbUsuario.Location = new Point(307, 257);
            gpbUsuario.Name = "gpbUsuario";
            gpbUsuario.Size = new Size(286, 232);
            gpbUsuario.TabIndex = 3;
            gpbUsuario.TabStop = false;
            gpbUsuario.Text = "Usuário";
            // 
            // pcbDados
            // 
            pcbDados.Image = Properties.Resources.Mente_pensante;
            pcbDados.Location = new Point(50, 26);
            pcbDados.Name = "pcbDados";
            pcbDados.Size = new Size(170, 189);
            pcbDados.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDados.TabIndex = 0;
            pcbDados.TabStop = false;
            // 
            // gpbMaquina
            // 
            gpbMaquina.Controls.Add(pcbDados1);
            gpbMaquina.Location = new Point(646, 266);
            gpbMaquina.Name = "gpbMaquina";
            gpbMaquina.Size = new Size(272, 223);
            gpbMaquina.TabIndex = 4;
            gpbMaquina.TabStop = false;
            gpbMaquina.Text = "Máquina";
            // 
            // pcbDados1
            // 
            pcbDados1.Image = Properties.Resources.Matrix_programação;
            pcbDados1.Location = new Point(24, 26);
            pcbDados1.Name = "pcbDados1";
            pcbDados1.Size = new Size(220, 180);
            pcbDados1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDados1.TabIndex = 0;
            pcbDados1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 502);
            Controls.Add(gpbMaquina);
            Controls.Add(gpbUsuario);
            Controls.Add(gpbStop);
            Controls.Add(gpbPlacar);
            Controls.Add(gpbNomeUsuario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gpbNomeUsuario.ResumeLayout(false);
            gpbNomeUsuario.PerformLayout();
            gpbPlacar.ResumeLayout(false);
            gpbPlacar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMaquina).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbVS).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbHomoSapiens).EndInit();
            gpbStop.ResumeLayout(false);
            gpbUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbDados).EndInit();
            gpbMaquina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbDados1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbNomeUsuario;
        private Button btnOk;
        private TextBox textBox1;
        private Label lblNome;
        private GroupBox gpbPlacar;
        private PictureBox pcbMaquina;
        private PictureBox pcbVS;
        private PictureBox pcbHomoSapiens;
        private Label lblPontosMaquina;
        private Label lblPontosSapiens;
        private GroupBox gpbStop;
        private Button btnStop;
        private GroupBox gpbUsuario;
        private PictureBox pcbDados;
        private GroupBox gpbMaquina;
        private PictureBox pcbDados1;
    }
}
