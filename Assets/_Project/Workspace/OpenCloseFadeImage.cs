using DG.Tweening;
using UnityEngine.UI;

public class OpenCloseFadeImage : OpenCloseTweenBase
{
    private Image image;
    private float origAlpha;

    private void Awake()
    {
        image = GetComponent<Image>();
        origAlpha = image.color.a;
    }

    protected override Tween OpenTween()
    {
        // TODO: Set alpha to 0
        // Ctrl + Shift + Space: Parameters
        return image.DOFade(origAlpha, duration);
    }

    protected override Tween CloseTween()
    {
        return image.DOFade(0, duration);
    }
}
