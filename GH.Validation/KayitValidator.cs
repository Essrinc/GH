using GH.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.Validation
{
    public class KayitValidator : ValidationBase<KayitDTO>
    {
        public KayitValidator(KayitDTO model) : base(model)
        {

        }
        protected override void OnValidate()
        {
            KayitValidatorFunction();
        }

        private void KayitValidatorFunction()
        {
            if (string.IsNullOrEmpty(Model.KullaniciAdi))
            {
                IsValid = false;
                ValidationMessages.Add("Kullanıcı adı alanı boş geçilemez.");
            }

            if (string.IsNullOrEmpty(Model.Sifre))
            {
                IsValid = false;
                ValidationMessages.Add("Şifre alanı boş geçilemez.");
            }

            if (string.IsNullOrEmpty(Model.Email))
            {
                IsValid = false;
                ValidationMessages.Add("Email alanı boş geçilemez.");
            }
        }
    }
}
