using UnityEngine;

namespace KristinaWaldt.Examples
{
    public class OpenCloseUsingEnable : MonoBehaviour
    {
        private OpenableTweenBase tween;
        
        private void OnEnable()
        {
            Initialise();

            if (tween == null)
                return;
            
            tween.Open();
        }

        private void Initialise()
        {
            if (tween != null)
                return;
            
            tween = GetComponent<OpenableTweenBase>();
        }

        private void OnDisable()
        {
            if (tween == null)
                return;
            
            tween.Close();
        }
    }
}