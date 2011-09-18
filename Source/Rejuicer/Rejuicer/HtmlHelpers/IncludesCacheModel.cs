﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Rejuicer.Model;

namespace Rejuicer.HtmlHelpers
{
    public class IncludesCacheModel
    {
        public IHtmlString IncludesHtml { get; set; }
        public DateTime Timestamp { get; set; }

        public IHtmlString RenderHtml()
        {
            return new HtmlString(IncludesHtml.ToString().Replace(RejuicerConfigurationSource.FilenameUniquePlaceholder, (Timestamp - DateTime.MinValue).Ticks.ToString()));
        }
    }
}
