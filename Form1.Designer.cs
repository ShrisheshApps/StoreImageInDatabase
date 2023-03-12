namespace StoreImageInDatabase
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ImagePathTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ImageSelectorButton = new System.Windows.Forms.Button();
            this.MyPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DisplayImageButton = new System.Windows.Forms.Button();
            this.ImagesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Image Path";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(86, 22);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(194, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // ImagePathTextBox
            // 
            this.ImagePathTextBox.Location = new System.Drawing.Point(86, 56);
            this.ImagePathTextBox.Name = "ImagePathTextBox";
            this.ImagePathTextBox.Size = new System.Drawing.Size(194, 20);
            this.ImagePathTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SaveButton.ForeColor = System.Drawing.Color.Coral;
            this.SaveButton.Location = new System.Drawing.Point(86, 82);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(93, 39);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save Image";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ImageSelectorButton
            // 
            this.ImageSelectorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ImageSelectorButton.Location = new System.Drawing.Point(189, 82);
            this.ImageSelectorButton.Name = "ImageSelectorButton";
            this.ImageSelectorButton.Size = new System.Drawing.Size(91, 39);
            this.ImageSelectorButton.TabIndex = 3;
            this.ImageSelectorButton.Text = "Select Image";
            this.ImageSelectorButton.UseVisualStyleBackColor = false;
            this.ImageSelectorButton.Click += new System.EventHandler(this.ImageSelectorButton_Click);
            // 
            // MyPictureBox
            // 
            this.MyPictureBox.Location = new System.Drawing.Point(286, 19);
            this.MyPictureBox.Name = "MyPictureBox";
            this.MyPictureBox.Size = new System.Drawing.Size(100, 102);
            this.MyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPictureBox.TabIndex = 4;
            this.MyPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MyPictureBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ImageSelectorButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.ImagePathTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 143);
            this.panel1.TabIndex = 5;
            // 
            // DisplayImageButton
            // 
            this.DisplayImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayImageButton.ForeColor = System.Drawing.Color.Purple;
            this.DisplayImageButton.Location = new System.Drawing.Point(158, 164);
            this.DisplayImageButton.Name = "DisplayImageButton";
            this.DisplayImageButton.Size = new System.Drawing.Size(260, 23);
            this.DisplayImageButton.TabIndex = 6;
            this.DisplayImageButton.Text = "Display image from database";
            this.DisplayImageButton.UseVisualStyleBackColor = true;
            // 
            // ImagesComboBox
            // 
            this.ImagesComboBox.BackColor = System.Drawing.Color.Yellow;
            this.ImagesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagesComboBox.FormattingEnabled = true;
            this.ImagesComboBox.Location = new System.Drawing.Point(12, 164);
            this.ImagesComboBox.Name = "ImagesComboBox";
            this.ImagesComboBox.Size = new System.Drawing.Size(140, 23);
            this.ImagesComboBox.TabIndex = 7;
            this.ImagesComboBox.SelectedIndexChanged += new System.EventHandler(this.ImagesComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(433, 199);
            this.Controls.Add(this.ImagesComboBox);
            this.Controls.Add(this.DisplayImageButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Save Image in Database";
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox ImagePathTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ImageSelectorButton;
        private System.Windows.Forms.PictureBox MyPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DisplayImageButton;
        private System.Windows.Forms.ComboBox ImagesComboBox;
    }
}

