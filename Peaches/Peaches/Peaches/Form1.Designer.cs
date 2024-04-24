namespace Peaches
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
            Background = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            StartButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Background).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Background
            // 
            Background.BackgroundImage = (Image)resources.GetObject("Background.BackgroundImage");
            Background.Location = new Point(57, 12);
            Background.Name = "Background";
            Background.Size = new Size(0, 0);
            Background.SizeMode = PictureBoxSizeMode.CenterImage;
            Background.TabIndex = 0;
            Background.TabStop = false;
            Background.Click += pictureBox1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-8, -32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 670);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 192, 255);
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(-8, 536);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 102);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.White;
            StartButton.Font = new Font("Gill Sans MT Condensed", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartButton.ForeColor = Color.DarkSalmon;
            StartButton.Location = new Point(136, 570);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(114, 49);
            StartButton.TabIndex = 3;
            StartButton.Text = "Empezar";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += RestartGame;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 631);
            Controls.Add(StartButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Background);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(400, 670);
            Name = "Form1";
            Text = "Peaches";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Background).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox Background;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button StartButton;
    }
}
