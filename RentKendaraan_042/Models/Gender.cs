using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentKendaraan_042.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customer = new HashSet<Customer>();
        }

        public int IdGender { get; set; }

        [Required(ErrorMessage = "Gender wajib diisi, silahkan pilih !")]
        [RegularExpression("^[L-P]*$", ErrorMessage = "1 untuk L, 2 untuk P")]
        public string NamaGender { get; set; }

        public ICollection<Customer> Customer { get; set; }
    }
}
