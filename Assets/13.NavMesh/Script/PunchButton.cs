using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class PunchButton : MonoBehaviour
{
    private Button button;
    private Tweener punchTween;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Shake); // Shake 메서드가 버튼 클릭 시 실행되도록 설정
    }

    private void Punch()
    {
        if (punchTween != null && punchTween.IsActive())
        {
            punchTween.Complete();
        }

        Vector3 punchSize = new Vector3(0.1f, 0.1f, 0.1f);
        punchTween = transform.DOPunchScale(punchSize, 0.5f);
    }

    private void Shake()
    {
        if (punchTween != null && punchTween.IsActive())
        {
            punchTween.Complete();
        }

        punchTween = transform.DOShakePosition(0.5f, 10f, 80);
    }
}
