using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnniesPastryShop.Infrastructure.Constants
{
    public static class DataConstants
    {
        public const int ProductNameMinLength = 2;
        public const int ProductNameMaxLength = 50;

        public const int ProductDescriptionMinLength = 10;
        public const int ProductDescriptionMaxLength = 500;

        public const double PriceMinValue = 0.0;
        public const double PriceMaxValue = double.MaxValue;

        public const int CategoryNameMinLength = 3;
        public const int CategoryNameMaxLength = 50;

        public const int ReviewCommentMinLength = 10;
        public const int ReviewCommentMaxLength = 500;

        public const int ReviewRatingMinValue = 1;
        public const int ReviewRatingMaxValue = 5;

        public const int CartItemQuantityMinValue = 1;
        public const int CartItemQuantityMaxValue = int.MaxValue;

        public const double CartItemTotalPriceMinValue = 0.01;
        public const double CartItemTotalPriceMaxValue = double.MaxValue;

        public const string DateFormat = "yyyy/MM/dd H:mm";

        public const string RequireErrorMessage = "The field {0} is required";
        public const string StringLengthErrorMessage = "The field {0} must be between {2} and {1} charavters long";
        public const string UrlFormatErrorMessage = "The field {0} must be a valid URL";
        public const string RangeErrorMessage = "The field {0} must be between {1} and {2}";
    }
}
