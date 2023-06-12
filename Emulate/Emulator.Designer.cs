namespace Emulate
{
    partial class Emulator
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
            label1 = new Label();
            txtAdbPath = new TextBox();
            label2 = new Label();
            txtX = new TextBox();
            txtY = new TextBox();
            btnEmulateTouch = new Button();
            btnInitAdb = new Button();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Adb Exe Path";
            // 
            // txtAdbPath
            // 
            txtAdbPath.Location = new Point(143, 23);
            txtAdbPath.Margin = new Padding(4, 3, 4, 3);
            txtAdbPath.Name = "txtAdbPath";
            txtAdbPath.Size = new Size(309, 23);
            txtAdbPath.TabIndex = 1;
            txtAdbPath.Text = "C:\\Users\\Admin\\AppData\\Local\\Android\\Sdk\\platform-tools\\adb.exe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 0;
            label2.Text = "Clicking Position(X, Y):";
            // 
            // txtX
            // 
            txtX.Location = new Point(79, 111);
            txtX.Margin = new Padding(4, 3, 4, 3);
            txtX.Name = "txtX";
            txtX.Size = new Size(182, 23);
            txtX.TabIndex = 1;
            // 
            // txtY
            // 
            txtY.Location = new Point(426, 111);
            txtY.Margin = new Padding(4, 3, 4, 3);
            txtY.Name = "txtY";
            txtY.Size = new Size(182, 23);
            txtY.TabIndex = 1;
            // 
            // btnEmulateTouch
            // 
            btnEmulateTouch.Location = new Point(21, 169);
            btnEmulateTouch.Margin = new Padding(4, 3, 4, 3);
            btnEmulateTouch.Name = "btnEmulateTouch";
            btnEmulateTouch.Size = new Size(587, 27);
            btnEmulateTouch.TabIndex = 2;
            btnEmulateTouch.Text = "Emulate Touch";
            btnEmulateTouch.UseVisualStyleBackColor = true;
            btnEmulateTouch.Click += btnEmulateTouch_Click;
            // 
            // btnInitAdb
            // 
            btnInitAdb.Location = new Point(460, 22);
            btnInitAdb.Margin = new Padding(4, 3, 4, 3);
            btnInitAdb.Name = "btnInitAdb";
            btnInitAdb.Size = new Size(152, 27);
            btnInitAdb.TabIndex = 3;
            btnInitAdb.Text = "Init Adb";
            btnInitAdb.UseVisualStyleBackColor = true;
            btnInitAdb.Click += btnInitAdb_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 114);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "X-Axis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 114);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 5;
            label4.Text = "Y-Axis";
            // 
            // Emulator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 219);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnInitAdb);
            Controls.Add(btnEmulateTouch);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(label2);
            Controls.Add(txtAdbPath);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Emulator";
            Text = "Emulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdbPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnEmulateTouch;
        private System.Windows.Forms.Button btnInitAdb;
        private System.Windows.Forms.Button button1;
        private Label label3;
        private Label label4;
    }
}