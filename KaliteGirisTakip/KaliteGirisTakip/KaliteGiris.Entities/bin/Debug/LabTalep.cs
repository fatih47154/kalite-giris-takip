﻿namespace KaliteGiris.Entities
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.SqlClient;
    using System.ComponentModel.DataAnnotations;
    using Abstract;

    [Table("LabTalep")]
    public partial class LabTalep : ABaseEntity
    {       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid LabTalepId { get; set; }

        public int Sira { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime RaporTarihi { get; set; }      
        public Guid FirmaId { get; set; }
        public string SozlesmeNo { get; set; }
        public Guid AlimTipiId { get; set; }
        public string Malzeme { get; set; }
        public string IrsaliyeNo { get; set; }   
        public Guid PersonelId { get; set; }        
        public Guid DurumId { get; set; }
        public Guid SonucDurumId { get; set; }
        public Guid GKKSonucId { get; set; }
        public string Aciklama { get; set; }

        public virtual Personel Personel { get; set; }
        public virtual Firma Firma { get; set; }
        public virtual AlimTipi AlimTipi { get; set; }

        [ForeignKey("DurumId")]
        public virtual Durum Durum { get; set; }

        [ForeignKey("SonucDurumId")]
        public virtual Durum SonucDurum { get; set; }

        [ForeignKey("GKKSonucId")]
        public virtual Durum GKKSonucDurum { get; set; }

    }
}
