using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    public class SchlaegeZaehlenSteps
    {
        private readonly TrackerDriver _driver;

        public SchlaegeZaehlenSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [Then(@"z�hlt.* (\d+) (.*)\.")]
        public void PruefeSchlagzahl(int schlagzahl, string schlagnomen)
        {
            _driver.AssertThatAntwortContains("{0} {1}", schlagzahl, schlagnomen);
        }
    }
}