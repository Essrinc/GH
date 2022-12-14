using GH.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.Validation
{
    public class KullaniciBilgiGuncellemeValidator : ValidationBase<KullaniciGuncelleDTO>
    {
        public KullaniciBilgiGuncellemeValidator(KullaniciGuncelleDTO model) : base(model)
        {

        }
        protected override void OnValidate()
        {
            GuncelleValidatorFunction();
        }

        private void GuncelleValidatorFunction()
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
