using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public CoinManager coinManager;  

    private void Start()
    {
        LoadData();
    }

    private void OnApplicationQuit()
    {
        SaveData();
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("Coins", coinManager.coins);
        PlayerPrefs.SetInt("TapMultiplier", coinManager.tapMultiplier);
        PlayerPrefs.SetInt("AutoCollect", coinManager.autoCollectEnabled ? 1 : 0);
    }

    public void LoadData()
    {
        coinManager.coins = PlayerPrefs.GetInt("Coins", 0);
        coinManager.tapMultiplier = PlayerPrefs.GetInt("TapMultiplier", 1);
        coinManager.autoCollectEnabled = PlayerPrefs.GetInt("AutoCollect", 0) == 1;
    }
}
