using UnityEngine;

public class GoldFactory : MonoBehaviour
{
    public TycoonManager tm;
    public GameObject goldFactory;
    public void BuildGoldFactory()
    {
        if (tm.silverCount >= 25)
        {
            Instantiate(goldFactory, Vector3.zero, Quaternion.identity);
            tm.silverCount = tm.silverCount - 25;
            tm.silverText.text = $"Silver: {tm.silverCount}";
            tm.goldFactoryCount++;
        }
    }
}
