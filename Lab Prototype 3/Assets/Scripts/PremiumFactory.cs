using UnityEngine;

public class PremiumFactory : MonoBehaviour
{
    public TycoonManager tm;
    public GameObject premiumFactory;
    public void BuildPremiumFactory()
    {
        Camera c = Camera.main;
        Vector3 vp = new Vector3(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Mathf.Abs(c.transform.position.z));
        Vector3 spawnPosition = c.ViewportToWorldPoint(vp);

        if (tm.goldCount >= 40 && tm.diamondCount >= 15)
        {
            Instantiate(premiumFactory, spawnPosition, Quaternion.identity);
            tm.goldCount = tm.goldCount - 40;
            tm.diamondCount = tm.diamondCount - 15;
            tm.goldText.text = $"Gold: {tm.goldCount}";
            tm.diamondText.text = $"Diamond: {tm.diamondCount}";
            tm.premiumFactoryCount++;
        }
    }
}
