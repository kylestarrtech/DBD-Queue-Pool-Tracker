using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDMatchmakingTracker {
    public class Region {
        int latency { get; set; }
        string regionName { get; set; }

        public Region(int _lat, string _reg) {
            this.latency = _lat;
            this.regionName = _reg;
        }

        public int GetLatency() { return latency; }
        public void SetLatency(int _latency) { latency = _latency; }

        public string GetRegionName() { return regionName; }
    }

    public class RegionList {
        List<Region> regions { get; set; }
        bool specificRegion; //If false, consider *all* regions.
        int regionIndex; //If specificRegion is true, then what is the index of the region choice?

        public RegionList(List<Region> _regions, bool _specificRegion, int _regionIndex) {
            regions = _regions;
            specificRegion = _specificRegion;
            regionIndex = _regionIndex;
        }

        public Region GetRegion(int index) {
            return regions[index];
        }

        public List<Region> GetRegionList() {
            return regions;
        }

        public void SetRegionLatency(int index, int _latency) {
            regions[index].SetLatency(_latency);
        }

        public bool GetRegionPreference() { return specificRegion; }
        public void SetRegionPreference(bool _specificRegion) { specificRegion = _specificRegion; }

        public int GetSelectedRegion() { return regionIndex; }
        public void SetSelectedRegion(int _regionIndex) { regionIndex = _regionIndex; }
    }
}
