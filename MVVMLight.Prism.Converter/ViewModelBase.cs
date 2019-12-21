using Prism.Mvvm;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace OperatingApplication.Prism.MVVMLight2Prism
{
    public class ViewModelBase : BindableBase
    {
        public void RaisePropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            var propertyName = GetPropertyName(propertyExpression);
            RaisePropertyChanged(propertyName);
        }

        //taken from lbugnion/mvvmlight
        private string GetPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            if (propertyExpression == null)
            {
                throw new ArgumentNullException("propertyExpression");
            }

            var body = propertyExpression.Body as MemberExpression;

            if (body == null)
            {
                throw new ArgumentException("Invalid argument", "propertyExpression");
            }

            var property = body.Member as PropertyInfo;

            if (property == null)
            {
                throw new ArgumentException("Argument is not a property", "propertyExpression");
            }

            return property.Name;
        }
    }
}
