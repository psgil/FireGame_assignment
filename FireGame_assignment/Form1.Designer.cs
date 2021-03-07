
namespace FireGame_assignment
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
            this.Buttons = new System.Windows.Forms.GroupBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.shootaway_btn = new System.Windows.Forms.Button();
            this.shoot_btn = new System.Windows.Forms.Button();
            this.spin_btn = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.photos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Buttons.SuspendLayout();
            this.photos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Buttons
            // 
            this.Buttons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Buttons.Controls.Add(this.exit_btn);
            this.Buttons.Controls.Add(this.shootaway_btn);
            this.Buttons.Controls.Add(this.shoot_btn);
            this.Buttons.Controls.Add(this.spin_btn);
            this.Buttons.Controls.Add(this.load_btn);
            this.Buttons.Controls.Add(this.start_btn);
            this.Buttons.Controls.Add(this.label1);
            this.Buttons.Location = new System.Drawing.Point(71, 12);
            this.Buttons.Name = "Buttons";
            this.Buttons.Size = new System.Drawing.Size(871, 142);
            this.Buttons.TabIndex = 0;
            this.Buttons.TabStop = false;
            this.Buttons.Text = "Buttons";
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Silver;
            this.exit_btn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(737, 78);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(109, 45);
            this.exit_btn.TabIndex = 6;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // shootaway_btn
            // 
            this.shootaway_btn.BackColor = System.Drawing.Color.Silver;
            this.shootaway_btn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootaway_btn.Location = new System.Drawing.Point(566, 78);
            this.shootaway_btn.Name = "shootaway_btn";
            this.shootaway_btn.Size = new System.Drawing.Size(165, 45);
            this.shootaway_btn.TabIndex = 5;
            this.shootaway_btn.Text = "Shoot Away";
            this.shootaway_btn.UseVisualStyleBackColor = false;
            this.shootaway_btn.Click += new System.EventHandler(this.shootaway_btn_Click);
            // 
            // shoot_btn
            // 
            this.shoot_btn.BackColor = System.Drawing.Color.Silver;
            this.shoot_btn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoot_btn.Location = new System.Drawing.Point(440, 78);
            this.shoot_btn.Name = "shoot_btn";
            this.shoot_btn.Size = new System.Drawing.Size(105, 45);
            this.shoot_btn.TabIndex = 4;
            this.shoot_btn.Text = "Shoot ";
            this.shoot_btn.UseVisualStyleBackColor = false;
            this.shoot_btn.Click += new System.EventHandler(this.shoot_btn_Click);
            // 
            // spin_btn
            // 
            this.spin_btn.BackColor = System.Drawing.Color.Silver;
            this.spin_btn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin_btn.Location = new System.Drawing.Point(315, 78);
            this.spin_btn.Name = "spin_btn";
            this.spin_btn.Size = new System.Drawing.Size(105, 45);
            this.spin_btn.TabIndex = 3;
            this.spin_btn.Text = "Spin";
            this.spin_btn.UseVisualStyleBackColor = false;
            this.spin_btn.Click += new System.EventHandler(this.spin_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.BackColor = System.Drawing.Color.Silver;
            this.load_btn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_btn.Location = new System.Drawing.Point(174, 78);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(105, 45);
            this.load_btn.TabIndex = 2;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = false;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.Silver;
            this.start_btn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(40, 78);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(105, 45);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(320, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "All the Best!";
            // 
            // photos
            // 
            this.photos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.photos.Controls.Add(this.pictureBox1);
            this.photos.Location = new System.Drawing.Point(27, 196);
            this.photos.Name = "photos";
            this.photos.Size = new System.Drawing.Size(936, 327);
            this.photos.TabIndex = 1;
            this.photos.TabStop = false;
            this.photos.Text = "Photos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FireGame_assignment.Properties.Resources.start_new1;
            this.pictureBox1.Location = new System.Drawing.Point(21, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 548);
            this.Controls.Add(this.photos);
            this.Controls.Add(this.Buttons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Buttons.ResumeLayout(false);
            this.Buttons.PerformLayout();
            this.photos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Buttons;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button shootaway_btn;
        private System.Windows.Forms.Button shoot_btn;
        private System.Windows.Forms.Button spin_btn;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox photos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

