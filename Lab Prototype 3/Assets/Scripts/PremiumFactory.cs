using UnityEngine;

public class PremiumFactory : MonoBehaviour
{
    public TycoonManager tm;
    public GameObject premiumFactory;
    public void BuildPremiumFactory()
    {
        if (tm.goldCount >= 40 && tm.diamondCount >= 15)
        {
            Instantiate(premiumFactory, Vector3.zero, Quaternion.identity);
            tm.goldCount = tm.goldCount - 40;
            tm.diamondCount = tm.diamondCount - 15;
            tm.goldText.text = $"Gold: {tm.goldCount}";
            tm.diamondText.text = $"Diamond: {tm.diamondCount}";
            tm.premiumFactoryCount++;
        }
    }
}
