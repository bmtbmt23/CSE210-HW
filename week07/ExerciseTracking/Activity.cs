using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private string _date;
        private int _minutes;
        public Activity(string date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }
        
        public string GetDate() => _date;
        public int GetMinutes() => _minutes;
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();
        
        public string GetSummary()
        {
             return $"{_date} {GetType().Name} ({_minutes} min): ";
        }
    }

}