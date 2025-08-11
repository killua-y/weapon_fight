using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotionManager : Singleton<SlowMotionManager>
{
    public static float slowMoTimeScale = 0.2f;
    public static float slowMoDuration = 0.2f;
    private bool isSlowing = false;


    public void doSlowMotion()
    {
        if(isSlowing)
        {
            return;
        }
        else
        {
            StartCoroutine(DoSlowMotion());
        }    
    }


    IEnumerator DoSlowMotion()
    {
        isSlowing = true;
        Time.timeScale = slowMoTimeScale;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;

        yield return new WaitForSecondsRealtime(slowMoDuration);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f;
        isSlowing = false;
    }
}
