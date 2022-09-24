using UnityEngine;

namespace Sortitems
{
    [CreateAssetMenu(fileName = "LevelScriptableModel", menuName = "Create LevelScriptableModel", order = 2)]
    public class LevelScriptableModel : ScriptableModel<LevelModel>
    {
       public bool NextLevel(int value)
       {
            if(Model.LevelNumber + value < 0 )
            {
                return false;
            }

            Model.LevelNumber += value;

            return true;
       }
       public bool UpdateLevel(int value)
       {
            if(Model.LevelNumber + value < 0 )
            {
                return false;
            }

            Model.LevelNumber = value;

            return true;
       }
    }
}
