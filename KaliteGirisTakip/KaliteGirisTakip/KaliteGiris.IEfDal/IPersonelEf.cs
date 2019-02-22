﻿using KaliteGiris.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaliteGiris.IEfDal
{
    public interface IPersonelEf
    {
        int PersonelEkle(Personel Personel);
        int PersonelGuncelle(Personel Personel);
        int PersonelSil(Personel Personel);
        List<Personel> PersonelListele();
    }
}
