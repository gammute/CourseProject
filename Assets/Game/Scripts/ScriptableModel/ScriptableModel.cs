using System;
using System.IO;
using UnityEngine;
using UnityEngine.Events;

namespace Sortitems
{
    public class ScriptableModel<TModel> : ScriptableObject, IStorable where TModel : Model, new()
    {
        [SerializeField] protected TModel _model;

        public UnityEvent OnLoad;
        public UnityEvent OnSave;

        public TModel Model
        {
            get => _model;
            set
            {
                _model = value;
            }
        }

        protected static string GetStoragePath(string name)
        {
            return Application.persistentDataPath + Path.DirectorySeparatorChar + name + ".json";
        }

        public bool Load()
        {
            if (File.Exists(GetStoragePath(name)) == false)
            {
                Debug.Log($"File {GetStoragePath(name)} Not Exist");

                return false;
            }

            TModel model = new TModel();
            string text = File.ReadAllText(GetStoragePath(name));
            JsonUtility.FromJsonOverwrite(text, model);

            Model.OnChange.RemoveAllListeners();

            Model = model;

            OnLoad.Invoke();

            return true;
        }

        public bool Save()
        {
            try
            {
                string text = JsonUtility.ToJson(Model);
                File.WriteAllText(GetStoragePath(name), text);
            }
            catch (Exception e)
            {
                Debug.Log(e);
                return false;
            }

            OnSave.Invoke();

            return true;
        }
    }
}
