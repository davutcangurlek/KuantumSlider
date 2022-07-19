using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuantum.Widgets.Slider.Models;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;

namespace Kuantum.Widgets.Slider.Controllers
{
    [Area(AreaNames.Admin)]
    [AutoValidateAntiforgeryToken]
    public class KuantumSliderController : BasePluginController
    {
        private readonly KuantumSliderSettings _kuantumSliderSettings;
        public KuantumSliderController(KuantumSliderSettings kuantumSliderSettings)
        {
            _kuantumSliderSettings = kuantumSliderSettings;
        }
        public async Task<IActionResult> Configure()
        {
            var model = new KuantumSliderConfigureModel
            {
                ContainerCssSelector = _kuantumSliderSettings.ContainerCssSelector,
                PaginationSelector = _kuantumSliderSettings.PaginationSelector,
                NavigationNextCssSelector = _kuantumSliderSettings.NavigationNextCssSelector,
                NavigationPrevCssSelector = _kuantumSliderSettings.NavigationPrevCssSelector,
                ScrollBarCssSelector = _kuantumSliderSettings.ScrollBarCssSelector,
                Direction = _kuantumSliderSettings.Direction,
                InitialSlide = _kuantumSliderSettings.InitialSlide,
                Speed = _kuantumSliderSettings.Speed,
                Loop = _kuantumSliderSettings.Loop,
                PaginationEnabled = _kuantumSliderSettings.PaginationEnabled,
                NavigationEnabled = _kuantumSliderSettings.NavigationEnabled,
                ScrollBarEnabled = _kuantumSliderSettings.ScrollBarEnabled,
            };
            return View("~/Plugins/Kuantum.Widgets.Slider/Views/Configure.cshtml", model);
        }

    }
}
