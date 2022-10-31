namespace HAO_IKI_WebApp.Models
{
    public class DemografikVeriler
    {
        public int HastaId { get; set; }
        public string EgitimDurumu { get; set; }
        public string MedeniDurum { get; set; }
        public string SigaraKullanimi { get; set; }
        public int? SigragaKullanimSikligi { get; set; }
        public bool  AlkolKullanimi { get; set; }
        public string? AlkolKullanimSikligi { get; set; }
        public float UykuSuresi { get; set; }
        public bool DuzenliEgzersiz { get; set; }
        public string? EgzersizTuru { get; set; }
        public int? EgzersizKacGun { get; set; }
        public int? EgzersizKacSaat { get; set; }
        public string MentalSaglikBir { get; set; }
        public string MentalSaglikIki { get; set; }
        public int UykusuzlukGunSayisi { get; set; }
        public bool AktifCinselYasam { get; set; }
        public bool EsinizinBaskaImamNikahliEsleriVarMi { get; set; }



    }
}
