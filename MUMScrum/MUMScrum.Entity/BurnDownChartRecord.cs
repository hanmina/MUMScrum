using System;

namespace MUMScrum.Entity
{
    public class BurndownChartRecord
    {
        public DateTime Date { get; set; }
        public int ActualWork { get; set; }
        public int EstimateWork { get; set; }
        public int RemainingWork
        {
            get
            {
                return EstimateWork - ActualWork;
            }
        }
    }
}
