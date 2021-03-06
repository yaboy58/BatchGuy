﻿using BatchGuy.App.Parser.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using BatchGuy.App.Parser.Interfaces;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Extensions;
using log4net;
using System.Reflection;

namespace BatchGuy.App.Parser.Services
{
    public class CommandLineProcessService : ICommandLineProcessService
    {
        private CommandLineProcessStartInfo _commandLineProcessStartInfo;
        private readonly ErrorCollection _errors;

        public static readonly ILog _log = LogManager.GetLogger(typeof(CommandLineProcessService));

        public CommandLineProcessService(CommandLineProcessStartInfo commandLineProcessStartInfo)
        {
            _commandLineProcessStartInfo = commandLineProcessStartInfo;
            _errors = new ErrorCollection();
            this.CheckErrors();
        }

        public ErrorCollection Errors
        {
            get { return _errors; }
        }

        public List<ProcessOutputLineItem> GetProcessOutputLineItems()
        {
            List<ProcessOutputLineItem> processOutputLineItems = new List<ProcessOutputLineItem>();
            try
            {
                int id = 1;
                ProcessStartInfo cmdStartInfo = new ProcessStartInfo();
                cmdStartInfo.FileName = _commandLineProcessStartInfo.FileName;
                cmdStartInfo.WindowStyle = ProcessWindowStyle.Normal;
                cmdStartInfo.Arguments = _commandLineProcessStartInfo.Arguments;
                cmdStartInfo.RedirectStandardOutput = true;
                cmdStartInfo.RedirectStandardError = true;
                cmdStartInfo.UseShellExecute = false;

                Process process = Process.Start(cmdStartInfo);
                using (StreamReader streamReader = process.StandardOutput)
                {
                    string output = streamReader.ReadToEnd();
                    string[] splitted = output.Split('\n');
                    foreach (string item in splitted)
                    {
                        processOutputLineItems.Add(new ProcessOutputLineItem() { Id = id, Text = item.RemoveBackspaces() });
                        id++;                        
                    }
                }

                using (StreamReader streamReader = process.StandardError)
                {
                    throw new Exception(streamReader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, ex.StackTrace, MethodBase.GetCurrentMethod().Name);
                _errors.Add(new Error() { Description = "There was an error while trying to execute the cli executable" });
            }

            return processOutputLineItems;
        }

        private ErrorCollection CheckErrors()
        {
            this.CheckFileName();
            this.CheckArguments();

            return _errors;
        }


        private void CheckFileName()
        {
            if (_commandLineProcessStartInfo.FileName == string.Empty || _commandLineProcessStartInfo.FileName == null)
            {
                _errors.Add(new Error() { Description = "Invalid file name" });
            }
        }

        private void CheckArguments()
        {
            if (_commandLineProcessStartInfo.Arguments == string.Empty || _commandLineProcessStartInfo.Arguments == null)
            {
                _errors.Add(new Error() { Description = "Invalid arguments" });
            }
        }
    }
}
