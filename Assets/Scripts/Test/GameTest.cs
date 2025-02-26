using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR
public class GameTest : Singleton<GameTest>
{
    public float timeScale = 1f;
    public void Test()
    {
        Time.timeScale = timeScale; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.T))
        {
            Selection.activeObject = this;
        }

        if(Input.GetKey(KeyCode.T))
        {
            Test();
        }

        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKey(KeyCode.Q))
        {
            TakeScreenshot();
        }
    }
    public void TakeScreenshot()
    {
        string folderPath = "Assets/Screenshots/"; 

        if (!System.IO.Directory.Exists(folderPath))
        {
            System.IO.Directory.CreateDirectory(folderPath);
        }

        var screenshotName = "Screenshot_" + System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".png"; 
        ScreenCapture.CaptureScreenshot(System.IO.Path.Combine(folderPath, screenshotName)); 
        Debug.Log("Screenshot saved to: " + folderPath + screenshotName);
    }
}
#endif
