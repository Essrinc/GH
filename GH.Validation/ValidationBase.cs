using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.Validation
{
    public abstract class ValidationBase<TModel> where TModel : class
    {
        public ValidationBase(TModel model)
        {
            Model = model;
            ValidationMessages = new List<string>();
            IsValid = true;
            OnValidate();
        }

        protected TModel Model { get; set; }
        public List<string> ValidationMessages { get; set; }
        public bool IsValid { get; set; }

        protected abstract void OnValidate();
    }
}
