using System.Collections.Generic;

namespace nCucumberSpec
{
    public abstract class TestScenario
    {
        public abstract State ExtractOriginState(); // Implement according to Convention 1
        public abstract State ExtractTargetState(); // Implement according to Convention 1
        public abstract List<Condition> ExtractPreconditions(); // Implement according to Convention 3
        public abstract List<Condition> ExtractPostconditions(); // Implement according to Convention 3
        public abstract List<Action> ExtractActions(); // Implement extraction logic here
    }

}
