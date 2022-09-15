using UnityEngine;

namespace Sortitems
{
    public class ChangeGameStateTo : MonoBehaviour
    {
       [SerializeField] private GameStateMachine _gameStateMachine;
       [SerializeField] private GameState _gameState;

       public GameStateMachine GameStateMachine => _gameStateMachine;

       public void ChangeState()
       {
            GameStateMachine.GameState = _gameState;
       }
    }
}
