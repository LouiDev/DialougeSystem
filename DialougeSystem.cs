using System;
using System.Collections.Generic;

namespace LSPDFRCallout
{
    class DialougeSystem
    {
        private readonly String[] messages;
        private readonly Dictionary<int, Action> indexActions;

        private int index;

        public DialougeSystem(String[] messages)
        {
            this.messages = messages;

            index = -1;
        }

        public void Progress()
        {
            if (!HasFinished())
            {
                index++;
            }

            if (indexActions.TryGetValue(index, out Action action))
            {
                action.Invoke();
            }
        }

        public void AddActionToIndex(int x, Action action)
        {
            indexActions.Add(x, action);
        }

        public void Reset()
        {
            index = -1;
        }

        public String GetCurrentMessage()
        {
            if (!IsRunning()) return "";
            return messages[index];
        }

        public bool IsRunning()
        {
            return HasStarted() && !HasFinished();
        }

        public bool HasFinished()
        {
            return index >= messages.Length;
        }

        public bool HasStarted()
        {
            return index > -1;
        }
    }
}
