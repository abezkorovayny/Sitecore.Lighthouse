﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using Foundation.Lighthouse.Model.Autogenerated;
using Newtonsoft.Json;
using Sitecore.Data.Items;
using Sitecore.Web;

namespace Foundation.Lighthouse
{
    public class LighthouseRunner : ILighthouseRunner
    {
        private readonly IPaths _paths;
        private readonly IUrls _urls;
        private ISitecoreData _sitecoreData;
        private IItemsProvider _itemsProvider;
        public LighthouseRunner(IPaths paths, IUrls urls, ISitecoreData sitecoreData, IItemsProvider itemsProvider)
        {
            _paths = paths;
            _urls = urls;
            _sitecoreData = sitecoreData;
            _itemsProvider = itemsProvider;
        }
        public bool Run(Item item, OutputFormat format, SiteInfo siteInfo)
        {
            var processOutput = new ConcurrentBag<string>();
            _paths.CreateReportDir(item);
            
            var process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = _paths.GetLighthouseCmdPath();
            //startInfo.Arguments = $"/c \"";
            startInfo.Arguments += $"{_urls.GetItemUrl(item, siteInfo)}";
            var path = "";
            switch (format)
            {
                case OutputFormat.Html:
                    path = _paths.GetReportHtmlPath(item);
                    break;
                case OutputFormat.Json:
                    path = _paths.GetReportJsonPath(item);
                    startInfo.Arguments += GetOutputFormat(format);
                    break;
            }

            startInfo.Arguments += GetOutputPath(path);
            startInfo.Arguments += " --chrome-flags=\"--ignore-certificate-errors\"";

            //startInfo.Arguments += "\"";
            //startInfo.UseShellExecute = false;
            //startInfo.RedirectStandardOutput = true;
            //startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            process.StartInfo = startInfo;
            process.OutputDataReceived += (sender, eventArgs) => processOutput.Add(eventArgs.Data);
            process.ErrorDataReceived += (sender, eventArgs) => processOutput.Add(eventArgs.Data);

            Sitecore.Diagnostics.Log.Error(startInfo.FileName, this);
            Sitecore.Diagnostics.Log.Error(startInfo.Arguments, this);
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit(30000);

            if (format == OutputFormat.Json)
            {
                var json = File.ReadAllText(path);
                var model = JsonConvert.DeserializeObject<LighthouseJson>(json);
                _sitecoreData.AddCheckPoint(item, model);
            }
            //return process.ExitCode == 0;
            return true;
        }

        public void RunAll()
        {
            var siteInfoList = Sitecore.Configuration.Factory.GetSiteInfoList();

            var sitesToExclude = new List<string> {"shell", "service", "login", "admin", "modules_shell", "modules_website", "scheduler", "system", "publisher", "exm"};
            foreach (SiteInfo siteInfo in siteInfoList)
            {
                if (!sitesToExclude.Contains(siteInfo.Name))
                {
                    foreach (var item in _itemsProvider.GetAllItemsWithPresentationFilteredByTemplate(siteInfo,
                        Constants.LighthouseTemplate, null))
                    {
                        Run(item, OutputFormat.Html, siteInfo);
                        Run(item, OutputFormat.Json, siteInfo);
                    }
                }
            }
        }

        private string GetOutputPath(string path)
        {
            return $" --output-path \"{path}\"";
        }

        private string GetOutputFormat(OutputFormat format)
        {
            return $" --output {Enum.GetName(typeof(OutputFormat), format)?.ToLower()}";
        }
    }
}