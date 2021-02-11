using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_DevynSmith_Section3.Models
{
    public static class TempStorage
    {
        private static List<AddSuggestionResponse> suggestions = new List<AddSuggestionResponse>();

        public static IEnumerable<AddSuggestionResponse> Suggestions => suggestions;

        public static void AddSuggestion(AddSuggestionResponse suggestion)
        {
            suggestions.Add(suggestion);
        }
    }
}
