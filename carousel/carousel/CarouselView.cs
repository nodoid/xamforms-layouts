using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace carousel
{
    public class CarouselViewList
    {
        public string ImageName { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }

    public class CarouselView : CarouselPage
    {
        public CarouselView()
        {
            // create the List of images and names
            this.ItemsSource = new CarouselViewList[]
            {
                new CarouselViewList { ImageName = Device.OS == TargetPlatform.WinPhone ? "Assets/rocky.png" : "rocky.png", Title = "Rocky Horror Show" },
                new CarouselViewList { ImageName = Device.OS == TargetPlatform.WinPhone ? "Assets/zxspectrum.png" :"zxspectrum.png", Title = "ZX Spectrum" },
                new CarouselViewList { ImageName = Device.OS == TargetPlatform.WinPhone ? "Assets/chemical.png" :"chemical.png", Title = "Chemical" },
                new CarouselViewList { ImageName = Device.OS == TargetPlatform.WinPhone ? "Assets/android.png" :"android.png", Title = "Android" },
                new CarouselViewList { ImageName = Device.OS == TargetPlatform.WinPhone ? "Assets/farmapps.png" :"farmapps.png", Title = "Farm Apps" }
            };

            this.ItemTemplate = new DataTemplate(() =>
                {
                    return new ViewPage();
                });
        }
    }
}


