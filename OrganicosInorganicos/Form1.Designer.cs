namespace OrganicosInorganicos
{
    partial class Form1
    {
        /// <summary>+
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
            picFruta1 = new PictureBox();
            picVerdura1 = new PictureBox();
            picBotella1 = new PictureBox();
            picVidrio1 = new PictureBox();
            label1 = new Label();
            lblResultadoJuego = new Label();
            panel1 = new Panel();
            picVidrio2 = new PictureBox();
            picBotella2 = new PictureBox();
            picVerdura2 = new PictureBox();
            picFruta2 = new PictureBox();
            label2 = new Label();
            lblInformacion = new Label();
            progressOrganicos = new ProgressBar();
            progressInorganicos = new ProgressBar();
            ORGÁNICOS = new Label();
            INORGÁNICOS = new Label();
            picllanta1 = new PictureBox();
            piccarton1 = new PictureBox();
            picllanta2 = new PictureBox();
            piccarton2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picFruta1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVerdura1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBotella1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVidrio1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVidrio2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBotella2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVerdura2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFruta2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picllanta1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piccarton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picllanta2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piccarton2).BeginInit();
            SuspendLayout();
            // 
            // picFruta1
            // 
            picFruta1.Cursor = Cursors.Hand;
            picFruta1.Image = Properties.Resources.tapa;
            picFruta1.Location = new Point(1451, 331);
            picFruta1.Name = "picFruta1";
            picFruta1.Size = new Size(151, 90);
            picFruta1.SizeMode = PictureBoxSizeMode.StretchImage;
            picFruta1.TabIndex = 0;
            picFruta1.TabStop = false;
            picFruta1.Click += Carta_Click;
            // 
            // picVerdura1
            // 
            picVerdura1.Cursor = Cursors.Hand;
            picVerdura1.Image = Properties.Resources.tapa;
            picVerdura1.Location = new Point(1451, 495);
            picVerdura1.Name = "picVerdura1";
            picVerdura1.Size = new Size(151, 90);
            picVerdura1.SizeMode = PictureBoxSizeMode.StretchImage;
            picVerdura1.TabIndex = 1;
            picVerdura1.TabStop = false;
            picVerdura1.Click += Carta_Click;
            // 
            // picBotella1
            // 
            picBotella1.Cursor = Cursors.Hand;
            picBotella1.Image = Properties.Resources.tapa;
            picBotella1.Location = new Point(1165, 331);
            picBotella1.Name = "picBotella1";
            picBotella1.Size = new Size(151, 90);
            picBotella1.SizeMode = PictureBoxSizeMode.StretchImage;
            picBotella1.TabIndex = 2;
            picBotella1.TabStop = false;
            picBotella1.Click += Carta_Click;
            // 
            // picVidrio1
            // 
            picVidrio1.Cursor = Cursors.Hand;
            picVidrio1.Image = Properties.Resources.tapa;
            picVidrio1.Location = new Point(1165, 495);
            picVidrio1.Name = "picVidrio1";
            picVidrio1.Size = new Size(151, 90);
            picVidrio1.SizeMode = PictureBoxSizeMode.StretchImage;
            picVidrio1.TabIndex = 4;
            picVidrio1.TabStop = false;
            picVidrio1.Click += Carta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(843, 37);
            label1.Name = "label1";
            label1.Size = new Size(419, 40);
            label1.TabIndex = 8;
            label1.Text = " Memorama de Reciclaje";
            // 
            // lblResultadoJuego
            // 
            lblResultadoJuego.AutoSize = true;
            lblResultadoJuego.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultadoJuego.Location = new Point(933, 125);
            lblResultadoJuego.Name = "lblResultadoJuego";
            lblResultadoJuego.Size = new Size(0, 45);
            lblResultadoJuego.TabIndex = 9;
            lblResultadoJuego.Click += lblResultadoJuego_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.YellowGreen;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblResultadoJuego);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(2136, 122);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // picVidrio2
            // 
            picVidrio2.Cursor = Cursors.Hand;
            picVidrio2.Image = Properties.Resources.tapa;
            picVidrio2.Location = new Point(871, 495);
            picVidrio2.Name = "picVidrio2";
            picVidrio2.Size = new Size(151, 90);
            picVidrio2.SizeMode = PictureBoxSizeMode.StretchImage;
            picVidrio2.TabIndex = 16;
            picVidrio2.TabStop = false;
            picVidrio2.Click += Carta_Click;
            // 
            // picBotella2
            // 
            picBotella2.Cursor = Cursors.Hand;
            picBotella2.Image = Properties.Resources.tapa;
            picBotella2.Location = new Point(585, 495);
            picBotella2.Name = "picBotella2";
            picBotella2.Size = new Size(151, 90);
            picBotella2.SizeMode = PictureBoxSizeMode.StretchImage;
            picBotella2.TabIndex = 18;
            picBotella2.TabStop = false;
            picBotella2.Click += Carta_Click;
            // 
            // picVerdura2
            // 
            picVerdura2.Cursor = Cursors.Hand;
            picVerdura2.Image = Properties.Resources.tapa;
            picVerdura2.Location = new Point(585, 331);
            picVerdura2.Name = "picVerdura2";
            picVerdura2.Size = new Size(151, 90);
            picVerdura2.SizeMode = PictureBoxSizeMode.StretchImage;
            picVerdura2.TabIndex = 19;
            picVerdura2.TabStop = false;
            picVerdura2.Click += Carta_Click;
            // 
            // picFruta2
            // 
            picFruta2.Cursor = Cursors.Hand;
            picFruta2.Image = Properties.Resources.tapa;
            picFruta2.Location = new Point(871, 331);
            picFruta2.Name = "picFruta2";
            picFruta2.Size = new Size(151, 90);
            picFruta2.SizeMode = PictureBoxSizeMode.StretchImage;
            picFruta2.TabIndex = 21;
            picFruta2.TabStop = false;
            picFruta2.Click += Carta_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stylus BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(854, 160);
            label2.Name = "label2";
            label2.Size = new Size(500, 44);
            label2.TabIndex = 23;
            label2.Text = "Encuentra los pares correctos";
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Stylus BT", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInformacion.Location = new Point(843, 252);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(0, 39);
            lblInformacion.TabIndex = 24;
            lblInformacion.Click += lblInformacion_Click;
            // 
            // progressOrganicos
            // 
            progressOrganicos.Location = new Point(61, 321);
            progressOrganicos.Name = "progressOrganicos";
            progressOrganicos.Size = new Size(291, 54);
            progressOrganicos.TabIndex = 25;
            progressOrganicos.Click += progressOrganicos_Click;
            // 
            // progressInorganicos
            // 
            progressInorganicos.Location = new Point(61, 495);
            progressInorganicos.Name = "progressInorganicos";
            progressInorganicos.Size = new Size(275, 58);
            progressInorganicos.TabIndex = 26;
            progressInorganicos.Click += progressInorganicos_Click;
            // 
            // ORGÁNICOS
            // 
            ORGÁNICOS.AutoSize = true;
            ORGÁNICOS.Location = new Point(61, 293);
            ORGÁNICOS.Name = "ORGÁNICOS";
            ORGÁNICOS.Size = new Size(93, 25);
            ORGÁNICOS.TabIndex = 27;
            ORGÁNICOS.Text = "Organicos";
            ORGÁNICOS.Click += ORGÁNICOS_Click;
            // 
            // INORGÁNICOS
            // 
            INORGÁNICOS.AutoSize = true;
            INORGÁNICOS.Location = new Point(61, 467);
            INORGÁNICOS.Name = "INORGÁNICOS";
            INORGÁNICOS.Size = new Size(105, 25);
            INORGÁNICOS.TabIndex = 28;
            INORGÁNICOS.Text = "Inorganicos";
            INORGÁNICOS.Click += INORGÁNICOS_Click;
            // 
            // picllanta1
            // 
            picllanta1.Cursor = Cursors.Hand;
            picllanta1.Image = Properties.Resources.tapa;
            picllanta1.Location = new Point(585, 662);
            picllanta1.Name = "picllanta1";
            picllanta1.Size = new Size(151, 89);
            picllanta1.SizeMode = PictureBoxSizeMode.StretchImage;
            picllanta1.TabIndex = 29;
            picllanta1.TabStop = false;
            picllanta1.Click += Carta_Click;
            // 
            // piccarton1
            // 
            piccarton1.Cursor = Cursors.Hand;
            piccarton1.Image = Properties.Resources.tapa;
            piccarton1.Location = new Point(871, 662);
            piccarton1.Name = "piccarton1";
            piccarton1.Size = new Size(151, 89);
            piccarton1.SizeMode = PictureBoxSizeMode.StretchImage;
            piccarton1.TabIndex = 30;
            piccarton1.TabStop = false;
            piccarton1.Click += Carta_Click;
            // 
            // picllanta2
            // 
            picllanta2.Cursor = Cursors.Hand;
            picllanta2.Image = Properties.Resources.tapa;
            picllanta2.Location = new Point(1165, 662);
            picllanta2.Name = "picllanta2";
            picllanta2.Size = new Size(151, 89);
            picllanta2.SizeMode = PictureBoxSizeMode.StretchImage;
            picllanta2.TabIndex = 31;
            picllanta2.TabStop = false;
            picllanta2.Click += Carta_Click;
            // 
            // piccarton2
            // 
            piccarton2.Cursor = Cursors.Hand;
            piccarton2.Image = Properties.Resources.tapa;
            piccarton2.Location = new Point(1451, 662);
            piccarton2.Name = "piccarton2";
            piccarton2.Size = new Size(151, 89);
            piccarton2.SizeMode = PictureBoxSizeMode.StretchImage;
            piccarton2.TabIndex = 32;
            piccarton2.TabStop = false;
            piccarton2.Click += Carta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 915);
            Controls.Add(piccarton2);
            Controls.Add(picllanta2);
            Controls.Add(piccarton1);
            Controls.Add(picllanta1);
            Controls.Add(INORGÁNICOS);
            Controls.Add(ORGÁNICOS);
            Controls.Add(progressInorganicos);
            Controls.Add(progressOrganicos);
            Controls.Add(lblInformacion);
            Controls.Add(label2);
            Controls.Add(picFruta2);
            Controls.Add(picVerdura2);
            Controls.Add(picBotella2);
            Controls.Add(picVidrio2);
            Controls.Add(panel1);
            Controls.Add(picVidrio1);
            Controls.Add(picBotella1);
            Controls.Add(picVerdura1);
            Controls.Add(picFruta1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picFruta1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVerdura1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBotella1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVidrio1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picVidrio2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBotella2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVerdura2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFruta2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picllanta1).EndInit();
            ((System.ComponentModel.ISupportInitialize)piccarton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picllanta2).EndInit();
            ((System.ComponentModel.ISupportInitialize)piccarton2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picFruta1;
        private PictureBox picVerdura1;
        private PictureBox picBotella1;
        private PictureBox picVidrio1;
        private Label label1;
        private Label lblResultadoJuego;
        private Panel panel1;
        private PictureBox picVidrio2;
        private PictureBox picBotella2;
        private PictureBox picVerdura2;
        private PictureBox picFruta2;
        private Label label2;
        private Label lblInformacion;
        private ProgressBar progressOrganicos;
        private ProgressBar progressInorganicos;
        private Label ORGÁNICOS;
        private Label INORGÁNICOS;
        private PictureBox picllanta1;
        private PictureBox piccarton1;
        private PictureBox picllanta2;
        private PictureBox piccarton2;
    }
}
