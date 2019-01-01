namespace FlowChart
{
    partial class FlowBlock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textArea = new FlowChart.AutoSizeTextBox();
            this.SuspendLayout();
            // 
            // textArea
            // 
            this.textArea.AcceptsReturn = true;
            this.textArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textArea.isAutoSize = true;
            this.textArea.Location = new System.Drawing.Point(180, 96);
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(100, 20);
            this.textArea.TabIndex = 0;
            this.textArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FlowBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.textArea);
            this.Name = "FlowBlock";
            this.Size = new System.Drawing.Size(433, 272);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoSizeTextBox textArea;
    }
}
