using System.Collections.Generic;

namespace RLS.Utils.Analytics
{
    public class AnalyticsManager
    {
        private List<IAnalyticsDecorator> _analyticsDecorators = new();

        public void RegisterDecorator(IAnalyticsDecorator decorator)
        {
            if (!_analyticsDecorators.Contains(decorator)){
                _analyticsDecorators.Add(decorator);
            }
        }

        public void SendEvent(AnalyticsEventBase newEvent)
        {
            foreach (IAnalyticsDecorator decorator in _analyticsDecorators)
            {
                decorator.SendEvent(newEvent);
            }
        }
    }
}

