using UnityEngine;
using UnityEngine.UI;

public class UpgradeMenu : MonoBehaviour
{
    public GameObject upgradeMenu;
    public Button autoCollectorButton;
    public Button tapMultiplierButton;
    public CoinManager coinManager;

    public Upgrade autoCollectorUpgrade;
    public Upgrade tapMultiplierUpgrade;

    private void Start()
    {
        
        upgradeMenu.SetActive(false);

       
        autoCollectorButton.onClick.AddListener(ActivateAutoCollector);
        tapMultiplierButton.onClick.AddListener(ActivateTapMultiplier);
    }

 
    public void OpenUpgradeMenu()
    {
        upgradeMenu.SetActive(true);
    }

 
    public void CloseUpgradeMenu()
    {
        upgradeMenu.SetActive(false);
    }

    
    private void ActivateAutoCollector()
    {
        if (!coinManager.autoCollectEnabled)
        {
            coinManager.ActivateAutoCollector();
        }
    }

 
    private void ActivateTapMultiplier()
    {
        coinManager.ActivateTapMultiplier();
    }
}
