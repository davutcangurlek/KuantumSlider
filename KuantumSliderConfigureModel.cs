using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Kuantum.Widgets.Slider.Models
{

    public record KuantumSliderConfigureModel : BaseNopModel
    {


        [NopResourceDisplayName("Kuantum.Widgets.Slider.Models.ContainerCssSelector")]
        public string ContainerCssSelector { get; set; }
        [NopResourceDisplayName("Kuantum.Widgets.Slider.Models.PaginationSelector")]
        public string PaginationSelector { get; set; }
        [NopResourceDisplayName("Kuantum.Widgets.Slider.Models.NavigationNextCssSelector")]
        public string NavigationNextCssSelector { get; set; }
        [NopResourceDisplayName("Kuantum.Widgets.Slider.Models. NavigationPrevCssSelector")]
        public string NavigationPrevCssSelector { get; set; }
        [NopResourceDisplayName("Kuantum.Widgets.Slider.Models.ScrollBarCssSelector")]
        public string ScrollBarCssSelector { get; set; }
        [NopResourceDisplayName("Kuantum.Widgets.Slider.Models.Direction")]
        public Direction Direction { get; set; }
        [NopResourceDisplayName("Kuantum.Widgets.Slider.Models.InitialSlide")]
        public int InitialSlide { get; set; }
        [NopResourceDisplayName("Kuantum.Widgets.Slider.Models.Speed")]
        public int Speed { get; set; }
        [NopResourceDisplayName("Kuantum.Widgets.Slider.Models.Loop")]
        public bool Loop { get; set; }
        [NopResourceDisplayName("Kuantum.Widgets.Slider.Models.PaginationEnabled")]
        public bool PaginationEnabled { get; set; }
        [NopResourceDisplayName("Kuantum.Widgets.Slider.Models.NavigationEnabled")]
        public bool NavigationEnabled { get; set; }
        [NopResourceDisplayName("Kuantum.Widgets.Slider.Models.ScrollBarEnabled")]
        public bool ScrollBarEnabled { get; set; }

    }
}
