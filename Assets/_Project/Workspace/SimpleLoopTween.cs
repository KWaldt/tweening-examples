using DG.Tweening; // Für Tweening
using UnityEngine;

public class SimpleLoopTween : MonoBehaviour
{
    private void Start()
    {
        // Alt + Enter
        // Ctrl + Shift + Space
        transform.DOScaleY(0.8f, 2)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);
    }
}
