﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

/*
 * FileName: Log.cs
 * Author: Joakim Hising
 */

/// <summary>
/// Log messages to a file
/// </summary>
public class Log
{
    /// <summary>
    /// CONSTRUCTOR
    /// Sets the file location & name to a default value
    /// </summary>
    public Log()
    {
        this.FileLocation = System.Web.HttpContext.Current.Server.MapPath("~");
        this.FileName = "log.txt";
    }
    
    private string fileName = "";
    public string FileName
    {
        get { return this.fileName; }
        set { this.fileName = value; }
    }

    private string fileLocation = "";
    public string FileLocation
    {
        get { return this.fileLocation; }
        set 
        {
            this.fileLocation = value;
            // Checks if a '\' is on the end of 'fileLocation', if not, append it!
            if (this.fileLocation.LastIndexOf("\\") != (this.fileLocation.Length - 1))
            {
                this.fileLocation += "\\";
            }
        }
    }


    /// <summary>
    /// Log message to file
    /// Ex.
    /// 2013-03-05 10:35:00 - "Log Message"
    /// </summary>
    /// <param name="Message">The string to be logged</param>
    public void LogMessage(string Message)
    {
        FileStream fileStream = null;
        StreamWriter streamwriter = null;
        StringBuilder stringBuilder = new StringBuilder();
        try
        {
            fileStream = new FileStream(this.fileLocation + this.FileName, FileMode.OpenOrCreate, FileAccess.Write);
            streamwriter = new StreamWriter(fileStream);
            streamwriter.BaseStream.Seek(0, SeekOrigin.End);
            stringBuilder.Append(System.DateTime.Now.ToString()).Append(" - ").Append(Message);
            streamwriter.WriteLine(stringBuilder.ToString());
            streamwriter.Flush();
        }
        finally
        {
            if (streamwriter != null)
            {
                streamwriter.Close();
            }
        }
    }
}