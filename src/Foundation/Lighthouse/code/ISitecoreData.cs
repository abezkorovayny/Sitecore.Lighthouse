﻿using Foundation.Lighthouse.Model.Autogenerated;
using Sitecore.Data.Items;

namespace Foundation.Lighthouse
{
    public interface ISitecoreData
    {
        bool AddCheckPoint(Item item, LighthouseJson data);
    }
}