using System;
using System.Collections.Generic;
using System.Linq;


namespace CodeKatas.TwoSum
{
    public class TwoSum
    {
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            //Tuple<int, int> returnValue = null;
            //for (var firstIndex = 0; firstIndex < list.Count; firstIndex++)
            //{
            //    if (firstIndex <= 0) continue;
            //    var listItem = list[firstIndex];
            //    for (var secondIndex = 0; secondIndex < list.Count; secondIndex++)
            //    {
            //        var item = list[secondIndex];
            //        if (listItem + item != sum) continue;
            //        returnValue = new Tuple<int, int>(secondIndex, firstIndex);
            //        break;
            //    }
            //}
            //return returnValue;

            var result = from n1 in list
                from n2 in list
                where n1 + n2 == sum
                select new Tuple<int, int>(list.IndexOf(n1), list.IndexOf(n2));

            return result.FirstOrDefault();

        }

    }
}
    