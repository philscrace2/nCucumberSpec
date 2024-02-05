using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nCucumberSpec.Core
{
    public class ModelBuilder
    {
        private bool hasMoreScenarioTokens;
        private readonly string gherkinTokens;

        public ModelBuilder(string gherkinTokens)
        {
            this.gherkinTokens = gherkinTokens;
        }

        public Scenario NextScenario()
        {
            return new CucumberSpecScenario();     
        }

        public bool hasMoreTokens
        {
            get{ return hasMoreScenarioTokens; }
        }

        private void BreakTokensIntoCucumberSpecScenarios()
        { 
            
            
        }
    }
}
