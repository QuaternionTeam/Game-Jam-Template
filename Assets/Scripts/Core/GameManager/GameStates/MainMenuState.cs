using UnityEngine;

public class MainMenuState : GameState
{
  public override void OnEnter()
  {
    Time.timeScale = 1f;
    InputManager.Instance.SwitchMap("UI");

    //GameManager.Instance.mainMenuUI.SetActive(true);
  }

  public override void OnExit()
  {
    
  }

  public override void Update(float deltaTime) { }
}
