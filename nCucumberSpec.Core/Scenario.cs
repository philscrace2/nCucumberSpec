using System.Collections.Generic;

namespace nCucumberSpec
{
    public abstract class Scenario
    {
        public abstract State ExtractOriginState(); // Implement according to Convention 1
        public abstract State ExtractTargetState(); // Implement according to Convention 1
        public abstract List<Condition> ExtractPreconditions(); // Implement according to Convention 3
        public abstract List<Condition> ExtractPostconditions(); // Implement according to Convention 3
        public abstract List<Action> ExtractActions(); // Implement extraction logic here
    }

    public class CucumberSpecScenario : Scenario
    {
        public override List<Action> ExtractActions()
        {
            throw new NotImplementedException();
        }

        public override State ExtractOriginState()
        {
            throw new NotImplementedException();
        }

        public override List<Condition> ExtractPostconditions()
        {
            throw new NotImplementedException();
        }

        public override List<Condition> ExtractPreconditions()
        {
            throw new NotImplementedException();
        }

        public override State ExtractTargetState()
        {
            throw new NotImplementedException();
        }
    }
}
