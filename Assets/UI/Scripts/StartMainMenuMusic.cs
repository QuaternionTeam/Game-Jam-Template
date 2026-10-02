using UnityEngine;

internal class StartMainMenuMusic : MonoBehaviour
{
  [SerializeField] private string musicName = "Main_Menu_Music";
  
  private void Start()
  {
    GameEvents.TriggerPlaySound(musicName);
  }
}
