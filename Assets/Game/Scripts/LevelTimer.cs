using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Sortitems
{
    public class LevelTimer : LevelScriptableModelProvider
    
    {
       [SerializeField] protected TMP_Text timerText;
       
       public UnityEvent OnTimerEnds;
       private float _timeLeft = 0f;

       private IEnumerator Timer()
       {
            
            while (_timeLeft > 0)
            {
                _timeLeft -= Time.deltaTime;

                if (_timeLeft <= 0)
                {
                    OnTimerEnds.Invoke();
                }

                UpdateTimeText();
                yield return null;
            }
       }

       public void StartTimer() 
       {
            float time = LevelScriptableModel.Model.LevelTime; 
            _timeLeft = time;
            StartCoroutine(Timer()); 
       }

       private void UpdateTimeText()
       {
            if(_timeLeft < 0)
                _timeLeft = 0;

            float seconds = Mathf.FloorToInt(_timeLeft % 60);
            timerText.text = string.Format("{00}", seconds);
       }

       public void StopTimer()
       {
        StopAllCoroutines();
       }
    }
}
