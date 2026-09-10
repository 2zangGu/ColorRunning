using TMPro;
using UnityEngine;

public class CameraOrtho : MonoBehaviour
{

    private void Awake()
    {
        float screenAspectRatio = (float)Screen.width / Screen.height;
        float orthorgraphicSize = (float)(6- (screenAspectRatio - 0.485f) * 11f);
        if(orthorgraphicSize < 4)
        {
            orthorgraphicSize = 4;
        }

        Camera.main.orthographicSize = orthorgraphicSize;
    }
}
