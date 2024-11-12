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
        // �̵� �Է�
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = transform.forward * vertical;

        // �̵�
        controller.Move(direction * speed * Time.deltaTime);

        // ȸ�� �Է�
        float horizontal = Input.GetAxis("Horizontal");

        // ȸ��
        transform.Rotate(0, horizontal * rotationSpeed * Time.deltaTime, 0);
    }
}
