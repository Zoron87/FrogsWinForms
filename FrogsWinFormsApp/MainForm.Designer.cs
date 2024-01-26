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
            RestartGame = new Button();
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
            // RestartGame
            // 
            RestartGame.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RestartGame.Location = new Point(772, 115);
            RestartGame.Name = "RestartGame";
            RestartGame.Size = new Size(118, 28);
            RestartGame.TabIndex = 10;
            RestartGame.Text = "Перезапустить";
            RestartGame.UseVisualStyleBackColor = true;
            RestartGame.Click += RestartGame_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 155);
            Controls.Add(RestartGame);
            Controls.Add(stepsLabel);
            Name = "MainForm";
            Text = "Frogs";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label stepsLabel;
        private Button RestartGame;
    }
}