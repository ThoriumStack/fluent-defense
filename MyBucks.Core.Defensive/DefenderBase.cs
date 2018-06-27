using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MyBucks.Core.Defensive
{
    public abstract class DefenderBase
    {
        protected string _parameterName;

        private readonly List<string> _messages = new List<string>();

        public DefenderBase(string parameterName)
        {
            _parameterName = parameterName;
        }

        public void Throw()
        {
            if (!_messages.Any())
            {
                return;
            }

            var finalList = GetFinalList();
            
            throw new Exception(string.Join("\n", finalList));
        }

        private List<string> GetFinalList()
        {
            
            var finalList = new List<string>();
            if (!_messages.Any())
            {
                return finalList;
            }
            finalList.Add($"{_parameterName} is invalid.");
            finalList.AddRange(_messages);
            return finalList;
        }

        public bool IsValid => !_messages.Any();

        public List<string> GetErrors()
        {
            var finalList = GetFinalList();
            return finalList;
        }

        protected void AddError(string errorMessage)
        {
            _messages.Add(errorMessage);
        }
    }
}