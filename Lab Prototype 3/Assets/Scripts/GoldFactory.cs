using UnityEngine;

public class GoldFactory : MonoBehaviour
{
    public TycoonManager tm;
    public GameObject goldFactory;
    public void BuildGoldFactory()
    {
        Camera c = Camera.main;
        Vector3 vp = new Vector3(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Mathf.Abs(c.transform.position.z));
        Vector3 spawnPosition = c.ViewportToWorldPoint(vp);

        if (tm.silverCount >= 25)
        {
            Instantiate(goldFactory, spawnPosition, Quaternion.identity);
            tm.silverCount = tm.silverCount - 25;
            tm.silverText.text = $"Silver: {tm.silverCount}";
            tm.goldFactoryCount++;
        }
    }
}
