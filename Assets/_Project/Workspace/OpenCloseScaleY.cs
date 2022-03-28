using DG.Tweening;
using UnityEngine;

public class OpenCloseScaleY : OpenCloseTweenBase
{
    protected override Tween OpenTween()
    {
        transform.localScale = new Vector3(1, 0, 1);
        return transform.DOScaleY(1, duration);
    }

    protected override Tween CloseTween()
    {
        return transform.DOScaleY(0, duration);
    }
}
