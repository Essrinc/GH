using GH.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.Validation
{
    public class UrunEkleValidator: ValidationBase<UrunDTO>
    {
        public UrunEkleValidator(UrunDTO model) : base(model)
        {

        }
        protected override void OnValidate()
        {
            UrunEkleValidatorFunction();
        }
        private void UrunEkleValidatorFunction()
        {
            if (string.IsNullOrEmpty(Model.Barkod))
            {
                IsValid = false;
                ValidationMessages.Add("Barkod alanı boş geçilemez.");
            }

            if (Model.KategoriID < 0)
            {
                IsValid = false;
                ValidationMessages.Add("Kategori alanı boş geçilemez.");
            }
            if (Model.UreticiID < 0)
            {
                IsValid = false;
                ValidationMessages.Add("Üretici alanı boş geçilemez.");
            }

            if (string.IsNullOrEmpty(Model.Adi))
            {
                IsValid = false;
                ValidationMessages.Add("Ürün adı alanı boş geçilemez.");
            }
        }
    }
}
