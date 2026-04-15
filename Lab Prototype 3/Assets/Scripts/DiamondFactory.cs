using UnityEngine;

public class DiamondFactory : MonoBehaviour
{
    public TycoonManager tm;
    public GameObject diamondFactory;
    public void BuildDiamondFactory()
    {
        Camera c = Camera.main;
        Vector3 vp = new Vector3(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Mathf.Abs(c.transform.position.z));
        Vector3 spawnPosition = c.ViewportToWorldPoint(vp);

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
