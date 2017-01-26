namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.chaseTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.livesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.loseLabel = new System.Windows.Forms.Label();
            this.boxBox = new System.Windows.Forms.PictureBox();
            this.doorBox = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boxBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // chaseTimer
            // 
            this.chaseTimer.Interval = 10;
            this.chaseTimer.Tick += new System.EventHandler(this.chaseTimer_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 71);
            this.label1.TabIndex = 3;
            this.label1.Text = "You wake in a strange place, carrying only a couple things.  You are surrounded b" +
    "y rocky walls and the lighting is dim. It seems to be a cave. Tap the arrow keys" +
    " to move around.";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.inventoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inventoryLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.ForeColor = System.Drawing.Color.White;
            this.inventoryLabel.Location = new System.Drawing.Point(12, 652);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(751, 70);
            this.inventoryLabel.TabIndex = 5;
            this.inventoryLabel.Text = "Flashlight          Paper Clip";
            // 
            // livesLabel
            // 
            this.livesLabel.AutoSize = true;
            this.livesLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLabel.ForeColor = System.Drawing.Color.White;
            this.livesLabel.Location = new System.Drawing.Point(769, 709);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(71, 16);
            this.livesLabel.TabIndex = 6;
            this.livesLabel.Text = "LIVES : 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 621);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Inventory :";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.Black;
            this.exitLabel.Location = new System.Drawing.Point(640, 579);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(123, 65);
            this.exitLabel.TabIndex = 8;
            this.exitLabel.Text = "EXIT";
            this.exitLabel.Visible = false;
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            this.exitLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exitLabel_MouseMove);
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.Black;
            this.inputBox.ForeColor = System.Drawing.Color.White;
            this.inputBox.Location = new System.Drawing.Point(16, 95);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 20);
            this.inputBox.TabIndex = 9;
            this.inputBox.Visible = false;
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkButton.ForeColor = System.Drawing.Color.White;
            this.checkButton.Location = new System.Drawing.Point(123, 95);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(98, 23);
            this.checkButton.TabIndex = 10;
            this.checkButton.Text = "Check Answer";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Visible = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.ForeColor = System.Drawing.Color.White;
            this.numberLabel.Location = new System.Drawing.Point(13, 54);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(58, 20);
            this.numberLabel.TabIndex = 11;
            this.numberLabel.Text = "label3";
            this.numberLabel.Visible = false;
            // 
            // loseLabel
            // 
            this.loseLabel.AutoSize = true;
            this.loseLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseLabel.ForeColor = System.Drawing.Color.Red;
            this.loseLabel.Location = new System.Drawing.Point(402, 328);
            this.loseLabel.Name = "loseLabel";
            this.loseLabel.Size = new System.Drawing.Size(241, 59);
            this.loseLabel.TabIndex = 12;
            this.loseLabel.Text = "You Lost!";
            this.loseLabel.Visible = false;
            // 
            // boxBox
            // 
            this.boxBox.Image = global::WindowsFormsApplication1.Properties.Resources.Box_Piskel;
            this.boxBox.Location = new System.Drawing.Point(2, 396);
            this.boxBox.Name = "boxBox";
            this.boxBox.Size = new System.Drawing.Size(198, 160);
            this.boxBox.TabIndex = 14;
            this.boxBox.TabStop = false;
            this.boxBox.Visible = false;
            // 
            // doorBox
            // 
            this.doorBox.Image = global::WindowsFormsApplication1.Properties.Resources.DoorPiskel;
            this.doorBox.Location = new System.Drawing.Point(748, 162);
            this.doorBox.Name = "doorBox";
            this.doorBox.Size = new System.Drawing.Size(274, 285);
            this.doorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doorBox.TabIndex = 13;
            this.doorBox.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.person;
            this.pictureBox4.Location = new System.Drawing.Point(814, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(126, 126);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.person;
            this.pictureBox3.Location = new System.Drawing.Point(558, 446);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(126, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1034, 731);
            this.Controls.Add(this.boxBox);
            this.Controls.Add(this.doorBox);
            this.Controls.Add(this.loseLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.boxBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer chaseTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label loseLabel;
        private System.Windows.Forms.PictureBox doorBox;
        private System.Windows.Forms.PictureBox boxBox;
    }
}

