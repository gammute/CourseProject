using UnityEngine;
using UnityEngine.Events;

namespace Sortitems
{
    public class PlayerScriptableModelProvider : MonoBehaviour
    {
        [SerializeField] protected PlayerScriptableModel _playerScriptableModel;

        public UnityEvent OnModelChange = new UnityEvent();

        public PlayerScriptableModel PlayerScriptableModel => _playerScriptableModel;

        protected void OnEnable() 
        {
            PlayerScriptableModel.OnLoad.AddListener(OnLoadDelegate);
            PlayerScriptableModel.Model.OnChange.AddListener(OnModelChangeDelegate);    
        }

        protected void OnDisable() 
        {
            PlayerScriptableModel.OnLoad.RemoveListener(OnLoadDelegate);
            PlayerScriptableModel.Model.OnChange.RemoveListener(OnModelChangeDelegate);   
        }

        public void IncreaseScore(int value)
        {
            _playerScriptableModel.AddScore(value);
        }

        public void Load()
        {
            PlayerScriptableModel.Load();
            PlayerScriptableModel.Model.OnChange.AddListener(OnModelChangeDelegate);
        }

        public void Save()
        {
            PlayerScriptableModel.Save();
        }

        protected void OnModelChangeDelegate()
        {
            OnModelChange.Invoke();
        }

        public void OnLoadDelegate()
        {
            PlayerScriptableModel.Model.OnChange.AddListener(OnModelChangeDelegate);
        }
    }
}
