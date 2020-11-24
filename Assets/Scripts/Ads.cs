using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class Ads : MonoBehaviour
{
    private string storeID = "3504456";
    private string videoID = "video";

    private float adTime = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(storeID, false); //loads real ads if false and a fake ad placement if true
        Invoke("ADPlay", adTime); //calls the method when the time specified is reached
    }

    private void ADPlay()
    {
        if (Advertisement.IsReady(videoID)) //checks if the video is ready to be played
        {
            Advertisement.Show(videoID); //if it is ready play the video
        }
    }
}
