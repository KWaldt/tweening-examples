using DG.Tweening;
using UnityEngine;

namespace KristinaWaldt.Examples
{
    public class Openable_RotateFromLeft : OpenableTweenBase
    {
        private static readonly Vector3 HiddenRotation = new Vector3(0, -90, 0);
        public OpenCloseTweenBase tfdsf;
        
        protected override Tween OnOpen()
        {
            transform.localEulerAngles = HiddenRotation;
            return transform.DOLocalRotate(new Vector3(0, 0, 0), duration).SetEase(inEase).SetDelay(inDelay);
        }

        protected override Tween OnClose()
        {
            return transform.DOLocalRotate(HiddenRotation, duration).SetEase(outEase);
        }
    }
}