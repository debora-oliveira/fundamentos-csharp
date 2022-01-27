using System;
using System.Globalization;

namespace EstudandoDatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new DateTime();
            Console.WriteLine(data);
            data = DateTime.Now;
            Console.WriteLine(data);
            data = new DateTime(2021, 07, 11, 8, 23, 14);
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Formatando");
            data = DateTime.Now;
            var formatada = String.Format("{0:dd-MM-yyyy}", data);
            Console.WriteLine(formatada);
            formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data);
            Console.WriteLine(formatada);
            formatada = String.Format("{0:T}", data);
            Console.WriteLine(formatada);
            formatada = String.Format("{0:R}", data);
            Console.WriteLine(formatada);
            formatada = String.Format("{0:u}", data);
            Console.WriteLine(formatada);
            formatada = String.Format("{0:s}", data);
            Console.WriteLine(formatada);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Adicionando valores");
            data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.AddDays(10));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddYears(1));
            Console.WriteLine(data.AddDays(-10));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Comparando datas");
            if (data.Date == DateTime.Now.Date)
                Console.WriteLine("datas iguais");
            if (data == DateTime.Now)
            {
                Console.WriteLine("são iguais");
            }
            else
            {
                Console.WriteLine("nunca vão ser iguais, porque compara toda estrutura inclusive frações de segundos");
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("CultureInfo");
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var us = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            Console.WriteLine(DateTime.Now.ToString("D", us));
            Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(DateTime.Now.ToString("D", br));
            Console.WriteLine(DateTime.Now.ToString("D", de));
            Console.WriteLine("---------------------------");
            Console.WriteLine("time zone");
            var utcDate = DateTime.UtcNow;
            Console.WriteLine(utcDate);
            Console.WriteLine(utcDate.ToLocalTime());

            var timezoneAutralia =
            TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAutralia);

            var horaAustralia =
            TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAutralia);
            Console.WriteLine(horaAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("-----------");
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("timespan");
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            Console.WriteLine("---------------------------");
            Console.WriteLine(DateTime.DaysInMonth(2022,2));
        }
    }
}