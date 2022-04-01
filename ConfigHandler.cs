using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDMatchmakingTracker {
    public class ConfigHandler {
        public bool FirstLaunch { get; set; }
        public int RegionPreference { get; set; }
        public int PlatformPreference { get; set; }
        public bool SniffAllRegions { get; set; }
        public bool QueueAsSurvivor { get; set; }
        public string LastApplicationVersion { get; set; }

        public ConfigHandler(bool _FirstLaunch, int _RegionPreference, int _PlatformPreference, bool _SniffAllRegions,
            bool _QueueAsSurvivor, string _LastApplicationVersion) {
            FirstLaunch = _FirstLaunch;
            RegionPreference = _RegionPreference;
            PlatformPreference = _PlatformPreference;
            SniffAllRegions = _SniffAllRegions;
            QueueAsSurvivor = _QueueAsSurvivor;
            LastApplicationVersion = _LastApplicationVersion;
        }
    }
}
