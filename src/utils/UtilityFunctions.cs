using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayFormApp.utils
{
    public class UtilityFunctions 
    {
      public static String removeOpenAndClosingQoutationMarks(String stringObject)
        {
            if(stringObject.Length != 0)
            {
                if(stringObject[0] == '"')
                {
                    stringObject = stringObject.Remove(0, 1);
                    if (stringObject[stringObject.Length-1] == '"')
                    {
                        stringObject = stringObject.Remove(stringObject.Length - 1, 1);
                    }
                }
            }
            return stringObject;
        }

        public static String toShortTimeOnlyString(String timeString)
        {
            TimeOnly result;
            if(TimeOnly.TryParse(timeString, out result))
            {
                return result.ToString();
            }

            return timeString;
        }
    }
}
