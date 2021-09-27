using System.Linq;
using Umbraco.Cms.Web.Common;
using Umbraco.Extensions;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoProject.Services
{
    public class ContentHelper
    {
        private readonly UmbracoHelper _umbracoHelper;

        public ContentHelper(UmbracoHelper umbracoHelper)
        {
            _umbracoHelper = umbracoHelper;
        }

        public Settings FindFirstChildOfRoot()
        {
            return _umbracoHelper.ContentAtRoot()?
                .FirstOrDefault()?
                .FirstChild<Settings>();
        }
    }
}
