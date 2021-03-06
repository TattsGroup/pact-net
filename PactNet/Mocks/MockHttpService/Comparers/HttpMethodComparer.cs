using System;
using PactNet.Comparers;
using PactNet.Mocks.MockHttpService.Models;

namespace PactNet.Mocks.MockHttpService.Comparers
{
    public class HttpMethodComparer : IHttpMethodComparer
    {
        private readonly string _messagePrefix;

        public HttpMethodComparer(string messagePrefix)
        {
            _messagePrefix = messagePrefix;
        }

        public ComparisonResult Compare(HttpVerb expected, HttpVerb actual)
        {
            var result = new ComparisonResult();

            result.AddInfo(String.Format("{0} has method set to {1}", _messagePrefix, expected));
            if (!expected.Equals(actual))
            {
                result.AddError(expected: expected, actual: actual);
                return result;
            }

            return result;
        }
    }
}