using DG.Tweening;
using UnityEngine;

namespace KristinaWaldt.Examples
{
    public class Simple_Tween_ScaleX : MonoBehaviour
    {
        [SerializeField] private float duration = 0.2f;
        [SerializeField] private Ease inEase = Ease.OutElastic;
        [SerializeField] private Ease outEase = Ease.InOutCubic;
        [SerializeField] private float inDelay;

        private void OnEnable()
        {
            transform.localScale = new Vector3(0, 1, 1);
            transform.DOScaleX(1, duration).SetEase(inEase).SetDelay(inDelay);
        }

        private void OnDisable()
        {
            transform.DOScaleX(0, duration).SetEase(outEase);
        }
    }
}

