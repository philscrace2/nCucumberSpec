using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nCucumberSpec
{

    public class Algorithm
    {
        public Model GenerateModel(List<Scenario> scenarios)
        {
            Model model = new Model();

            foreach (var scenario in scenarios)
            {
                State os = scenario.ExtractOriginState();
                State ts = scenario.ExtractTargetState();

                if (os != null && ts != null)
                {
                    model.AddStateIfNew(os);
                    model.CheckIfStarting(os);
                    model.AddStateIfNew(ts);

                    List<Condition> preconditions = scenario.ExtractPreconditions();
                    List<Condition> postconditions = scenario.ExtractPostconditions();
                    List<Action> actions = scenario.ExtractActions();

                    if (actions != null)
                    {
                        Transition transition = new Transition(preconditions, actions, postconditions);
                        model.AddTransition(os, ts, transition);
                    }
                    else
                    {
                        throw new Exception("Unable to extract transition from test scenario");
                    }
                }
                else
                {
                    throw new Exception("Unable to extract states from test scenario");
                }
            }
            return model;
        }
    }

}
