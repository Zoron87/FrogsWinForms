namespace FrogsWinFormsApp
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
            stepsLabel = new Label();
            SuspendLayout();
            // 
            // stepsLabel
            // 
            stepsLabel.AutoSize = true;
            stepsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            stepsLabel.Location = new Point(12, 113);
            stepsLabel.Name = "stepsLabel";
            stepsLabel.Size = new Size(161, 25);
            stepsLabel.TabIndex = 9;
            stepsLabel.Text = "Кол-во шагов: 0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 155);
            Controls.Add(stepsLabel);
            Name = "MainForm";
            Text = "Frogs";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label stepsLabel;
    }
}