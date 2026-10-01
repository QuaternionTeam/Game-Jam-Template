using UnityEngine;

internal class GameManager : MonoBehaviour
{
  internal static GameManager Instance = null;
  private readonly FSM<GameState> _gameFSM = new();

  [SerializeField] internal GameObject pauseUI;

  internal void Awake()
  {
    if (Instance != null)
    {
      Destroy(gameObject);
      return;
    }

    Instance = this;
    transform.parent = null;
    DontDestroyOnLoad(gameObject);
  }

  private void Start()
  {
    LoadGameStates();
  }

  private void LoadGameStates()
  {
    _gameFSM.RegisterState(new MainMenuState());
    _gameFSM.RegisterState(new GameplayState());
    _gameFSM.RegisterState(new PauseState());
    _gameFSM.RegisterState(new GameOverState());

    _gameFSM.ChangeState<GameplayState>();
  }
}
