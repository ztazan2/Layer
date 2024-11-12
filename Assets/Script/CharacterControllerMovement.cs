using UnityEngine;

public class CharacterControllerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 120f; 
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // 이동 입력
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = transform.forward * vertical;

        // 이동
        controller.Move(direction * speed * Time.deltaTime);

        // 회전 입력
        float horizontal = Input.GetAxis("Horizontal");

        // 회전
        transform.Rotate(0, horizontal * rotationSpeed * Time.deltaTime, 0);
    }
}
