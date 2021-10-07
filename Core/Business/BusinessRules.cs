using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Business
{
    public class BusinessRules
    {
        //Aynı isimde ürün eklenemez
        //Eğer mevcut kategori sayısı 15'i geçtiyse sisteme yeni ürün eklenemez. ve 
        //IResult result = BusinessRules.Run(CheckIfProductNameExists(product.ProductName),
        //    CheckIfProductCountOfCategoryCorrect(product.CategoryId), CheckIfCategoryLimitExceded());

        //    if (result != null)
        //    {
        //        return result;
        //    }
        //managerde yazılır!
        //İş kurallarını yazmak için yazdık.
    public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
