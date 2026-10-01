using UnityEngine;

public class GameOverState : GameState
{
  public override void OnEnter()
  {
    Time.timeScale = 0f;
    InputManager.Instance.SwitchMap("UI");

    //GameManager.Instance.pauseUI.SetActive(true);
  }

  public override void OnExit()
  {
    Time.timeScale = 1f;
    //GameManager.Instance.pauseUI.SetActive(false);
  }

  public override void Update(float deltaTime) { }
}
