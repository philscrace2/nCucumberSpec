using System.Collections.Generic;

namespace nCucumberSpec
{
    public class Transition
    {
        public List<Condition> Preconditions { get; set; }
        public List<Action> Actions { get; set; }
        public List<Condition> Postconditions { get; set; }

        public Transition(List<Condition> preconditions, List<Action> actions, List<Condition> postconditions)
        {
            Preconditions = preconditions;
            Actions = actions;
            Postconditions = postconditions;
        }
    }

}
