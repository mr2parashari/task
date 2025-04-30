using UnityEngine;

public class CoinFactory : MonoBehaviour
{
    public static CoinFactory Instance;

    public GameObject coinPrefab;
    public Transform spawnPoint;
    public GameObject currentCoin;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        SpawnCoin();
    }

    public void SpawnCoin()
    {
        currentCoin = Instantiate(coinPrefab, spawnPoint.position, Quaternion.identity);
    }

    public void DestroyAndRespawn(GameObject coin)
    {
        if (coin == currentCoin)
        {
            Destroy(currentCoin);
            currentCoin = null;
            Invoke(nameof(SpawnCoin), 0.2f); // delay spawn
        }
    }

    public void DestroyCurrentCoin()
    {
        if (currentCoin != null)
        {
            Destroy(currentCoin);
            currentCoin = null;
            Invoke(nameof(SpawnCoin), 0.2f);
        }
    }
}
