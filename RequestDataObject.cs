using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDMatchmakingTracker {
    class RequestDataObject {
        string[] AdditionalUserIds { get; set; }
        string Category { get; set; }
        bool CheckOnly { get; set; }
        int CountA { get; set; }
        int CountB { get; set; }
        Region[] Latencies { get; set; }
        string Platform { get; set; }
        Dictionary<string, string> Props { get; set; }
        int Rank { get; set; }
        string Region { get; set; }
        string Side { get; set; }
    }
}
