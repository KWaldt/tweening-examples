using DG.Tweening;
using TMPro;

public class OpenCloseFadeText : OpenCloseTweenBase
{
    private TextMeshProUGUI textMeshPro;
    private float origAlpha;

    private void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        origAlpha = textMeshPro.color.a;
    }

    protected override Tween OpenTween()
    {
        return textMeshPro.DOFade(origAlpha, duration);
    }

    protected override Tween CloseTween()
    {
        return textMeshPro.DOFade(0, duration);
    }
}
