using DG.Tweening;  // Make sure to include DOTween's namespace
using UnityEngine;
using UnityEngine.UI;

public class CoinButtonAnimation : MonoBehaviour
{
    public Button coinButton;  
    public float bounceDuration = 0.5f; 
    public float bounceScale = 1.2f; 
    public int bounceLoops = -1;  

    private void Start()
    {
       

        if (coinButton != null)
        {
           
            AnimateButton();
        }
        else
        {
            Debug.LogError("Coin Button is not assigned!");
        }
    }

    
    public void AnimateButton()
    {
        transform.DOKill();
        coinButton.transform.DOScale(bounceScale, bounceDuration)  
            .SetLoops(bounceLoops, LoopType.Yoyo) 
            .SetEase(Ease.OutBounce);
        Debug.Log("anime");
    }

   
}
