using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSDevConferenceApp.Models
{
    public static class Repository
    {
        private static List<WebminarInvite> responses = new List<WebminarInvite>();

        public static IEnumerable<WebminarInvite> Responses => responses;

        public static void AddResponse(WebminarInvite response)
        {
            responses.Add(response);
        }
    }
}
