using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDirectory
{
  public class CopyDirectory
  {


    // Delegate declaration. 
    // 
    public delegate void FileCopyEventHandler(object sender, FileCopyEventArguments e);

    public event FileCopyEventHandler FileCopied;
    protected virtual void OnFileCopied(FileCopyEventArguments e)
    {
      FileCopyEventHandler handler = FileCopied;
      if (handler != null)
      {
        // Invokes the delegates.
        handler(this, e);
      }
    }

    public List<string> GetDirectoryFiles(string directoryPath)
    {

      List<string> listToReturn = new List<string>();

      listToReturn = System.IO.Directory.GetFiles(directoryPath).ToList();

      return listToReturn;

    }

    public List<string> GetDirectories(string directoryPath)
    {

      List<string> listToReturn = new List<string>();

      listToReturn = System.IO.Directory.GetDirectories(directoryPath).ToList();

      return listToReturn;

    }


    public void CopyFolder(string sourceFolder, string destFolder)
    {

      FileCopyEventArguments e;
      if (!System.IO.Directory.Exists(destFolder))
        System.IO.Directory.CreateDirectory(destFolder);

      List<string> files = this.GetDirectoryFiles(sourceFolder);

      foreach (string file in files)
      {
        string name = System.IO.Path.GetFileName(file);
        string dest = System.IO.Path.Combine(destFolder, name);

        if (System.IO.File.Exists(file))
        {

          e = new FileCopyEventArguments() { fileCopied = name, fileAlreadyCopied = true, Error = false };
        }
        else
        {
          try
          {
            System.IO.File.Copy(file, dest);
            e = new FileCopyEventArguments() { fileCopied = name, fileAlreadyCopied = false, Error = false };
          }
          catch (Exception)
          {
            e = new FileCopyEventArguments() { fileCopied = name, fileAlreadyCopied = false, Error=true };
          }
          
        }

        OnFileCopied(e);

      }

      List<string> folders = this.GetDirectories(sourceFolder);

      foreach (string folder in folders)
      {
        string name = System.IO.Path.GetFileName(folder);
        string dest = System.IO.Path.Combine(destFolder, name);
        CopyFolder(folder, dest);
      }
    }

  }
}
