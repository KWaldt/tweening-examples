using DG.Tweening;
using UnityEngine;

// Abstract wegen Funktion
// = Framework (Variablen)
public abstract class OpenCloseTweenBase : MonoBehaviour
{
    public bool isActive = true;
    
    [SerializeField] protected float duration = 0.2f;
    [SerializeField] protected Ease inEase = Ease.OutElastic;
    [SerializeField] protected Ease outEase = Ease.InOutCubic;
    public float inDelay;

    protected Tween tween;

    public void Open()
    {
        //if (!isActive) return;

        if (isActive)
        {
            tween.Kill();
            tween = OpenTween();
            tween.SetEase(inEase).SetDelay(inDelay);
        }
    }

    public void Close()
    {
        if (!isActive)
            return;
        
        tween.Kill();
        tween = CloseTween();
        tween.SetEase(outEase);
    }

    // Abstract: Überschreibbar, no default 
    protected abstract Tween OpenTween();
    protected abstract Tween CloseTween();
    // Ctrl + R + S : Change Signature
}