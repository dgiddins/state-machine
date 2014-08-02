using System.Collections.Generic;
using StateMachine.ExampleWorkflows.WorkflowStates;
using StateMachine.Framework;

namespace StateMachinesTests
{
    public class TwoFactorLoginWorkflow : Workflow
    {
        public TwoFactorLoginWorkflow() : base(null)
        {
        }

        public override List<TransitionRule> TransitionRules
        {
            get { throw new System.NotImplementedException(); }
        }

        public override WorkflowState StartingState
        {
            get { return new LoggedOutState(this); }
        }
    }

    public class ThreeFactorLoginWorkflow : Workflow
    {
        public ThreeFactorLoginWorkflow() : base(null)
        {
        }

        public override List<TransitionRule> TransitionRules
        {
            get { throw new System.NotImplementedException(); }
        }

        public override WorkflowState StartingState
        {
            get { return new LoggedOutState(this); }
        }
    }

    public class TwoFactorLoginAction : WorkflowAction
    {
    }

    public class ThreeFactorLoginAction : WorkflowAction
    { }
}