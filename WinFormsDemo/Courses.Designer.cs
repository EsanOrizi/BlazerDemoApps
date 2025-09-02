namespace WinFormsDemo
{
    partial class Courses
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
            CourseImage = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)CourseImage).BeginInit();
            SuspendLayout();
            // 
            // CourseImage
            // 
            CourseImage.Location = new Point(160, 53);
            CourseImage.Name = "CourseImage";
            CourseImage.Size = new Size(539, 429);
            CourseImage.SizeMode = PictureBoxSizeMode.Zoom;
            CourseImage.TabIndex = 0;
            CourseImage.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(160, 507);
            button1.Name = "button1";
            button1.Size = new Size(260, 80);
            button1.TabIndex = 1;
            button1.Text = "Previous";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(439, 507);
            button2.Name = "button2";
            button2.Size = new Size(260, 80);
            button2.TabIndex = 2;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            // 
            // Courses
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 864);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CourseImage);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Courses";
            Text = "Courses";
            Load += this.Courses_Load;
            ((System.ComponentModel.ISupportInitialize)CourseImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox CourseImage;
        private Button button1;
        private Button button2;
    }
}
