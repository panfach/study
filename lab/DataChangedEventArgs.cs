

namespace Lab
{
    public delegate void DataChangedEventHandler(object source, DataChangedEventArgs args);


    public class DataChangedEventArgs
    {
        public ChangeInfo Type { get; set; }
        public string Info { get; set; }

        public DataChangedEventArgs(ChangeInfo type, string info)
        {
            Type = type;
            Info = info;
        }

        public override string ToString()
        {
            return Info;
        }
    }


    public enum ChangeInfo
    {
        CHANGED,
        ADD,
        REMOVE,
        REPLACE
    }
}
