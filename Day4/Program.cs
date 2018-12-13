using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode4
{
    class Program
    {
        const string RX_GUARD = @"\[(?<date>\d+-\d+-\d+ \d+:\d+)\] Guard #(?<id>\d+).+";
        const string RX_SLEEP = @"\[(?<date>\d+-\d+-\d+ \d+:\d+)\] falls asleep";
        static void Main(string[] args)
        {

            string[] v = System.IO.File.ReadAllLines(@"dataset.txt");
            Dictionary<int, Guard > guardList = new Dictionary<int, Guard>();

            Guard currentGuard = new Guard();
            Regex guardRegex = new Regex(RX_GUARD);
            Regex sleepRegex = new Regex(RX_SLEEP);

            foreach (string log in v)
            {
                string id = RxGetValue(log, "id", guardRegex);

                if (id != "" && !guardList.Keys.Contains(int.Parse (id)))
                {
                    // guard id found which is not in list --> add
                    currentGuard = new Guard();
                    currentGuard.id = int.Parse(id);
                    guardList.Add(currentGuard.id, currentGuard);
                }

                string time = RxGetValue(log, "date", guardRegex);


            }
        }

        static string RxGetValue(string text, string label, Regex regex)
        {
            string val = "";

            Match m = regex.Match(text);

            if (!m.Success) return "";
            val = m.Groups[label].Value;

            return val;
        }


    }

    class Guard
    {
        public int id;
        public TimeSpan asleep = new TimeSpan();
        public static List<TimeSpan> sleepList = new List<TimeSpan>();
    }
}
