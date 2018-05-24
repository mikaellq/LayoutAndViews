using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LayoutAndViews.Models
{
    public static class NumberCheck
    {
        public static string CheckNumber(double input)
        {
            string result = "";

            if (input > 10)
            {
                result = "Number is larger than 10";
            }
            else if (input == 10)
            {
                result = "Number is exactly 10";
            }
            else
                result = "Number is smaller than 10";

            return result;
        }
    }
}