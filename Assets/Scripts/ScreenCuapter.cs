using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCuapter : MonoBehaviour
{
    // Start is called before the first frame update

    void OnGUI()
    {
        GUILayout.Label("当前场景名称为：" + Application.loadedLevelName);
        if (GUILayout.Button("jietu"))
        {
            ScreenCapture.CaptureScreenshot("name.png");// 截game窗口全屏 //
        }

    }

}
