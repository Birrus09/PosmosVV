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
            densityValueLabel = new Label();
            spreadTrackerBar = new TrackBar();
            spreadValueLabel = new Label();
            densityTrackBar = new TrackBar();
            checkBox1 = new CheckBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            errorLabel = new Label();
            seedLabel = new Label();
            seedNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)galaxySizeTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scatterTrackBar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spreadTrackerBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)densityTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seedNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // galaxySizeTrackBar
            // 
            galaxySizeTrackBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            galaxySizeTrackBar.Location = new Point(9, 439);
            galaxySizeTrackBar.Margin = new Padding(3, 4, 3, 4);
            galaxySizeTrackBar.Maximum = 500000;
            galaxySizeTrackBar.Minimum = 5000;
            galaxySizeTrackBar.Name = "galaxySizeTrackBar";
            galaxySizeTrackBar.Size = new Size(442, 56);
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
            galaxySizeValueLabel.Location = new Point(14, 413);
            galaxySizeValueLabel.Name = "galaxySizeValueLabel";
            galaxySizeValueLabel.Size = new Size(121, 20);
            galaxySizeValueLabel.TabIndex = 1;
            galaxySizeValueLabel.Text = "Galaxy size: 8500";
            // 
            // scatterTrackBar
            // 
            scatterTrackBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            scatterTrackBar.Location = new Point(9, 527);
            scatterTrackBar.Margin = new Padding(3, 4, 3, 4);
            scatterTrackBar.Maximum = 100000;
            scatterTrackBar.Name = "scatterTrackBar";
            scatterTrackBar.Size = new Size(442, 56);
            scatterTrackBar.TabIndex = 0;
            scatterTrackBar.TickFrequency = 10000;
            scatterTrackBar.Value = 15000;
            scatterTrackBar.ValueChanged += scatterTrackBar_ValueChanged;
            // 
            // scatterValueLabel
            // 
            scatterValueLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            scatterValueLabel.AutoSize = true;
            scatterValueLabel.ForeColor = Color.White;
            scatterValueLabel.Location = new Point(14, 501);
            scatterValueLabel.Name = "scatterValueLabel";
            scatterValueLabel.Size = new Size(113, 20);
            scatterValueLabel.TabIndex = 1;
            scatterValueLabel.Text = "Scatter: 0.15000";
            // 
            // startButton
            // 
            startButton.Location = new Point(411, 276);
            startButton.Margin = new Padding(3, 4, 3, 4);
            startButton.Name = "startButton";
            startButton.Size = new Size(91, 48);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(seedNumericUpDown);
            panel1.Controls.Add(seedLabel);
            panel1.Location = new Point(-2, 263);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 337);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            panel1.MouseClick += Form1_MouseClick;
            // 
            // densityValueLabel
            // 
            densityValueLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            densityValueLabel.AutoSize = true;
            densityValueLabel.ForeColor = Color.White;
            densityValueLabel.Location = new Point(478, 413);
            densityValueLabel.Name = "densityValueLabel";
            densityValueLabel.Size = new Size(116, 20);
            densityValueLabel.TabIndex = 3;
            densityValueLabel.Text = "Density: 0,27000";
            // 
            // spreadTrackerBar
            // 
            spreadTrackerBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            spreadTrackerBar.Location = new Point(463, 527);
            spreadTrackerBar.Margin = new Padding(3, 4, 3, 4);
            spreadTrackerBar.Maximum = 100000;
            spreadTrackerBar.Name = "spreadTrackerBar";
            spreadTrackerBar.Size = new Size(442, 56);
            spreadTrackerBar.TabIndex = 4;
            spreadTrackerBar.TickFrequency = 10000;
            spreadTrackerBar.Value = 24000;
            spreadTrackerBar.ValueChanged += spreadTrackerBar_ValueChanged;
            // 
            // spreadValueLabel
            // 
            spreadValueLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            spreadValueLabel.AutoSize = true;
            spreadValueLabel.ForeColor = Color.White;
            spreadValueLabel.Location = new Point(478, 501);
            spreadValueLabel.Name = "spreadValueLabel";
            spreadValueLabel.Size = new Size(114, 20);
            spreadValueLabel.TabIndex = 4;
            spreadValueLabel.Text = "Spread: 0.24000";
            // 
            // densityTrackBar
            // 
            densityTrackBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            densityTrackBar.Location = new Point(463, 439);
            densityTrackBar.Margin = new Padding(3, 4, 3, 4);
            densityTrackBar.Maximum = 100000;
            densityTrackBar.Name = "densityTrackBar";
            densityTrackBar.Size = new Size(442, 56);
            densityTrackBar.TabIndex = 3;
            densityTrackBar.TickFrequency = 10000;
            densityTrackBar.Value = 27000;
            densityTrackBar.ValueChanged += densityTrackBar_ValueChanged;
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.Location = new Point(30, 367);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 33);
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
            label1.Location = new Point(14, 333);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 2;
            label1.Text = "Generation algorithm";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(688, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // errorLabel
            // 
            errorLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.White;
            errorLabel.Location = new Point(600, 493);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(106, 20);
            errorLabel.TabIndex = 5;
            errorLabel.Text = "Not supported";
            errorLabel.Visible = false;
            // 
            // seedLabel
            // 
            seedLabel.AutoSize = true;
            seedLabel.ForeColor = Color.White;
            seedLabel.Location = new Point(695, 0);
            seedLabel.Name = "seedLabel";
            seedLabel.Size = new Size(42, 20);
            seedLabel.TabIndex = 7;
            seedLabel.Text = "Seed";
            // 
            // seedNumericUpDown
            // 
            seedNumericUpDown.Location = new Point(695, 34);
            seedNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            seedNumericUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            seedNumericUpDown.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            seedNumericUpDown.Name = "seedNumericUpDown";
            seedNumericUpDown.Size = new Size(143, 27);
            seedNumericUpDown.TabIndex = 8;
            seedNumericUpDown.Value = new decimal(new int[] { 6589, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(914, 600);
            Controls.Add(errorLabel);
            Controls.Add(pictureBox1);
            Controls.Add(startButton);
            Controls.Add(galaxySizeTrackBar);
            Controls.Add(galaxySizeValueLabel);
            Controls.Add(scatterTrackBar);
            Controls.Add(scatterValueLabel);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(densityValueLabel);
            Controls.Add(spreadTrackerBar);
            Controls.Add(spreadValueLabel);
            Controls.Add(densityTrackBar);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(930, 636);
            Name = "Form1";
            Text = "POSMOS";
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)galaxySizeTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)scatterTrackBar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spreadTrackerBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)densityTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)seedNumericUpDown).EndInit();
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
        private Label densityValueLabel;
        private TrackBar spreadTrackerBar;
        private Label spreadValueLabel;
        private TrackBar densityTrackBar;
        private Label errorLabel;
        private Label seedLabel;
        private NumericUpDown seedNumericUpDown;
    }
}
