using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizimBotanikApp.Models
{
    public class Fabrika
    {
        public static List<Cicek> Cicekler { get; set; } = new List<Cicek>
        {
            new Cicek {Id=1,
                KategoriId=1,
                Ad="Gül",
                Aciklama="En aşk dolu güllerden birisidir",
                Resim="Sari gul.jpeg",
                HaftaninCicegiMi=false,
                SliderResmi=""
            },

            new Cicek
            {
                Id=2,
                KategoriId=2,
                Ad="Pembe Cicek",
                Resim="cicekresmi2.jpeg",
                HaftaninCicegiMi=false,
                SliderResmi="",
                Aciklama="Çok tatlı su kenarında olan bir çiçek"
            },
            new Cicek
            {
                Id=3,
                KategoriId=3,
                Ad="Gül",
                Resim="cicekresmi3.jpg",
                HaftaninCicegiMi=false,
                SliderResmi="",
                Aciklama="Çok güzel aşkın temsilcisi"
            },
            new Cicek
            {
                Id=4,
                KategoriId=3,
                Ad="Sarı Gül 2",
                Resim="Sari gul.jpeg",
                HaftaninCicegiMi=false,
                SliderResmi="",
                Aciklama="Sarı çiççek"
            }
        };

        public static List<Kategori> Kategoriler { get; set; } = new List<Kategori>
        {
            new Kategori{Id=1,Ad="Tum Bitkiler"},
            new Kategori{Id=2,Ad="Yasaklı Bitkiler"},
            new Kategori{Id=3,Ad="Şifalı Bitkiler"},
            new Kategori{Id=4,Ad="Yabancı Bitkiler"}
        };

        public List<Yorum> Yorumlar { get; set; }
    }
}
