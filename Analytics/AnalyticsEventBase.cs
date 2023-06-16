using System.Collections.Generic;

namespace RLS.Utils.Analytics
{
    public class AnalyticsEventBase
    {
        public Dictionary<string,string> EventParameters {  get; private set; }

        public void AddParameter(string key, string value)
        {
            EventParameters.Add(key, value);
        }
    }
}

