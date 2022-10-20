using GH.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.Validation
{
    public class LoginValidator:ValidationBase<LoginDTO>
    {
        public LoginValidator(LoginDTO model) : base(model)
        {
            
        }
        protected override void OnValidate()
        {
            LoginValidatorFunction();
        }

        private void LoginValidatorFunction()
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
        }
    }
}
