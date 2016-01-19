namespace Ecutbildning.BMIClientForm
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
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(25, 79);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeight.TabIndex = 0;
            this.textBoxHeight.Text = "height (meters)";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(207, 79);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxWeight.TabIndex = 1;
            this.textBoxWeight.Text = "weight";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(107, 161);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(127, 30);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(104, 225);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(73, 17);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Your BMI: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calculate BMI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label1;
    }
}

