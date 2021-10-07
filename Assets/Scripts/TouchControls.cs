using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
    [SerializeField]
    private float distanceThresh;
    private bool grabbed = false;

    // Update is called once per frame
    void Update()
    {
        if (PlayButton.playing) return;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;

            if (!grabbed)
            {
                float distance = Vector2.Distance(touchPosition, transform.position);

                if (distance <= distanceThresh)
                    grabbed = true;
            }
            else
            {
                transform.position = touchPosition;
                grabbed = false;
            }
        }
    }
}
