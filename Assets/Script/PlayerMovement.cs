using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    [Header("Look")]
    public float mouseSpeed;
    public float yRotation;
    public float xRotation;
    public Camera cam;
    public bool canLook = true; 

    public GameObject playerHand;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   //마우스 커서를 화면 안에서 고정
        Cursor.visible = false;                     //마우스 커서를 보이지 않도록 설정
    }

    void Update()
    {
        CameraLook();
        PlayerMove();
    }

    void CameraLook()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * mouseSpeed * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * mouseSpeed * Time.deltaTime;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cam.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }

    void PlayerMove()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 moveVec = transform.forward * Vertical + transform.right * Horizontal;

        transform.position += moveVec.normalized * moveSpeed * Time.deltaTime;
    }
}
