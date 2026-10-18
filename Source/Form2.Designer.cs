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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tempT = new Label();
            sizeT = new Label();
            trademark = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 400);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            // 
            // starSpect
            // 
            starSpect.AutoSize = true;
            starSpect.BackColor = Color.Black;
            starSpect.Font = new Font("Candara", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            starSpect.ForeColor = Color.MediumPurple;
            starSpect.Location = new Point(436, 60);
            starSpect.Name = "starSpect";
            starSpect.Size = new Size(206, 45);
            starSpect.TabIndex = 1;
            starSpect.Text = "StarSpector";
            starSpect.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(200, 380);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 200);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(200, 380);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 200);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // tempT
            // 
            tempT.AutoSize = true;
            tempT.BackColor = Color.Black;
            tempT.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tempT.ForeColor = Color.Lavender;
            tempT.Location = new Point(436, 116);
            tempT.Name = "tempT";
            tempT.Size = new Size(120, 17);
            tempT.TabIndex = 4;
            tempT.Text = "Temp goes here";
            tempT.Visible = false;
            // 
            // sizeT
            // 
            sizeT.AutoSize = true;
            sizeT.BackColor = Color.Black;
            sizeT.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sizeT.ForeColor = Color.Lavender;
            sizeT.Location = new Point(436, 142);
            sizeT.Name = "sizeT";
            sizeT.Size = new Size(120, 17);
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
            trademark.Location = new Point(634, 83);
            trademark.Name = "trademark";
            trademark.Size = new Size(25, 15);
            trademark.TabIndex = 6;
            trademark.Text = "TM";
            trademark.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(784, 581);
            Controls.Add(trademark);
            Controls.Add(sizeT);
            Controls.Add(tempT);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(starSpect);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(800, 620);
            MinimizeBox = false;
            MinimumSize = new Size(800, 620);
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label tempT;
        private Label sizeT;
        private Label trademark;
    }
}
