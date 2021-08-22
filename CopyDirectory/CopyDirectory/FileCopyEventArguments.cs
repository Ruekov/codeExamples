using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDirectory
{
  public class FileCopyEventArguments : EventArgs
  {

    public string fileCopied { get; set; }
    public bool fileAlreadyCopied { get; set; }
    public bool Error { get; set; }

  }
}
