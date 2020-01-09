﻿using System.Web;
using Foundation.Lighthouse.Model.Autogenerated.Concrete.Foundation.Lighthouse;
using Sitecore.Shell.Framework.Commands;
using Sitecore.Web.UI.Sheer;

namespace Foundation.Lighthouse.Commands
{
    public class Chart : Command
    {
        public Chart()
        {
        }
        public override void Execute(CommandContext context)
        {
            var item = context.Items[0];
            var lighthouseItem = new _Lighthouse(item);
            if (!string.IsNullOrEmpty(lighthouseItem?.Data.RawValue))
            {
                //Do not disclose internal server configuration to user
                var url = $"{HttpContext.Current.Request.Url.Scheme}://{HttpContext.Current.Request.Url.Host}/api/sitecore/lighthouse/Chart?database={item.Database}&itemId={item.ID}";
                SheerResponse.ShowModalDialog(new ModalDialogOptions(url) { Response = false, MinWidth = "920", MinHeight = "220", Width = "1000"});
            }
            else
            {
                SheerResponse.ShowError("Not enough data to display chart.",
                    "Please, try to run report creation before trying to open it.");
            }
        }
    }
}