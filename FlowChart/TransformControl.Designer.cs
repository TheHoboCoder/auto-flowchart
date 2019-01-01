namespace FlowChart
{
    partial class TransformControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.upperLeftControl = new FlowChart.MoveControl();
            this.bottomLeftControl = new FlowChart.MoveControl();
            this.bottomRightControl = new FlowChart.MoveControl();
            this.upperRightControl = new FlowChart.MoveControl();
            this.rightControl = new FlowChart.MoveControl();
            this.leftControl = new FlowChart.MoveControl();
            this.bottomControl = new FlowChart.MoveControl();
            this.topControl = new FlowChart.MoveControl();
            this.SuspendLayout();
            // 
            // upperLeftControl
            // 
            this.upperLeftControl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.upperLeftControl.CurrentMoveDirection = FlowChart.MoveControl.MoveDirection.BOTH;
            this.upperLeftControl.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.upperLeftControl.Location = new System.Drawing.Point(0, 0);
            this.upperLeftControl.Name = "upperLeftControl";
            this.upperLeftControl.Size = new System.Drawing.Size(33, 26);
            this.upperLeftControl.TabIndex = 7;
            // 
            // bottomLeftControl
            // 
            this.bottomLeftControl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bottomLeftControl.CurrentMoveDirection = FlowChart.MoveControl.MoveDirection.BOTH;
            this.bottomLeftControl.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.bottomLeftControl.Location = new System.Drawing.Point(0, 248);
            this.bottomLeftControl.Name = "bottomLeftControl";
            this.bottomLeftControl.Size = new System.Drawing.Size(33, 26);
            this.bottomLeftControl.TabIndex = 6;
            // 
            // bottomRightControl
            // 
            this.bottomRightControl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bottomRightControl.CurrentMoveDirection = FlowChart.MoveControl.MoveDirection.BOTH;
            this.bottomRightControl.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bottomRightControl.Location = new System.Drawing.Point(435, 248);
            this.bottomRightControl.Name = "bottomRightControl";
            this.bottomRightControl.Size = new System.Drawing.Size(33, 26);
            this.bottomRightControl.TabIndex = 5;
            this.bottomRightControl.Resize += new System.EventHandler(this.bottomRightControl_Resize);
            // 
            // upperRightControl
            // 
            this.upperRightControl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.upperRightControl.CurrentMoveDirection = FlowChart.MoveControl.MoveDirection.BOTH;
            this.upperRightControl.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.upperRightControl.Location = new System.Drawing.Point(435, 0);
            this.upperRightControl.Name = "upperRightControl";
            this.upperRightControl.Size = new System.Drawing.Size(33, 26);
            this.upperRightControl.TabIndex = 4;
            this.upperRightControl.LocationChanged += new System.EventHandler(this.upperRightControl_LocationChanged);
            // 
            // rightControl
            // 
            this.rightControl.BackColor = System.Drawing.Color.Navy;
            this.rightControl.CurrentMoveDirection = FlowChart.MoveControl.MoveDirection.HORIZONTAL;
            this.rightControl.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.rightControl.Location = new System.Drawing.Point(433, 35);
            this.rightControl.Name = "rightControl";
            this.rightControl.Size = new System.Drawing.Size(33, 210);
            this.rightControl.TabIndex = 3;
            // 
            // leftControl
            // 
            this.leftControl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.leftControl.CurrentMoveDirection = FlowChart.MoveControl.MoveDirection.HORIZONTAL;
            this.leftControl.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.leftControl.Location = new System.Drawing.Point(0, 35);
            this.leftControl.Name = "leftControl";
            this.leftControl.Size = new System.Drawing.Size(33, 210);
            this.leftControl.TabIndex = 2;
            // 
            // bottomControl
            // 
            this.bottomControl.BackColor = System.Drawing.Color.Lime;
            this.bottomControl.CurrentMoveDirection = FlowChart.MoveControl.MoveDirection.VERTICAL;
            this.bottomControl.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.bottomControl.Location = new System.Drawing.Point(56, 245);
            this.bottomControl.Name = "bottomControl";
            this.bottomControl.Size = new System.Drawing.Size(359, 29);
            this.bottomControl.TabIndex = 1;
            // 
            // topControl
            // 
            this.topControl.BackColor = System.Drawing.Color.Yellow;
            this.topControl.CurrentMoveDirection = FlowChart.MoveControl.MoveDirection.VERTICAL;
            this.topControl.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.topControl.ForeColor = System.Drawing.Color.Yellow;
            this.topControl.Location = new System.Drawing.Point(56, 0);
            this.topControl.Name = "topControl";
            this.topControl.Size = new System.Drawing.Size(359, 29);
            this.topControl.TabIndex = 0;
            // 
            // TransformControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.upperLeftControl);
            this.Controls.Add(this.bottomLeftControl);
            this.Controls.Add(this.bottomRightControl);
            this.Controls.Add(this.upperRightControl);
            this.Controls.Add(this.rightControl);
            this.Controls.Add(this.leftControl);
            this.Controls.Add(this.bottomControl);
            this.Controls.Add(this.topControl);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "TransformControl";
            this.Size = new System.Drawing.Size(468, 274);
            this.ResumeLayout(false);

        }

        #endregion

        private MoveControl topControl;
        private MoveControl bottomControl;
        private MoveControl leftControl;
        private MoveControl rightControl;
        private MoveControl upperRightControl;
        private MoveControl bottomRightControl;
        private MoveControl bottomLeftControl;
        private MoveControl upperLeftControl;
    }
}
