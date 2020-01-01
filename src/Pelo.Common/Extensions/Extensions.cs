using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Pelo.Common.Attributes;

namespace Pelo.Common.Extensions
{
    public static class Extensions
    {
        /// <summary>
        ///     Will get the string value for a given enums value, this will
        ///     only work if you assign the StringValue attribute to
        ///     the items in your enum.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetStringValue(this Enum value)
        {
            // Get the type
            Type type = value.GetType();

            // Get fieldinfo for this type
            FieldInfo fieldInfo = type.GetField(value.ToString());

            // Get the stringvalue attributes
            StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(typeof(StringValueAttribute),
                                                                           false) as StringValueAttribute[];

            // Return the first if there was a match.
            return attribs == null ? string.Empty :
                   attribs.Length > 0 ? attribs[0]
                           .StringValue : string.Empty;
        }

        public static string ToJson(this object input)
        {
            if (input == null)
            {
                return string.Empty;
            }

            return JsonConvert.SerializeObject(input);
        }

        public static T ToObject<T>(this string input)
        {
            return JsonConvert.DeserializeObject<T>(input);
        }

        public static int ToIntEx(this string input,
                                  int defaultValue = 0)
        {
            try
            {
                int.TryParse(input,
                             out defaultValue);
            }
            catch (Exception exception)
            {
                //
            }

            return defaultValue;
        }

        public static TModel GetOptions<TModel>(this IConfiguration configuration,
                                                string section)
                where TModel : new()
        {
            var model = new TModel();
            configuration.GetSection(section)
                         .Bind(model);

            return model;
        }

        public static string ToColumnName(this string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }

            var arr = name.Split('_');
            return string.Join("",
                               arr.Select(c => c.ToFirstCharUpper()));
        }

        public static string ToFirstCharUpper(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }

        public static string ToUnsign(this string text)
        {
            for (int i = 32; i < 48; i++)
            {
                text = text.Replace(((char)i) + string.Empty,
                                    " ");
            }

            text = text.Replace(".",
                                " ");
            text = text.Replace(" ",
                                " ");
            text = text.Replace(",",
                                " ");
            text = text.Replace(";",
                                " ");
            text = text.Replace(":",
                                " ");
            text = text.Replace("  ",
                                " ");
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string strFormD = text.Normalize(NormalizationForm.FormD);
            return regex.Replace(strFormD,
                                 string.Empty)
                        .Replace('\u0111',
                                 'd')
                        .Replace('\u0110',
                                 'D');
        }

        public static bool IsEqualsEx(this string input,
                                      string compare)
        {
            return string.Equals(input.ToUnsign(),
                                 compare.ToUnsign(),
                                 StringComparison.CurrentCultureIgnoreCase);
        }

        public static List<string> RemoveEmptyObject(this List<string> input)
        {
            return input?.Where(c => !string.IsNullOrEmpty(c))
                        .ToList();
        }

        public static bool IsContainsEx(this string input,
                                        string compare)
        {
            if (string.IsNullOrEmpty(compare))
            {
                return true;
            }

            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            return input.ToUpper()
                        .ToUnsign()
                        .Contains(compare.ToUpper()
                                         .ToUnsign());
        }

        public static List<T> OrderByEx<T>(this IEnumerable<T> source,
                                           string property = "Id",
                                           string sortDir = "ASC")
        {
            if (string.IsNullOrEmpty(sortDir))
            {
                sortDir = "ASC";
            }

            if (string.IsNullOrEmpty(property))
            {
                property = "Id";
            }

            if (sortDir.ToUpper() != "ASC"
               && sortDir.ToUpper() != "DESC")
            {
                sortDir = "ASC";
            }

            if (sortDir.ToUpper() == "ASC")
            {
                return source.OrderBy(c => c.GetType()
                                            .GetProperty(property)
                                            ?.GetValue(c,
                                                       null))
                             .ToList();
            }

            if (sortDir.ToUpper() == "DESC")
            {
                return source.OrderByDescending(c => c.GetType()
                                                      .GetProperty(property)
                                                      ?.GetValue(c,
                                                                 null))
                             .ToList();
            }

            return source.ToList();
        }

        public static string ToMoneyFormat(this object obj)
        {
            return $"{obj:#,##0}";
        }
    }
}