using UnityEngine;
using UnityEngine.Events;

namespace Sortitems
{
    public class CheckGameStatesIs : MonoBehaviour
    {
        [SerializeField] private GameStateMachine _gameStateMachine;
        [SerializeField] private GameState _gameState;
       
        public UnityEvent ChangeState; 

        public GameStateMachine GameStateMachine => _gameStateMachine;

        public void CheckState()
        {
            if (GameStateMachine.GameState == _gameState)
            {
                ChangeState.Invoke();
            }
        }
    }
}
