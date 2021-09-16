using System;
using System.Globalization;
using TimeZoneConverter;

namespace TicoGrafica.Model.Extensoes
{
    public static class DateTimeExtension
    {
        public static DateTime DataTimeZoneCorreto(this DateTime date)
        {
            TimeZoneInfo tzi = TZConvert.GetTimeZoneInfo("America/Sao_Paulo");
            return TimeZoneInfo.ConvertTime(date, tzi);
        }

        public static DateTime DataTimeZoneECultureCorreto(this DateTime date)
        {
            CultureInfo idioma = new CultureInfo("pt-BR");
            DateTime dt = DateTime.Parse(date.ToString(), idioma);
            TimeZoneInfo tzi = TZConvert.GetTimeZoneInfo("America/Sao_Paulo");
            return TimeZoneInfo.ConvertTime(dt, tzi);
        }
    }
}
