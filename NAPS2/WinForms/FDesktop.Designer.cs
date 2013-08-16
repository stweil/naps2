using System;
using System.Collections.Generic;
using System.Linq;

namespace NAPS2.WinForms
{
    partial class FDesktop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDesktop));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.thumbnailList1 = new NAPS2.WinForms.ThumbnailList();
            this.tStrip = new System.Windows.Forms.ToolStrip();
            this.tsScan = new System.Windows.Forms.ToolStripButton();
            this.tsProfiles = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSavePDF = new System.Windows.Forms.ToolStripButton();
            this.tsSaveImage = new System.Windows.Forms.ToolStripButton();
            this.tsPDFEmail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMoveUp = new System.Windows.Forms.ToolStripButton();
            this.tsMoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsRotateLeft = new System.Windows.Forms.ToolStripButton();
            this.tsRotateRight = new System.Windows.Forms.ToolStripButton();
            this.tsFlip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tsClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.BottomToolStripPanel, "toolStripContainer1.BottomToolStripPanel");
            // 
            // toolStripContainer1.ContentPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            this.toolStripContainer1.ContentPanel.Controls.Add(this.thumbnailList1);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.LeftToolStripPanel, "toolStripContainer1.LeftToolStripPanel");
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.RightToolStripPanel, "toolStripContainer1.RightToolStripPanel");
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.TopToolStripPanel, "toolStripContainer1.TopToolStripPanel");
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tStrip);
            // 
            // thumbnailList1
            // 
            resources.ApplyResources(this.thumbnailList1, "thumbnailList1");
            this.thumbnailList1.Name = "thumbnailList1";
            this.thumbnailList1.UseCompatibleStateImageBehavior = false;
            this.thumbnailList1.ItemActivate += new System.EventHandler(this.thumbnailList1_ItemActivate);
            this.thumbnailList1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.thumbnailList1_KeyDown);
            // 
            // tStrip
            // 
            resources.ApplyResources(this.tStrip, "tStrip");
            this.tStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsScan,
            this.tsProfiles,
            this.toolStripSeparator5,
            this.tsSavePDF,
            this.tsSaveImage,
            this.tsPDFEmail,
            this.toolStripSeparator4,
            this.tsMoveUp,
            this.tsMoveDown,
            this.toolStripSeparator1,
            this.tsRotateLeft,
            this.tsRotateRight,
            this.tsFlip,
            this.toolStripSeparator2,
            this.tsDelete,
            this.tsClear,
            this.toolStripSeparator3,
            this.toolStripDropDownButton1,
            this.tsAbout});
            this.tStrip.Name = "tStrip";
            this.tStrip.ShowItemToolTips = false;
            // 
            // tsScan
            // 
            resources.ApplyResources(this.tsScan, "tsScan");
            this.tsScan.Name = "tsScan";
            this.tsScan.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsScan.Click += new System.EventHandler(this.tsScan_Click);
            // 
            // tsProfiles
            // 
            resources.ApplyResources(this.tsProfiles, "tsProfiles");
            this.tsProfiles.Name = "tsProfiles";
            this.tsProfiles.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsProfiles.Click += new System.EventHandler(this.tsProfiles_Click);
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // tsSavePDF
            // 
            resources.ApplyResources(this.tsSavePDF, "tsSavePDF");
            this.tsSavePDF.Image = global::NAPS2.Icons.file_extension_pdf;
            this.tsSavePDF.Name = "tsSavePDF";
            this.tsSavePDF.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsSavePDF.Click += new System.EventHandler(this.tsSavePDF_Click);
            // 
            // tsSaveImage
            // 
            resources.ApplyResources(this.tsSaveImage, "tsSaveImage");
            this.tsSaveImage.Image = global::NAPS2.Icons.picture;
            this.tsSaveImage.Name = "tsSaveImage";
            this.tsSaveImage.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsSaveImage.Click += new System.EventHandler(this.tsSaveImage_Click);
            // 
            // tsPDFEmail
            // 
            resources.ApplyResources(this.tsPDFEmail, "tsPDFEmail");
            this.tsPDFEmail.Image = global::NAPS2.Icons.email_attach;
            this.tsPDFEmail.Name = "tsPDFEmail";
            this.tsPDFEmail.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsPDFEmail.Click += new System.EventHandler(this.tsPDFEmail_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // tsMoveUp
            // 
            resources.ApplyResources(this.tsMoveUp, "tsMoveUp");
            this.tsMoveUp.Image = global::NAPS2.Icons.arrow_up;
            this.tsMoveUp.Name = "tsMoveUp";
            this.tsMoveUp.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsMoveUp.Click += new System.EventHandler(this.tsMoveUp_Click);
            // 
            // tsMoveDown
            // 
            resources.ApplyResources(this.tsMoveDown, "tsMoveDown");
            this.tsMoveDown.Image = global::NAPS2.Icons.arrow_down;
            this.tsMoveDown.Name = "tsMoveDown";
            this.tsMoveDown.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsMoveDown.Click += new System.EventHandler(this.tsMoveDown_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // tsRotateLeft
            // 
            resources.ApplyResources(this.tsRotateLeft, "tsRotateLeft");
            this.tsRotateLeft.Image = global::NAPS2.Icons.arrow_rotate_anticlockwise;
            this.tsRotateLeft.Name = "tsRotateLeft";
            this.tsRotateLeft.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsRotateLeft.Click += new System.EventHandler(this.tsRotateLeft_Click);
            // 
            // tsRotateRight
            // 
            resources.ApplyResources(this.tsRotateRight, "tsRotateRight");
            this.tsRotateRight.Image = global::NAPS2.Icons.arrow_rotate_clockwise;
            this.tsRotateRight.Name = "tsRotateRight";
            this.tsRotateRight.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsRotateRight.Click += new System.EventHandler(this.tsRotateRight_Click);
            // 
            // tsFlip
            // 
            resources.ApplyResources(this.tsFlip, "tsFlip");
            this.tsFlip.Image = global::NAPS2.Icons.arrow_switch;
            this.tsFlip.Name = "tsFlip";
            this.tsFlip.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsFlip.Click += new System.EventHandler(this.tsFlip_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // tsDelete
            // 
            resources.ApplyResources(this.tsDelete, "tsDelete");
            this.tsDelete.Image = global::NAPS2.Icons.cross;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // tsClear
            // 
            resources.ApplyResources(this.tsClear, "tsClear");
            this.tsClear.Image = global::NAPS2.Icons.cancel;
            this.tsClear.Name = "tsClear";
            this.tsClear.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsClear.Click += new System.EventHandler(this.tsClear_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // toolStripDropDownButton1
            // 
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.Image = global::NAPS2.Icons.world;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            // 
            // tsAbout
            // 
            resources.ApplyResources(this.tsAbout, "tsAbout");
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsAbout.Click += new System.EventHandler(this.tsAbout_Click);
            // 
            // FDesktop
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FDesktop";
            this.Load += new System.EventHandler(this.FDesktop_Load);
            this.Shown += new System.EventHandler(this.FDesktop_Shown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tStrip.ResumeLayout(false);
            this.tStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tStrip;
        private System.Windows.Forms.ToolStripButton tsScan;
        private System.Windows.Forms.ToolStripButton tsSavePDF;
        private System.Windows.Forms.ToolStripButton tsSaveImage;
        private System.Windows.Forms.ToolStripButton tsPDFEmail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private ThumbnailList thumbnailList1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsMoveUp;
        private System.Windows.Forms.ToolStripButton tsMoveDown;
        private System.Windows.Forms.ToolStripButton tsRotateRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsRotateLeft;
        private System.Windows.Forms.ToolStripButton tsFlip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsProfiles;
        private System.Windows.Forms.ToolStripButton tsAbout;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
    }
}
