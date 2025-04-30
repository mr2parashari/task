using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using System.Collections;

public class LeaderboardFetcher : MonoBehaviour
{
    public TextMeshProUGUI leaderboardText;

    private void Start()
    {
        StartCoroutine(FetchLeaderboard());
    }

    IEnumerator FetchLeaderboard()
    {
        leaderboardText.text = "Loading...";
        yield return new WaitForSeconds(1f);

        leaderboardText.text = "Mock Leaderboard:\n1. PlayerX - 150\n2. PlayerY - 120";
    }
}

