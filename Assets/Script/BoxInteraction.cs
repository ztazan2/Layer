using UnityEngine;

public class BoxInteraction : MonoBehaviour
{
    // Player ���̾� ��ȣ�� ��Ȯ�ϰ� �����ϼ���
    private int playerLayer;

    private void Start()
    {
        // "Player"��� �̸��� ���̾� ��ȣ�� �����ɴϴ�.
        playerLayer = LayerMask.NameToLayer("Player");
    }

    private void OnCollisionEnter(Collision collision)
    {
        // �浹�� ��ü�� Player ���̾����� Ȯ��
        Debug.Log("�浹 ��ü�� ���̾�: " + collision.gameObject.layer); // ����׷� ���̾� Ȯ��

        if (collision.gameObject.layer == playerLayer)
        {
            Debug.Log("Player�� Box�� �浹�߽��ϴ�.");
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
