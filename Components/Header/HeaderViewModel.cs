using Umbraco.Cms.Core.Models.PublishedContent;
using System.Collections.Generic;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoProject.Components.Header
{
    public class HeaderViewModel
    {
        public IPublishedContent Logo { get; set; }
        public IEnumerable<Link> MenuItems { get; set; }
        public string SignInMenuTitle { get; set; }
        public IEnumerable<SignInItem> SignInMenuItems { get; set; }
        public IReadOnlyDictionary<string, PublishedCultureInfo> Cultures { get; set; }
    }
}
