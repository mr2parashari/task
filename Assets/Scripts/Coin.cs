using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnMouseDown()
    {
        
        HandleCoinTap();
    }

    private void Update()
    {
      
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null && hit.collider.CompareTag("Coin"))
                {
                    HandleCoinTap();
                }
            }
        }
    }

    private void HandleCoinTap()
    {
        CoinManager.Instance.AddCoins(CoinManager.Instance.tapMultiplier);  // Add coins based on tap multiplier
        CoinFactory.Instance.DestroyAndRespawn(gameObject);  // Assuming CoinFactory handles the respawn
    }
}
