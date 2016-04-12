using UnityEngine;
using System.Collections;

public class PauseController : MonoBehaviour
{

    public static bool pause;

    public KeyCode pauseKey;

    // Use this for initialization
    void Start()
    {
        pause = false;
		//pauseKey = pauseKey != null ? pauseKey : KeyCode.Escape;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(pauseKey))
        {
            Debug.Log("game stop key is pressed");
            pause = !pause;
        }

        if (pause)
        {
			Time.timeScale = 0;
        }
        else if (!pause)
        {
			Time.timeScale = 1;
        }

    }
}
