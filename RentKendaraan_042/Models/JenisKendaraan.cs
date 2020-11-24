using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentKendaraan_042.Models
{
    public partial class JenisKendaraan
    {
        public int IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Jenis Kendaraan wajib diisi !")]
        [RegularExpression("^[A-Z]*$", ErrorMessage = "Jenis Kendaraan hanya boleh diisi dengan huruf/ jenis kendaraan tersebut")]
        public string NamaJenisKendaraan { get; set; }

        public Kendaraan Kendaraan { get; set; }
    }
}
