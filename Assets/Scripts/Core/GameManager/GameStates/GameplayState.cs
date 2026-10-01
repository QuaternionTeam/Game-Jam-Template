using UnityEngine;

public class GameplayState : GameState
{
  public override void OnEnter()
  {
    Time.timeScale = 1f;
    InputManager.Instance.SwitchMap("Player");

    /* Suscripciones */
    GameEvents.OnPauseRequested += PauseGame;
  }

  public override void OnExit()
  {
    /* Desuscripciones */
    GameEvents.OnPauseRequested -= PauseGame;
  }

  public override void Update(float deltaTime) { }

  private void PauseGame()
  {
    Transition<PauseState>();
  }
}
