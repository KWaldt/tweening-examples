// Alt + Enter: "Implement missing members"

using DG.Tweening;
using UnityEngine;

// = Implementation (Animation)
public class OpenCloseScaleX : OpenCloseTweenBase
{
    // Beispiel: virtual
    // public override void Open()
    // {
    //     // Parent erweitern?
    //     base.Open();
    //     
    //     Debug.Log("Two");
    // }

    // OpenTween
    // void     -> Tween
    // tween =  -> return
    
    protected override Tween OpenTween()
    {
        transform.localScale = new Vector3(0, 1, 1);
        return transform.DOScaleX(1, duration);
    }

    protected override Tween CloseTween()
    {
        return transform.DOScaleX(0, duration);
    }
}
