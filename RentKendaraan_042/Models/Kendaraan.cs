using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentKendaraan_042.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Nama Kendaraan wajib diisi !")]
        [RegularExpression("^[A-Z]*$", ErrorMessage = "Nama Kendaraan hanya boleh diisi dengan huruf/ nama kendaraan tersebut")]
        public string NamaKendaraan { get; set; }

        [Required(ErrorMessage = "No Polisi wajib diisi !")]
        public string NoPolisi { get; set; }

        [Required(ErrorMessage = "No STNK wajib diisi !")]
        [MaxLength(7, ErrorMessage = "No STNK tidak boleh lebih dari 7 angka")]
        public string NoStnk { get; set; }

        public int? IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Ketersediaan wajib diisi !")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
