using System.Collections.Generic;

namespace SongCore.OverrideClasses
{
    public class SongCoreBeatmapLevelPackCollectionSO : BeatmapLevelPackCollectionSO
    {
        private readonly List<CustomBeatmapLevelPack> _customBeatmapLevelPacks = new List<CustomBeatmapLevelPack>();

        public static SongCoreBeatmapLevelPackCollectionSO CreateNew()
        {
            var newCollection = CreateInstance<SongCoreBeatmapLevelPackCollectionSO>();

            newCollection._allBeatmapLevelPacks = new IBeatmapLevelPack[]
            {
            };


            newCollection.UpdateArray();
            return newCollection;
        }

        public void AddLevelPack(CustomBeatmapLevelPack pack)
        {
            if (pack != null && !_customBeatmapLevelPacks.Contains(pack))
            {
                _customBeatmapLevelPacks.Add(pack);
                UpdateArray();
            }
        }

        public void RemoveLevelPack(CustomBeatmapLevelPack pack)
        {
            if (pack != null && _customBeatmapLevelPacks.Contains(pack))
            {
                _customBeatmapLevelPacks.Remove(pack);
                UpdateArray();
            }
        }

        public void ClearLevelPacks()
        {
            _customBeatmapLevelPacks.Clear();
        }

        private void UpdateArray()
        {
            _allBeatmapLevelPacks = _customBeatmapLevelPacks.ToArray();
        }
    }
}