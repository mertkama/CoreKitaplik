using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CoreKitaplik.Models;

namespace CoreKitaplik.ViewComponents
{
    public class YeniKitaplar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var kitaplistesi = new List<Kitaplar>
            {
                new Kitaplar
                {
                    ID=6,
                    KitapAd="Korku",
                    Yazar="Zweig"
                },
                new Kitaplar
                {
                    ID=7,
                    KitapAd="Anna Karanina",
                    Yazar="Tolstoy"
                }
            };
            return View(kitaplistesi);
        }
    }
}
