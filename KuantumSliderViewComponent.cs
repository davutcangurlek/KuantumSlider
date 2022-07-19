using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using Nop.Services.Configuration;
using Nop.Web.Framework.Components;

namespace Kuantum.Widgets.Slider.Components
{
    [ViewComponent(Name ="KuantumSlider")]
    public class KuantumSliderViewComponent : NopViewComponent
    {

        private readonly ISettingService _settingService;
        private readonly KuantumSliderSettings _kuantumSliderSettings;

        public KuantumSliderViewComponent(KuantumSliderSettings kuantumSliderSettings,
            ISettingService settingService)
        {
            
            _kuantumSliderSettings = kuantumSliderSettings;
            _settingService = settingService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        {

            var KuantumSliderSettings = await _settingService.LoadSettingAsync<KuantumSliderSettings>();
            return View("~/Plugins/Kuantum.Widgets.Slider/Views/PublicInfo.cshtml", KuantumSliderSettings);
        }
    }
}
