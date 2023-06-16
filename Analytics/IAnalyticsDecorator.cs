namespace RLS.Utils.Analytics
{
    public interface IAnalyticsDecorator
    {
        public void SendEvent(AnalyticsEventBase newEvent);
    }
}


