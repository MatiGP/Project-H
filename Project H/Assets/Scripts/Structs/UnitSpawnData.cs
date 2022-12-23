namespace Structs
{
    public struct UnitSpawnData
    {
        private string _unitName;
        private int _unitCount;

        public string UnitName => _unitName;
        public int UnitCount => _unitCount;

        public UnitSpawnData(string unitName, int unitCount)
        {
            _unitName = unitName;
            _unitCount = unitCount;
        }
    }
}
