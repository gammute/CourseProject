using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Sortitems
{
    public class LevelScriptableModelProvider : MonoBehaviour
    {
       [SerializeField] protected LevelScriptableModel _levelScriptableModel;

       [SerializeField] private List<GameObject> Levels;

       public UnityEvent OnLevelChange = new UnityEvent();

       public LevelScriptableModel LevelScriptableModel => _levelScriptableModel;

       private int _thisLevel;

       protected void OnEnable() 
       {
            LevelScriptableModel.OnLoad.AddListener(OnLoadDelegate);
            LevelScriptableModel.Model.OnChange.AddListener(OnModelChangeDelegate);
       }

       protected void OnDisable() 
       {
            LevelScriptableModel.OnLoad.RemoveListener(OnLoadDelegate);
            LevelScriptableModel.Model.OnChange.RemoveListener(OnModelChangeDelegate);
       }

       public void NextLevelNumber(int value)
       {
         _levelScriptableModel.NextLevel(value);
       }
       public void UpdateLevelNumber(int value)
       {
         _levelScriptableModel.UpdateLevel(value);
       }
       public void ChangeLevelTo()
       {
        _thisLevel = LevelScriptableModel.Model.LevelNumber;
        Instantiate(Levels[_thisLevel]);
       }
       public void Load()
        {
            LevelScriptableModel.Load();
            LevelScriptableModel.Model.OnChange.AddListener(OnModelChangeDelegate);
        }
        public void Save()
        {
            LevelScriptableModel.Save();
        }
       protected void OnModelChangeDelegate()
        {
            OnLevelChange.Invoke();
        }
        public void OnLoadDelegate()
        {
            LevelScriptableModel.Model.OnChange.AddListener(OnModelChangeDelegate);
        }
    }
}
