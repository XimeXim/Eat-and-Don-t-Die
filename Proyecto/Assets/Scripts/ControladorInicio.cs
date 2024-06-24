using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ControladorInicio : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoPlayer videoPlayer;

    private void Start()
    {
        videoPlayer.loopPointReached += EndReached;
        AudioManager.instance.PlayMenuMusic();
    }

    void EndReached(VideoPlayer vp)
    {
        FindObjectOfType<ChangeScene>().MoveToScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
