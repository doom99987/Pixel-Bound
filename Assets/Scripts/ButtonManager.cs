using UnityEngine;

public class ButtonManager : MonoBehaviour
{
  public void goToPlayScene()
  {
    UnityEngine.SceneManagement.SceneManager.LoadScene("PlayScene");
    }   

    public void goToMenuScene()
        {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TitleScene");
    }
}
