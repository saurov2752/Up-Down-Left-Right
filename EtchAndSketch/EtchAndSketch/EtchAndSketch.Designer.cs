namespace EtchAndSketch
{
    partial class EtchAndSketch
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
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.upButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingPanel.Location = new System.Drawing.Point(13, 10);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(262, 164);
            this.drawingPanel.TabIndex = 0;
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(42, 180);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(33, 23);
            this.upButton.TabIndex = 1;
            this.upButton.Text = "^";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(72, 209);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(33, 23);
            this.rightButton.TabIndex = 1;
            this.rightButton.Text = ">";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(42, 238);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(33, 23);
            this.downButton.TabIndex = 1;
            this.downButton.Text = "v";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(13, 209);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(33, 23);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "<";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(138, 209);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // EtchAndSketch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.drawingPanel);
            this.Name = "EtchAndSketch";
            this.Text = "Etch And Sketch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button clearButton;
    }
}

