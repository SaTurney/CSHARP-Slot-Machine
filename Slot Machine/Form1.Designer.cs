namespace Slot_Machine
{
    partial class slotMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(slotMachine));
            this.firstPictureBox = new System.Windows.Forms.PictureBox();
            this.secondPictureBox = new System.Windows.Forms.PictureBox();
            this.thirdPictureBox = new System.Windows.Forms.PictureBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.spinButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fruitList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.firstPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // firstPictureBox
            // 
            this.firstPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstPictureBox.Location = new System.Drawing.Point(12, 24);
            this.firstPictureBox.Name = "firstPictureBox";
            this.firstPictureBox.Size = new System.Drawing.Size(168, 161);
            this.firstPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.firstPictureBox.TabIndex = 0;
            this.firstPictureBox.TabStop = false;
            // 
            // secondPictureBox
            // 
            this.secondPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondPictureBox.Location = new System.Drawing.Point(208, 24);
            this.secondPictureBox.Name = "secondPictureBox";
            this.secondPictureBox.Size = new System.Drawing.Size(168, 161);
            this.secondPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.secondPictureBox.TabIndex = 1;
            this.secondPictureBox.TabStop = false;
            // 
            // thirdPictureBox
            // 
            this.thirdPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thirdPictureBox.Location = new System.Drawing.Point(393, 24);
            this.thirdPictureBox.Name = "thirdPictureBox";
            this.thirdPictureBox.Size = new System.Drawing.Size(168, 161);
            this.thirdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.thirdPictureBox.TabIndex = 2;
            this.thirdPictureBox.TabStop = false;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(73, 231);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(255, 17);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "Enter amount to gamble on the slots!  $";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(346, 228);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 22);
            this.amountTextBox.TabIndex = 4;
            // 
            // spinButton
            // 
            this.spinButton.Location = new System.Drawing.Point(138, 265);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(120, 53);
            this.spinButton.TabIndex = 5;
            this.spinButton.Text = "Spin the Slots!";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.SpinButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(291, 265);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 53);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // fruitList
            // 
            this.fruitList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fruitList.ImageStream")));
            this.fruitList.TransparentColor = System.Drawing.Color.Transparent;
            this.fruitList.Images.SetKeyName(0, "Apple.bmp");
            this.fruitList.Images.SetKeyName(1, "Banana.bmp");
            this.fruitList.Images.SetKeyName(2, "Cherries.bmp");
            this.fruitList.Images.SetKeyName(3, "Grapes.bmp");
            this.fruitList.Images.SetKeyName(4, "Lemon.bmp");
            this.fruitList.Images.SetKeyName(5, "Lime.bmp");
            this.fruitList.Images.SetKeyName(6, "Orange.bmp");
            this.fruitList.Images.SetKeyName(7, "Pear.bmp");
            this.fruitList.Images.SetKeyName(8, "Strawberry.bmp");
            this.fruitList.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // slotMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 330);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.thirdPictureBox);
            this.Controls.Add(this.secondPictureBox);
            this.Controls.Add(this.firstPictureBox);
            this.Name = "slotMachine";
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.firstPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox firstPictureBox;
        private System.Windows.Forms.PictureBox secondPictureBox;
        private System.Windows.Forms.PictureBox thirdPictureBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ImageList fruitList;
    }
}

