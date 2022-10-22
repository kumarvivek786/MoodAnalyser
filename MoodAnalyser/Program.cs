using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodAnalyser;

namespace MoodAnalyser
{
    public class Program
    {
        static void Main(string[] args)
        {

            //UC-1 Given a massage, ability to analyse  and respond happy or sad mood
            Console.WriteLine("Welcome to Mood Analyser");

            MoodAnalyser moodAnalyser = new MoodAnalyser("i am sad");
            Console.WriteLine(moodAnalyser.Analyse());

            Console.ReadLine();
        }
    }
}
