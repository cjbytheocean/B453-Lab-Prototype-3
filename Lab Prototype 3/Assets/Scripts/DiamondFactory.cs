using UnityEngine;

public class DiamondFactory : MonoBehaviour
{
    public TycoonManager tm;
    public GameObject diamondFactory;
    public void BuildDiamondFactory()
    {
        Vector3 vp = new Vector3(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), 10f);
        Vector3 spawnPosition = Camera.main.ViewportToWorldPoint(vp);

        if (tm.silverCount >= 30 && tm.goldCount >= 10)
        {
            Instantiate(diamondFactory, spawnPosition, Quaternion.identity);
            tm.silverCount = tm.silverCount - 30;
            tm.goldCount = tm.goldCount - 10;
            tm.silverText.text = $"Silver: {tm.silverCount}";
            tm.goldText.text = $"Gold: {tm.goldCount}";
            tm.diamondFactoryCount++;
        }
    }
}
