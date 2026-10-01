using UnityEngine;

public class PauseState : GameState
{
  public override void OnEnter()
  {
    Time.timeScale = 0f;
    GameManager.Instance.pauseUI.SetActive(true);
    InputManager.Instance.SwitchMap("UI");

    /* Suscripciones */
    GameEvents.OnResumeRequested += ResumeGame;
  }

  public override void OnExit()
  {
    Time.timeScale = 1f;
    GameManager.Instance.pauseUI.SetActive(false);

    /* Desuscripciones */
    GameEvents.OnResumeRequested -= ResumeGame;
  }

  public override void Update(float deltaTime) { }

  private void ResumeGame()
  {
    Transition<GameplayState>();
  }
}
