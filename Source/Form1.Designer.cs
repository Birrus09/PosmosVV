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
            panel1 = new Panel();
            galaxySizeTrackBar = new TrackBar();
            galaxySizeValueLabel = new Label();
            scatterTrackBar = new TrackBar();
            scatterValueLabel = new Label();
            startButton = new Button();
            ((System.ComponentModel.ISupportInitialize)galaxySizeTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scatterTrackBar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            // 
            // galaxySizeTrackBar
            // 
            galaxySizeTrackBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            galaxySizeTrackBar.Location = new Point(8, 329);
            galaxySizeTrackBar.Minimum = 5000;
            galaxySizeTrackBar.Maximum = 500000;
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
            galaxySizeValueLabel.ForeColor = Color.Black;
            galaxySizeValueLabel.Location = new Point(12, 310);
            galaxySizeValueLabel.Name = "galaxySizeValueLabel";
            galaxySizeValueLabel.Size = new Size(116, 15);
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
            scatterValueLabel.ForeColor = Color.Black;
            scatterValueLabel.Location = new Point(12, 376);
            scatterValueLabel.Name = "scatterValueLabel";
            scatterValueLabel.Size = new Size(106, 15);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(startButton);
            Controls.Add(galaxySizeTrackBar);
            Controls.Add(galaxySizeValueLabel);
            Controls.Add(scatterTrackBar);
            Controls.Add(scatterValueLabel);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)galaxySizeTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)scatterTrackBar).EndInit();
        }

        #endregion

        private Panel panel1;
        private TrackBar galaxySizeTrackBar;
        private Label galaxySizeValueLabel;
        private TrackBar scatterTrackBar;
        private Label scatterValueLabel;
        private Button startButton;
    }
}
