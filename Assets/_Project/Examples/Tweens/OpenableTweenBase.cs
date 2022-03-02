using DG.Tweening;
using UnityEngine;

namespace KristinaWaldt.Examples
{
    public abstract class OpenableTweenBase : MonoBehaviour
    {
        [SerializeField] protected float duration = 0.2f;
        [SerializeField] protected Ease inEase = Ease.OutElastic;
        [SerializeField] protected Ease outEase = Ease.InOutCubic;
        [SerializeField] protected float inDelay;

        protected Tween tween;

        public void Open()
        {
            tween.Kill();
            tween = OnOpen();
        }

        public void Close()
        {
            tween.Kill();
            tween = OnClose();
        }

        protected abstract Tween OnOpen();
        protected abstract Tween OnClose();
    }
}