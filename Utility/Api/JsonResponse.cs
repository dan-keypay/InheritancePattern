using System.Collections.Generic;

namespace Utility.Api
{
    public class JsonResponse
    {
        public string status { get; set; }
        public Dictionary<string, string> errors { get; set; }
        public string message { get; set; }
    }
}