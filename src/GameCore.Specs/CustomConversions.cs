using System;
using TechTalk.SpecFlow;

namespace GameCore.Specs
{
    [Binding]
    class CustomConversions
    {
        [StepArgumentTransformation(@"(\d+) days ago")]
        public DateTime DaysAgoTransformation(int daysAgo)
        {
            return DateTime
                        .UtcNow
                        .Subtract(TimeSpan.FromDays(daysAgo));
        }
    }
}
