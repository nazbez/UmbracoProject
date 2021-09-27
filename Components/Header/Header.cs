using Microsoft.AspNetCore.Mvc;
using UmbracoProject.Services;

namespace UmbracoProject.Components.Header
{
    public class Header : ViewComponent
    {
        private readonly ContentHelper _contentHelper;

        public Header(ContentHelper contentHelper)
        {
            _contentHelper = contentHelper;
        }

        public IViewComponentResult Invoke()
        {
            var settings = _contentHelper.FindFirstChildOfRoot();

            var headerModel = new HeaderViewModel()
            {
                Logo = settings.ImagePicker,
                MenuItems = settings.MenuItemsPicker,
                SignInMenuItems = settings.SignInItemsPicker,
                SignInMenuTitle = settings.SignInMenuTitle,
                Cultures = settings.Cultures
            };


            return View(headerModel);
        }
    }
}
