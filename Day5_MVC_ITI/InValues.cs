using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Web;

namespace Day5_MVC_ITI
{
    public class InValues : ValidationAttribute
    {
        List<String> vals = new List<String>();
        public InValues(String [] v)
        {
            if(v?.Length > 0 && v!=null)
            for(int i=0;i<v?.Length;i++)
                {
                    vals.Add(v[i]);
                }
        }

        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            if( value is String)
            {
                if(value != null && value!= "" && vals?.Count>0)
                {
                    if (vals.Contains(value)) return ValidationResult.Success;
                }
            }
            return new ValidationResult("data should match at lease one item of a set of data items");
        }
    }
}