using UnityEngine;

public class BoxInteraction : MonoBehaviour
{
    // Player 레이어 번호를 정확하게 설정하세요
    private int playerLayer;

    private void Start()
    {
        // "Player"라는 이름의 레이어 번호를 가져옵니다.
        playerLayer = LayerMask.NameToLayer("Player");
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 충돌한 객체가 Player 레이어인지 확인
        Debug.Log("충돌 객체의 레이어: " + collision.gameObject.layer); // 디버그로 레이어 확인

        if (collision.gameObject.layer == playerLayer)
        {
            Debug.Log("Player와 Box가 충돌했습니다.");
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
