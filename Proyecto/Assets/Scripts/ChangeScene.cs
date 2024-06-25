using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update

    public void MoveToScene(int sceneID){
        SceneManager.LoadScene(sceneID);  
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadMainMenuScene()
    {
        MoveToScene(1);
    }

    public void BackToMainMenuScene()
    {
        MoveToScene(1);
        AudioManager.instance.PlayMenuMusic();

    }
    public void LoadStatsScene()
    {
        MoveToScene(2);
    }

    public void LoadGameScene()
    {
        
        SceneManager.LoadScene(3);
        AudioManager.instance.PlayGameMusic();
    }


}
