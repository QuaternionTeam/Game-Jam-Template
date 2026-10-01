using System;

public static class GameEvents
{
  /* Eventos globales */
  public static event Action OnPauseRequested;
  public static event Action OnResumeRequested;
  public static event Action OnGameOverRequested;
  public static Action<string> OnPlaySound;
  public static Action<string> OnStopSound;


  /* Métodos para emitir los eventos */
  public static void RequestPause() => OnPauseRequested?.Invoke();
  public static void RequestResume() => OnResumeRequested?.Invoke();
  public static void TriggerGameOver() => OnGameOverRequested?.Invoke();
  public static void TriggerPlaySound(string soundName) => OnPlaySound?.Invoke(soundName);
  public static void TriggerStopSound(string soundName) => OnStopSound?.Invoke(soundName);
}
