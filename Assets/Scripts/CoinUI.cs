using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    private void OnEnable()
    {
        CoinManager.Instance.OnCoinChanged += UpdateUI;  
    }

    private void OnDisable()
    {
        CoinManager.Instance.OnCoinChanged -= UpdateUI;  
    }

    void UpdateUI(int coins)
    {
        coinText.text = "Coins: " + coins;
    }
}
