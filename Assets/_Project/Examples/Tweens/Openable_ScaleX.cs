using DG.Tweening;
using UnityEngine;

namespace KristinaWaldt.Examples
{
    public class Openable_ScaleX : OpenableTweenBase
    {
        protected override Tween OnOpen()
        {
            transform.localScale = new Vector3(0, 1, 1);
            return transform.DOScaleX(1, duration).SetEase(inEase).SetDelay(inDelay);
        }

        protected override Tween OnClose()
        {
            return transform.DOScaleX(0, duration).SetEase(outEase);
        }
    }
}