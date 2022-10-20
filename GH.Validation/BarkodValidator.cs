using GH.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.Validation
{
    public class BarkodValidator : ValidationBase<BarkodKontrolDTO>
    {
        public BarkodValidator(BarkodKontrolDTO model) : base(model)
        {

        }
        protected override void OnValidate()
        {
            BarkodValidatorFunction();
        }

        private void BarkodValidatorFunction()
        {
            if (Model.Barkod == Guid.Empty)
            {
                IsValid = false;
                ValidationMessages.Add("Barkod alanı boş geçilemez.");
            }

        }
    }
}
