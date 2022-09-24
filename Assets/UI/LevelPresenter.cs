using TMPro;
using UnityEngine;

namespace Sortitems
{
    public class LevelPresenter : LevelScriptableModelProvider
    {
        [SerializeField] protected TMP_Text _levelText;

        public TMP_Text LevelText => _levelText;

        private int _levelNumber => LevelScriptableModel.Model.LevelNumber + 1;

        protected new void OnEnable() 
        {
            base.OnEnable();
            LevelScriptableModel.OnLoad.AddListener(UpdateLevel);
        }

        protected new void OnDisable() 
        {
            base.OnDisable();
            LevelScriptableModel.OnLoad.RemoveListener(UpdateLevel);    
        }

        public void UpdateLevel()
        {
            LevelText.text = "Level " + _levelNumber.ToString();
        }
    }
}
