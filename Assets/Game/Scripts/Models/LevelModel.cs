using UnityEngine;

namespace Sortitems
{
    [System.Serializable]
    public class LevelModel : Model
    {
        [SerializeField] protected int _levelNumber;
        [SerializeField] protected float _levelTime;
        
        public int LevelNumber 
        {
            get => _levelNumber;
            set
            {
                if(value < 0)
                {
                    return;
                }
                
                SetData(ref _levelNumber, value);
            }
        }
        public float LevelTime
        {
            get => _levelTime;
            set => SetData(ref _levelTime, value);
        }
    }
}
