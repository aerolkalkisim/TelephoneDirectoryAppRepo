using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TelephoneDirectoryApp.Model.Entity
{

//    • UUID
//• Ad
//• Soyad
//• Firma
//• İletişim Bilgisi
//o Bilgi Tipi: Telefon Numarası, E-mail Adresi, Konum
//o Bilgi İçeriği

    public class Contact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Firm { get; set; }
        public List<ContactInformation> ContactInformations { get; set; }

    }
}
