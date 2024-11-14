using DG.Tweening;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public LayerMask targetLayer;

    private Renderer childRenderer;
    private Tweener jumpTween;

    private void Awake()
    {
        childRenderer = GetComponentInChildren<Renderer>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // targetLayer를 사용하여 Raycast 수행
            if (Physics.Raycast(ray, out RaycastHit hit,layerMask: targetLayer, maxDistance: 1000f))
            {
                transform.position = hit.point;

                if (jumpTween != null)
                {
                    jumpTween.Complete();
                }

                childRenderer.enabled = true;
                jumpTween = transform.GetChild(0)
                    .DOPunchPosition(Vector3.up * 2f, 0.5f)
                    .OnComplete(() => childRenderer.enabled = false)
                    .SetEase(Ease.InOutBack);
            }
        }
    }
}
