using System;
using System.ComponentModel;
using System.Numerics;

namespace Lab
{
    abstract class V3Data : INotifyPropertyChanged
    {
        string info;
        DateTime time;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Info 
        {
            get => info;
            set
            {
                info = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Info => " + info));
            }
        }

        public DateTime Time 
        {
            get => time;
            set
            {
                time = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Time => " + time));
            }
        }

        public V3Data() { }

        public V3Data(string _info, DateTime _time)
        {
            info = _info;
            time = _time;
        }

        public abstract Vector2[] Nearest(Vector2 v);
        public abstract string ToLongString();
        public abstract string ToLongString(string format);

        public override string ToString()
        {
            return Time + ": " + Info;
        }
    }
}
