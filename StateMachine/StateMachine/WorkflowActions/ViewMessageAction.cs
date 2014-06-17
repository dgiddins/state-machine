﻿using StateMachine.Framework;

namespace StateMachine.WorkflowActions
{
    public class ViewMessageAction : StateAction
    {
        private readonly MessageWorkflowState _state;

        public ViewMessageAction(MessageWorkflowState state)
        {
            _state = state;
        }
        
        public string GetMessage()
        {
            return _state.CurrentMessage;
        }
    }
}