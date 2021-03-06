﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaliteGiris.Entities
{
    [Table("Personel")]
    public class Personel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid PersonelId { get; set; }
        public int PersonelNo { get; set; }
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        [StringLength(11)]
        public string Tc { get; set; }
        public string Kullanici { get; set; }
        public string Sifre { get; set; }
        public string Email { get; set; }
        public bool Durum { get; set; }
        public Guid RolId { get; set; }
        public virtual Role Role { get; set; }
    }
}
