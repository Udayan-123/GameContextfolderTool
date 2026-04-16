namespace GameContextfolderTool
{
    partial class Form1
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
            btnGenerate = new Button();
            txtPath = new TextBox();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(745, 21);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 42);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "ENTER";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(12, 21);
            txtPath.Multiline = true;
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(722, 42);
            txtPath.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 69);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Both;
            txtOutput.Size = new Size(808, 369);
            txtOutput.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 450);
            Controls.Add(txtOutput);
            Controls.Add(txtPath);
            Controls.Add(btnGenerate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private TextBox txtPath;
        private TextBox txtOutput;
    }
}
