using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyDirectory
{
  public partial class MainForm : Form
  {

    private CopyDirectory copyEngine;

    public MainForm()
    {
      InitializeComponent();
      this.SetResources();
      copyEngine = new CopyDirectory();
      copyEngine.FileCopied += CopyEngine_FileCopied;

    }

    private void CopyEngine_FileCopied(object sender, FileCopyEventArguments e)
    {
      if (e.Error)
      {
        this.listBoxDirectories.Items.Add("ERROR: " + e.fileCopied);
      }
      else if (e.fileAlreadyCopied)
      {
        this.listBoxDirectories.Items.Add("ALREADY COPIED: " + e.fileCopied);
      }
      else
      {
        this.listBoxDirectories.Items.Add(e.fileCopied);
      }

      this.listBoxDirectories.TopIndex = this.listBoxDirectories.Items.Count - 1;
      Application.DoEvents();
    }


    private void SetResources()
    {
      this.bttnSelectDirOrigin.Text = "...";
      this.bttnCopy.Text = "Start copy";
      this.Text = "copy all directories";
    }

    private void bttnSelectDir_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        this.txtBoxPathOrigin.Text = folderBrowserDialog1.SelectedPath;
      }
    }

    private void bttnCopy_Click(object sender, EventArgs e)
    {
      copyEngine.CopyFolder(txtBoxPathOrigin.Text, txtBoxPathDst.Text);
    }

    private void bttnSelectDirDst_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        this.txtBoxPathDst.Text = folderBrowserDialog1.SelectedPath;
      }
    }
  }

}
