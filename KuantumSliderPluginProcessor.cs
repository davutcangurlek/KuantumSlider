using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Services.Cms;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Kuantum.Widgets.Slider
{
    public class KuantumSliderPluginProcessor : BasePlugin, IWidgetPlugin
    {
        private readonly ILocalizationService _localizationService;
        private readonly ISettingService _settingService;
        private readonly IWebHelper _webHelper;
        public KuantumSliderPluginProcessor(ISettingService settingService,
            IWebHelper webHelper,
            ILocalizationService localizationService)
        {
            _webHelper = webHelper;
            _settingService = settingService;
            _localizationService = localizationService;
         
        }

        public override async Task InstallAsync()
        {
            var settings = new KuantumSliderSettings
            {
                ContainerCssSelector = ".swiper",
                PaginationSelector = ".swiper-pagination",
                NavigationNextCssSelector = ".swiper-button-next",
                NavigationPrevCssSelector = ".swiper-button-prev",
                ScrollBarCssSelector = ".swiper-scrollbar",
                Direction = Direction.Horizontal,
                InitialSlide = 0,
                Speed = 300,
                Loop = true,
                PaginationEnabled = true,
                NavigationEnabled = true,
                ScrollBarEnabled = false,
            };
            await _settingService.SaveSettingAsync(settings);

            _localizationService.AddOrUpdateLocaleResourceAsync("Kuantum.Widgets.Slider.Models.ContainerCssSelector", "Container Css Selector");
            _localizationService.AddOrUpdateLocaleResourceAsync("Kuantum.Widgets.Slider.Models.ContainerCssSelector.Hint", "Swiper slider kapsayan css selector girin id için #selector class için .selector  ");
            _localizationService.AddOrUpdateLocaleResourceAsync("Kuantum.Widgets.Slider.Models.PaginationSelector", "Pagination Selector");
            _localizationService.AddOrUpdateLocaleResourceAsync("Kuantum.Widgets.Slider.Models.NavigationNextCssSelector", "Navigation Next Css Selector");
            _localizationService.AddOrUpdateLocaleResourceAsync("Kuantum.Widgets.Slider.Models.NavigationPrevCssSelector", "Navigation Prev Css Selector");
            _localizationService.AddOrUpdateLocaleResourceAsync("Kuantum.Widgets.Slider.Models.ScrollBarCssSelector", "Scroll Bar Css Selector");
            _localizationService.AddOrUpdateLocaleResourceAsync("Kuantum.Widgets.Slider.Models.Direction", "Direction");
            _localizationService.AddOrUpdateLocaleResourceAsync("Kuantum.Widgets.Slider.Models.InitialSlide", "Initial Slide");
            _localizationService.AddOrUpdateLocaleResourceAsync("Kuantum.Widgets.Slider.Models.Speed", "Speed");
            _localizationService.AddOrUpdateLocaleResourceAsync("Kuantum.Widgets.Slider.Models.Loop", "Loop");
            _localizationService.AddOrUpdateLocaleResourceAsync("Kuantum.Widgets.Slider.Models.PaginationEnabled", "Pagination Enabled");
            _localizationService.AddOrUpdateLocaleResourceAsync("Kuantum.Widgets.Slider.Models.NavigationEnabled", "Navigation Enabled");
            _localizationService.AddOrUpdateLocaleResourceAsync("Kuantum.Widgets.Slider.Models.ScrollBarEnabled", "Scroll Bar Enabled");


            await base.InstallAsync();
        }
        public override async Task UninstallAsync()
        {
            await _settingService.DeleteSettingAsync<KuantumSliderSettings>();
            await _localizationService.DeleteLocaleResourcesAsync("Kuantum.Widgets.Slider");

            await base.UninstallAsync();
        }

        public bool HideInWidgetList => false;

        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "KuantumSlider";
        }

        public Task<IList<string>> GetWidgetZonesAsync()
        {
            return Task.FromResult<IList<string>>(new List<string> { PublicWidgetZones.HomepageTop, PublicWidgetZones.ProductDetailsTop });
        }
        public override string GetConfigurationPageUrl()
        {
            return $"{_webHelper.GetStoreLocation()}Admin/KuantumSlider/Configure";
        }
    }
}
