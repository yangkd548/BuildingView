using UnityEngine;

public class MousePanCtrl : MonoBehaviour
{
    readonly float hSpeed = 0.5f;
    Vector3 lastMousePos;

    // Start is called before the first frame update
    void Start(){ }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            RecordMousePos();
        }
        if (lastMousePos != null && Input.GetMouseButton(0)) {
            PanCtrl();
            RecordMousePos();
        }
    }

    private void PanCtrl() {
        transform.eulerAngles += Vector3.down * (lastMousePos.x - Input.mousePosition.x) * hSpeed;
    }

    private void RecordMousePos() {
        lastMousePos = Input.mousePosition;
    }
}