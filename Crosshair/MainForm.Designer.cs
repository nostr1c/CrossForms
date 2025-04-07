namespace Crosshair
{
    partial class MainForm
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
            cbStyle = new ComboBox();
            tbSize = new TrackBar();
            tbThickness = new TrackBar();
            lblStyle = new Label();
            lblSize = new Label();
            lblThickness = new Label();
            cdColor = new ColorDialog();
            btnColor = new Button();
            pbColor = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tbSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbThickness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbColor).BeginInit();
            SuspendLayout();
            // 
            // cbStyle
            // 
            cbStyle.FormattingEnabled = true;
            cbStyle.Location = new Point(33, 28);
            cbStyle.Name = "cbStyle";
            cbStyle.Size = new Size(121, 23);
            cbStyle.TabIndex = 0;
            cbStyle.SelectedIndexChanged += cbStyle_SelectedIndexChanged;
            // 
            // tbSize
            // 
            tbSize.Location = new Point(33, 107);
            tbSize.Maximum = 100;
            tbSize.Minimum = 1;
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(536, 45);
            tbSize.TabIndex = 1;
            tbSize.Value = 15;
            tbSize.Scroll += tbSize_Scroll;
            // 
            // tbThickness
            // 
            tbThickness.Location = new Point(33, 194);
            tbThickness.Minimum = 1;
            tbThickness.Name = "tbThickness";
            tbThickness.Size = new Size(200, 45);
            tbThickness.TabIndex = 2;
            tbThickness.Value = 2;
            tbThickness.Scroll += tbThickness_Scroll;
            // 
            // lblStyle
            // 
            lblStyle.AutoSize = true;
            lblStyle.Location = new Point(33, 8);
            lblStyle.Name = "lblStyle";
            lblStyle.Size = new Size(32, 15);
            lblStyle.TabIndex = 3;
            lblStyle.Text = "Style";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(38, 85);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(27, 15);
            lblSize.TabIndex = 4;
            lblSize.Text = "Size";
            // 
            // lblThickness
            // 
            lblThickness.AutoSize = true;
            lblThickness.Location = new Point(38, 167);
            lblThickness.Name = "lblThickness";
            lblThickness.Size = new Size(58, 15);
            lblThickness.TabIndex = 5;
            lblThickness.Text = "Thickness";
            // 
            // btnColor
            // 
            btnColor.Location = new Point(89, 256);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(103, 40);
            btnColor.TabIndex = 6;
            btnColor.Text = "Choose Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // pbColor
            // 
            pbColor.Location = new Point(41, 256);
            pbColor.Name = "pbColor";
            pbColor.Size = new Size(42, 40);
            pbColor.TabIndex = 7;
            pbColor.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbColor);
            Controls.Add(btnColor);
            Controls.Add(lblThickness);
            Controls.Add(lblSize);
            Controls.Add(lblStyle);
            Controls.Add(tbThickness);
            Controls.Add(tbSize);
            Controls.Add(cbStyle);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)tbSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbThickness).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbStyle;
        private TrackBar tbSize;
        private TrackBar tbThickness;
        private Label lblStyle;
        private Label lblSize;
        private Label lblThickness;
        private ColorDialog cdColor;
        private Button btnColor;
        private PictureBox pbColor;
    }
}
