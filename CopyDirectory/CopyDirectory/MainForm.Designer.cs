namespace CopyDirectory
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
      this.txtBoxPathOrigin = new System.Windows.Forms.TextBox();
      this.bttnSelectDirOrigin = new System.Windows.Forms.Button();
      this.listBoxDirectories = new System.Windows.Forms.ListBox();
      this.bttnCopy = new System.Windows.Forms.Button();
      this.bttnSelectDirDst = new System.Windows.Forms.Button();
      this.txtBoxPathDst = new System.Windows.Forms.TextBox();
      this.lblOriginFolder = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtBoxPathOrigin
      // 
      this.txtBoxPathOrigin.Location = new System.Drawing.Point(169, 34);
      this.txtBoxPathOrigin.Name = "txtBoxPathOrigin";
      this.txtBoxPathOrigin.Size = new System.Drawing.Size(235, 20);
      this.txtBoxPathOrigin.TabIndex = 0;
      // 
      // bttnSelectDirOrigin
      // 
      this.bttnSelectDirOrigin.Location = new System.Drawing.Point(410, 34);
      this.bttnSelectDirOrigin.Name = "bttnSelectDirOrigin";
      this.bttnSelectDirOrigin.Size = new System.Drawing.Size(75, 20);
      this.bttnSelectDirOrigin.TabIndex = 1;
      this.bttnSelectDirOrigin.Text = "...";
      this.bttnSelectDirOrigin.UseVisualStyleBackColor = true;
      this.bttnSelectDirOrigin.Click += new System.EventHandler(this.bttnSelectDir_Click);
      // 
      // listBoxDirectories
      // 
      this.listBoxDirectories.FormattingEnabled = true;
      this.listBoxDirectories.Location = new System.Drawing.Point(13, 148);
      this.listBoxDirectories.Name = "listBoxDirectories";
      this.listBoxDirectories.Size = new System.Drawing.Size(518, 95);
      this.listBoxDirectories.TabIndex = 2;
      // 
      // bttnCopy
      // 
      this.bttnCopy.Location = new System.Drawing.Point(334, 102);
      this.bttnCopy.Name = "bttnCopy";
      this.bttnCopy.Size = new System.Drawing.Size(151, 27);
      this.bttnCopy.TabIndex = 3;
      this.bttnCopy.Text = "Copy Directory";
      this.bttnCopy.UseVisualStyleBackColor = true;
      this.bttnCopy.Click += new System.EventHandler(this.bttnCopy_Click);
      // 
      // bttnSelectDirDst
      // 
      this.bttnSelectDirDst.Location = new System.Drawing.Point(410, 66);
      this.bttnSelectDirDst.Name = "bttnSelectDirDst";
      this.bttnSelectDirDst.Size = new System.Drawing.Size(75, 20);
      this.bttnSelectDirDst.TabIndex = 5;
      this.bttnSelectDirDst.Text = "...";
      this.bttnSelectDirDst.UseVisualStyleBackColor = true;
      this.bttnSelectDirDst.Click += new System.EventHandler(this.bttnSelectDirDst_Click);
      // 
      // txtBoxPathDst
      // 
      this.txtBoxPathDst.Location = new System.Drawing.Point(169, 66);
      this.txtBoxPathDst.Name = "txtBoxPathDst";
      this.txtBoxPathDst.Size = new System.Drawing.Size(235, 20);
      this.txtBoxPathDst.TabIndex = 4;
      // 
      // lblOriginFolder
      // 
      this.lblOriginFolder.AutoSize = true;
      this.lblOriginFolder.Location = new System.Drawing.Point(47, 34);
      this.lblOriginFolder.Name = "lblOriginFolder";
      this.lblOriginFolder.Size = new System.Drawing.Size(66, 13);
      this.lblOriginFolder.TabIndex = 6;
      this.lblOriginFolder.Text = "Origin folder:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(47, 73);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(92, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "Destination folder:";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(543, 261);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lblOriginFolder);
      this.Controls.Add(this.bttnSelectDirDst);
      this.Controls.Add(this.txtBoxPathDst);
      this.Controls.Add(this.bttnCopy);
      this.Controls.Add(this.listBoxDirectories);
      this.Controls.Add(this.bttnSelectDirOrigin);
      this.Controls.Add(this.txtBoxPathOrigin);
      this.Name = "MainForm";
      this.Text = "Copy directory...";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtBoxPathOrigin;
    private System.Windows.Forms.Button bttnSelectDirOrigin;
    private System.Windows.Forms.ListBox listBoxDirectories;
    private System.Windows.Forms.Button bttnCopy;
    private System.Windows.Forms.Button bttnSelectDirDst;
    private System.Windows.Forms.TextBox txtBoxPathDst;
    private System.Windows.Forms.Label lblOriginFolder;
    private System.Windows.Forms.Label label1;
  }
}

