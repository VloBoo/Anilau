using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraControl : MonoBehaviour
{
    void Update()
    {
        float scrollFactor = Input.GetAxis("Mouse ScrollWheel");
        if (scrollFactor != 0)
        {
            Debug.Log("Scrolling");
            Camera camera = GetComponent<Camera>();
            camera.orthographicSize = camera.orthographicSize * (1f - scrollFactor);// Изменяем дальность камеры при помощи вращения мастшаба сферы

            // Ограничиваем макс и мин дальность камеры
            if (camera.orthographicSize < 1)
            {
                camera.orthographicSize = 1;
            }
            if (camera.orthographicSize > 5)
            {
                camera.orthographicSize = 5;
            }
        }
    }

}
