using UnityEngine;

public class SilverFactory : MonoBehaviour
{
    public TycoonManager tm;
    public GameObject silverFactory;
    public void BuildSilverFactory()
    {
        Camera c = Camera.main;
        Vector3 vp = new Vector3(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Mathf.Abs(c.transform.position.z));
        Vector3 spawnPosition = c.ViewportToWorldPoint(vp);

        if (tm.silverCount >= 10)
        {
            Instantiate(silverFactory, spawnPosition, Quaternion.identity);
            tm.silverCount = tm.silverCount - 10;
            tm.silverText.text = $"Silver: {tm.silverCount}";
            tm.silverFactoryCount++;
        }
    }
}
