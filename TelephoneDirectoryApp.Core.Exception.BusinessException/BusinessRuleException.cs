using System;
using System.Collections.Generic;
using TelephoneDirectoryApp.Core.Exception.Base;

namespace TelephoneDirectoryApp.Core.Exception.BusinessException
{
    public class BusinessRuleException : BaseException
    {
        public string FullConcatanatedMessage
        {
            get
            {
                string errorMessage = string.Empty;
                foreach (var message in RuleMessages)
                {
                    errorMessage += message + "\n\r";
                }

                return errorMessage;
            }
        }

        public List<string> RuleMessages { get; }

        public BusinessRuleException(string message, List<string> ruleMessages) : base(message)
        {
            RuleMessages = ruleMessages;
        }

        public BusinessRuleException(string message, string ruleMessages) : base(message)
        {
            RuleMessages = new List<string> { ruleMessages };
        }
    }
}
