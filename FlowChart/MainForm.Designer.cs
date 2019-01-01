namespace FlowChart
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainScreenlayout = new System.Windows.Forms.TableLayoutPanel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTS = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTS = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTS = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsTS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoTS = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoTs = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolBox = new System.Windows.Forms.ToolStrip();
            this.createButton = new System.Windows.Forms.ToolStripButton();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.saveAsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.UndoButton = new System.Windows.Forms.ToolStripButton();
            this.redoButton = new System.Windows.Forms.ToolStripButton();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainScreenlayout.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.mainToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainScreenlayout
            // 
            this.mainScreenlayout.ColumnCount = 1;
            this.mainScreenlayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainScreenlayout.Controls.Add(this.mainMenu, 0, 0);
            this.mainScreenlayout.Controls.Add(this.mainToolBox, 0, 1);
            this.mainScreenlayout.Controls.Add(this.mainSplitContainer, 0, 2);
            this.mainScreenlayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainScreenlayout.Location = new System.Drawing.Point(0, 0);
            this.mainScreenlayout.Name = "mainScreenlayout";
            this.mainScreenlayout.RowCount = 3;
            this.mainScreenlayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.mainScreenlayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.mainScreenlayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainScreenlayout.Size = new System.Drawing.Size(840, 375);
            this.mainScreenlayout.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(840, 27);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTS,
            this.toolStripSeparator1,
            this.OpenTS,
            this.toolStripSeparator2,
            this.SaveTS,
            this.SaveAsTS});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(48, 23);
            this.FileMenuItem.Text = "Файл";
            // 
            // CreateTS
            // 
            this.CreateTS.Name = "CreateTS";
            this.CreateTS.Size = new System.Drawing.Size(162, 22);
            this.CreateTS.Text = "Создать..";
            // 
            // OpenTS
            // 
            this.OpenTS.Name = "OpenTS";
            this.OpenTS.Size = new System.Drawing.Size(162, 22);
            this.OpenTS.Text = "Открыть...";
            // 
            // SaveTS
            // 
            this.SaveTS.Name = "SaveTS";
            this.SaveTS.Size = new System.Drawing.Size(162, 22);
            this.SaveTS.Text = "Сохранить";
            // 
            // SaveAsTS
            // 
            this.SaveAsTS.Name = "SaveAsTS";
            this.SaveAsTS.Size = new System.Drawing.Size(162, 22);
            this.SaveAsTS.Text = "Сохранить как...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoTS,
            this.RedoTs});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(59, 23);
            this.EditMenuItem.Text = "Правка";
            // 
            // UndoTS
            // 
            this.UndoTS.Name = "UndoTS";
            this.UndoTS.Size = new System.Drawing.Size(152, 22);
            this.UndoTS.Text = "Отменить";
            // 
            // RedoTs
            // 
            this.RedoTs.Name = "RedoTs";
            this.RedoTs.Size = new System.Drawing.Size(152, 22);
            this.RedoTs.Text = "Повторить";
            // 
            // mainToolBox
            // 
            this.mainToolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainToolBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createButton,
            this.openButton,
            this.toolStripSeparator3,
            this.saveButton,
            this.saveAsButton,
            this.toolStripSeparator4,
            this.ExportButton,
            this.toolStripSeparator5,
            this.UndoButton,
            this.redoButton});
            this.mainToolBox.Location = new System.Drawing.Point(0, 27);
            this.mainToolBox.Name = "mainToolBox";
            this.mainToolBox.Size = new System.Drawing.Size(840, 26);
            this.mainToolBox.TabIndex = 1;
            this.mainToolBox.Text = "toolStrip1";
            // 
            // createButton
            // 
            this.createButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createButton.Image = ((System.Drawing.Image)(resources.GetObject("createButton.Image")));
            this.createButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(23, 23);
            this.createButton.Text = "Создать";
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(23, 23);
            this.openButton.Text = "Открыть";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(23, 23);
            this.saveButton.Text = "SaveButton";
            // 
            // saveAsButton
            // 
            this.saveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsButton.Image")));
            this.saveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(23, 23);
            this.saveAsButton.Text = "toolStripButton1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 26);
            // 
            // ExportButton
            // 
            this.ExportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportButton.Image")));
            this.ExportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(23, 23);
            this.ExportButton.Text = "ExportButton";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 26);
            // 
            // UndoButton
            // 
            this.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoButton.Image")));
            this.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(23, 23);
            this.UndoButton.Text = "toolStripButton2";
            // 
            // redoButton
            // 
            this.redoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoButton.Image = ((System.Drawing.Image)(resources.GetObject("redoButton.Image")));
            this.redoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(23, 23);
            this.redoButton.Text = "toolStripButton1";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(3, 56);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer1);
            this.mainSplitContainer.Size = new System.Drawing.Size(834, 316);
            this.mainSplitContainer.SplitterDistance = 278;
            this.mainSplitContainer.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.Size = new System.Drawing.Size(552, 316);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 375);
            this.Controls.Add(this.mainScreenlayout);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.mainScreenlayout.ResumeLayout(false);
            this.mainScreenlayout.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainToolBox.ResumeLayout(false);
            this.mainToolBox.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainScreenlayout;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateTS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem OpenTS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SaveTS;
        private System.Windows.Forms.ToolStripMenuItem SaveAsTS;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoTS;
        private System.Windows.Forms.ToolStripMenuItem RedoTs;
        private System.Windows.Forms.ToolStrip mainToolBox;
        private System.Windows.Forms.ToolStripButton createButton;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton saveAsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton UndoButton;
        private System.Windows.Forms.ToolStripButton redoButton;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}