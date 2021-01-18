using UnityEngine;

public class MoveCtrl : MonoBehaviour
{
    readonly float mSpeed = 3;
    
    // Start is called before the first frame update
    void Start(){ }

    // Update is called once per frame
    void Update() {
        UpdateMove();
    }

    private void UpdateMove() {
        var forward = transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * -mSpeed;
        var right = transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * -mSpeed;
        //如果当前物体朝向，不是规定的角色角度，则需要缓动重置（水平角度、仰角）
        //角色角度重置结束后，再进行移动
        transform.position += forward;
        transform.position += right;
    }
}