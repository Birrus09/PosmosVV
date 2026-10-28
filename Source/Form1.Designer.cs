namespace PosmosVV
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
            galaxySizeTrackBar = new TrackBar();
            galaxySizeValueLabel = new Label();
            scatterTrackBar = new TrackBar();
            scatterValueLabel = new Label();
            startButton = new Button();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)galaxySizeTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scatterTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // galaxySizeTrackBar
            // 
            galaxySizeTrackBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            galaxySizeTrackBar.Location = new Point(8, 329);
            galaxySizeTrackBar.Maximum = 500000;
            galaxySizeTrackBar.Minimum = 5000;
            galaxySizeTrackBar.Name = "galaxySizeTrackBar";
            galaxySizeTrackBar.Size = new Size(784, 45);
            galaxySizeTrackBar.TabIndex = 0;
            galaxySizeTrackBar.TickFrequency = 25000;
            galaxySizeTrackBar.Value = 8500;
            galaxySizeTrackBar.ValueChanged += galaxySizeTrackBar_ValueChanged;
            // 
            // galaxySizeValueLabel
            // 
            galaxySizeValueLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            galaxySizeValueLabel.AutoSize = true;
            galaxySizeValueLabel.ForeColor = Color.White;
            galaxySizeValueLabel.Location = new Point(12, 310);
            galaxySizeValueLabel.Name = "galaxySizeValueLabel";
            galaxySizeValueLabel.Size = new Size(94, 15);
            galaxySizeValueLabel.TabIndex = 1;
            galaxySizeValueLabel.Text = "Galaxy size: 8500";
            // 
            // scatterTrackBar
            // 
            scatterTrackBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            scatterTrackBar.Location = new Point(8, 395);
            scatterTrackBar.Maximum = 100000;
            scatterTrackBar.Name = "scatterTrackBar";
            scatterTrackBar.Size = new Size(784, 45);
            scatterTrackBar.TabIndex = 0;
            scatterTrackBar.TickFrequency = 10000;
            scatterTrackBar.Value = 31055;
            scatterTrackBar.ValueChanged += scatterTrackBar_ValueChanged;
            // 
            // scatterValueLabel
            // 
            scatterValueLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            scatterValueLabel.AutoSize = true;
            scatterValueLabel.ForeColor = Color.White;
            scatterValueLabel.Location = new Point(12, 376);
            scatterValueLabel.Name = "scatterValueLabel";
            scatterValueLabel.Size = new Size(88, 15);
            scatterValueLabel.TabIndex = 1;
            scatterValueLabel.Text = "Scatter: 0.31055";
            // 
            // startButton
            // 
            startButton.Location = new Point(360, 207);
            startButton.Name = "startButton";
            startButton.Size = new Size(80, 36);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(-2, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 253);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            panel1.MouseClick += Form1_MouseClick;
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.Location = new Point(26, 275);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 25);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Gen 2";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 250);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 2;
            label1.Text = "Generation algorithm";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(602, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(startButton);
            Controls.Add(galaxySizeTrackBar);
            Controls.Add(galaxySizeValueLabel);
            Controls.Add(scatterTrackBar);
            Controls.Add(scatterValueLabel);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(panel1);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            Text = "POSMOS";
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)galaxySizeTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)scatterTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar galaxySizeTrackBar;
        private Label galaxySizeValueLabel;
        private TrackBar scatterTrackBar;
        private Label scatterValueLabel;
        private Button startButton;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private CheckBox checkBox1;
    }
}
