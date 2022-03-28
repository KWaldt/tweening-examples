using DG.Tweening;
using UnityEngine;

public class SimpleTween : MonoBehaviour
{
    public float duration = 0.2f;
    public Ease inEase = Ease.OutElastic;
    public Ease outEase = Ease.InOutCubic;

    private Tween tween;

    private void OnEnable()
    {
        transform.localScale = new Vector3(0, 1, 1);
        tween.Kill();
        tween = transform.DOScaleX(1, duration).SetEase(inEase);
    }
    
    private void OnDisable()
    {
        tween.Kill();
        tween = transform.DOScaleX(0, duration).SetEase(outEase);
    }
}
