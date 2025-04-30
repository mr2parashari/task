using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance { get; private set; }  

    public int coins = 0;
    public TMP_Text coinCounterText;
    public GameObject upgradeMenu;
    public GameObject coinPrefab;
    public Transform coinSpawnPoint;

    private bool autoCollectorActive = false;
    public bool autoCollectEnabled = false;  
    public int tapMultiplier = 1;  

    public Upgrade autoCollectorUpgrade;
    public Upgrade tapMultiplierUpgrade;


    public event System.Action<int> OnCoinChanged;

    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);  
        }
    }

    private void Start()
    {
        UpdateCoinCounter();
    }


    public void OnTapButtonClicked()
    {
        AddCoins(tapMultiplier);
        SpawnCoin();
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        UpdateCoinCounter();
        OnCoinChanged?.Invoke(coins);
    }
    private void UpdateCoinCounter()
    {
        coinCounterText.text = "Coins: " + coins;
    }

    private void SpawnCoin()
    {
        GameObject coin = Instantiate(coinPrefab, coinSpawnPoint.position, Quaternion.identity);
        Destroy(coin, 0.2f);  
    }


    public void ActivateAutoCollector()
    {
        if (!autoCollectorActive)
        {
            autoCollectorActive = true;
            autoCollectEnabled = true;  // Set auto-collection to true
            InvokeRepeating("AutoCollect", 0f, autoCollectorUpgrade.upgradeValue);  // Use the upgradeValue to set interval
        }
    }

    private void AutoCollect()
    {
        AddCoins(1);  
    }

    public void ActivateTapMultiplier()
    {
        tapMultiplier = (int)tapMultiplierUpgrade.upgradeValue;
    }
    public void OpenUpgradeMenu()
    {
        upgradeMenu.SetActive(true);
    }

    public void CloseUpgradeMenu()
    {
        upgradeMenu.SetActive(false);
    }
}
