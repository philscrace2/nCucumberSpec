using System.Collections.Generic;

namespace nCucumberSpec
{
    public class Model
    {
        public List<State> States { get; set; } = new List<State>();
        public List<Transition> Transitions { get; set; } = new List<Transition>();

        public void AddStateIfNew(State state)
        {
            if (!States.Contains(state))
                States.Add(state);
        }

        public void CheckIfStarting(State state)
        {
            // Implement based on Convention 2
        }

        public void AddTransition(State origin, State target, Transition transition)
        {
            // Add transition logic here
        }
    }

}
