using System.Collections.Generic;

namespace Structs
{
    public struct BattleData
    {
        private List<UnitSpawnData> _playerOneArmyUnitData;
        private List<UnitSpawnData> _playerTwoArmyUnitData;

        public BattleData(List<UnitSpawnData> playerOneArmyUnitData, List<UnitSpawnData> playerTwoArmyUnitData)
        {
            _playerOneArmyUnitData = playerOneArmyUnitData;
            _playerTwoArmyUnitData = playerTwoArmyUnitData;
        }
    }
}
