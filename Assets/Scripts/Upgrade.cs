using UnityEngine;

public enum UpgradeType
{
    AutoCollector,
    TapMultiplier
}

[CreateAssetMenu(fileName = "New Upgrade", menuName = "Upgrades/Upgrade")]
public class Upgrade : ScriptableObject
{
    public UpgradeType upgradeType;
    public string upgradeName;
    public float upgradeValue; 
}
