namespace PosmosVV
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            starSpect = new Label();
            tempT = new Label();
            sizeT = new Label();
            trademark = new Label();
            bodiesT = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            CordsT = new Label();
            UnscT = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(286, 67);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 933);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            panel1.MouseClick += Form2_Click;
            // 
            // starSpect
            // 
            starSpect.AutoSize = true;
            starSpect.BackColor = Color.Black;
            starSpect.Font = new Font("Candara", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            starSpect.ForeColor = Color.MediumPurple;
            starSpect.Location = new Point(17, 16);
            starSpect.Name = "starSpect";
            starSpect.Size = new Size(261, 58);
            starSpect.TabIndex = 1;
            starSpect.Text = "StarSpector";
            starSpect.Visible = false;
            // 
            // tempT
            // 
            tempT.AutoSize = true;
            tempT.BackColor = Color.Black;
            tempT.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tempT.ForeColor = Color.Lavender;
            tempT.Location = new Point(39, 164);
            tempT.Name = "tempT";
            tempT.Size = new Size(150, 22);
            tempT.TabIndex = 4;
            tempT.Text = "Temp goes here";
            tempT.Visible = false;
            tempT.Click += tempT_Click;
            // 
            // sizeT
            // 
            sizeT.AutoSize = true;
            sizeT.BackColor = Color.Black;
            sizeT.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sizeT.ForeColor = Color.Lavender;
            sizeT.Location = new Point(39, 193);
            sizeT.Name = "sizeT";
            sizeT.Size = new Size(150, 22);
            sizeT.TabIndex = 5;
            sizeT.Text = "Size goes here";
            sizeT.Visible = false;
            // 
            // trademark
            // 
            trademark.AutoSize = true;
            trademark.BackColor = Color.Black;
            trademark.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trademark.ForeColor = Color.MediumPurple;
            trademark.Location = new Point(250, 47);
            trademark.Name = "trademark";
            trademark.Size = new Size(34, 21);
            trademark.TabIndex = 6;
            trademark.Text = "TM";
            trademark.Visible = false;
            trademark.Click += trademark_Click;
            // 
            // bodiesT
            // 
            bodiesT.AutoSize = true;
            bodiesT.BackColor = Color.Black;
            bodiesT.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bodiesT.ForeColor = Color.Lavender;
            bodiesT.Location = new Point(39, 222);
            bodiesT.Name = "bodiesT";
            bodiesT.Size = new Size(150, 22);
            bodiesT.TabIndex = 7;
            bodiesT.Text = "Bodies go here";
            bodiesT.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(343, 732);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(457, 267);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(343, 732);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(457, 267);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // CordsT
            // 
            CordsT.AutoSize = true;
            CordsT.BackColor = Color.Black;
            CordsT.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CordsT.ForeColor = Color.Lavender;
            CordsT.Location = new Point(39, 85);
            CordsT.Name = "CordsT";
            CordsT.Size = new Size(150, 22);
            CordsT.TabIndex = 8;
            CordsT.Text = "Coords go here";
            CordsT.Visible = false;
            // 
            // UnscT
            // 
            UnscT.AutoSize = true;
            UnscT.BackColor = Color.Black;
            UnscT.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnscT.ForeColor = Color.Lavender;
            UnscT.Location = new Point(39, 114);
            UnscT.Name = "UnscT";
            UnscT.Size = new Size(170, 22);
            UnscT.TabIndex = 9;
            UnscT.Text = "Unscaled go here";
            UnscT.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1122, 1004);
            Controls.Add(UnscT);
            Controls.Add(CordsT);
            Controls.Add(bodiesT);
            Controls.Add(trademark);
            Controls.Add(sizeT);
            Controls.Add(tempT);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(starSpect);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1140, 1051);
            MinimizeBox = false;
            MinimumSize = new Size(1140, 1018);
            Name = "Form2";
            Text = "StarSpector";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label starSpect;
        private Label tempT;
        private Label sizeT;
        private Label trademark;
        private Label bodiesT;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label CordsT;
        private Label UnscT;
    }
}
