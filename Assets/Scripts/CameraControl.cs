using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraControl : MonoBehaviour
{
    public static float maxZoom = 10;
    public static float minZoom = 1;
    void Update()
    {
        if (Mediator.CameraTarget != null)
        {
            transform.position = new Vector3(Mediator.CameraTarget.position.x, Mediator.CameraTarget.position.y, transform.position.z);
        }
        float scrollFactor = Input.GetAxis("Mouse ScrollWheel");
        if (scrollFactor != 0)
        {
            Camera camera = GetComponent<Camera>();
            camera.orthographicSize = camera.orthographicSize * (1f - scrollFactor);// Изменяем дальность камеры при помощи вращения мастшаба сферы

            // Ограничиваем макс и мин дальность камеры
            if (camera.orthographicSize < minZoom)
            {
                camera.orthographicSize = minZoom;
            }
            if (camera.orthographicSize > maxZoom)
            {
                camera.orthographicSize = maxZoom;
            }
        }
    }

}
