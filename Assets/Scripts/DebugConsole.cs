using UnityEngine;

public class DebugConsole : MonoBehaviour
{
    public bool showConsole = true;

    private void OnGUI()
    {
        if (!showConsole) return;

        GUILayout.BeginArea(new Rect(10, 10, 300, 150), GUI.skin.box);
        GUILayout.Label("Coins: " + CoinManager.Instance.coins);
        GUILayout.Label("Tap Multiplier: " + CoinManager.Instance.tapMultiplier);
        GUILayout.Label("Auto Collect: " + CoinManager.Instance.autoCollectEnabled);
        GUILayout.EndArea();
    }
}
