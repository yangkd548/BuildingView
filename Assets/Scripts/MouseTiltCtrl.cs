using System;
using UnityEngine;

public class MouseTiltCtrl : MonoBehaviour
{
    readonly float vSpeed = 0.1f;
    Vector3 lastMousePos;

    // Start is called before the first frame update
    void Start(){ }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RecordMousePos();
        }
        if (lastMousePos != null && Input.GetMouseButton(0)) {
            TiltCtrl();
            RecordMousePos();
        }
    }

    private void TiltCtrl() {
        var deltaY = lastMousePos.y - Input.mousePosition.y;
        var angles = transform.eulerAngles;
        if(angles.x > 90) {
            angles.x -= 360;
        }
        angles.x = Math.Min(Math.Max(angles.x + deltaY * vSpeed, -45), 45);
        if (angles.x < 0) {
            angles.x += 360;
        }
        transform.eulerAngles = angles;
    }

    private void RecordMousePos() {
        lastMousePos = Input.mousePosition;
    }
}