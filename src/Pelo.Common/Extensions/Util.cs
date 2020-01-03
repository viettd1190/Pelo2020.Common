using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Extensions
{
    public class Util
    {
        public static List<int> GetArrays(string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                List<int> list = new List<int>();
                string[] arr = data.Split(new[] { ',', ';' });
                foreach (var item in arr)
                {
                    int i = 0;
                    if (!string.IsNullOrEmpty(item) && int.TryParse(item,out i))
                    {
                        list.Add(i);
                    }
                }
            }
            return new List<int>();
        }
    }
}
