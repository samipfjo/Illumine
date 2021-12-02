﻿
namespace Illumine
{
    partial class SearchResults
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
            this.ResultsFileList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ResultsFileList
            // 
            this.ResultsFileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ResultsFileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultsFileList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ResultsFileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsFileList.ForeColor = System.Drawing.Color.White;
            this.ResultsFileList.FormattingEnabled = true;
            this.ResultsFileList.ItemHeight = 25;
            this.ResultsFileList.Location = new System.Drawing.Point(272, 401);
            this.ResultsFileList.Name = "ResultsFileList";
            this.ResultsFileList.Size = new System.Drawing.Size(1300, 550);
            this.ResultsFileList.TabIndex = 1;
            this.ResultsFileList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.SearchResults_DrawItem);
            this.ResultsFileList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResultsFileList_KeyDown);
            this.ResultsFileList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ResultsFileList_MouseDoubleClick);
            // 
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.ResultsFileList);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchResults";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Illumine";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchResults_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.SearchResults_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ResultsFileList;
    }
}