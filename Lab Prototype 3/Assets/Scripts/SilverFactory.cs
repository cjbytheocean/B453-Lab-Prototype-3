using UnityEngine;

public class SilverFactory : MonoBehaviour
{
    public TycoonManager tm;
    public GameObject silverFactory;
    public void BuildSilverFactory()
    {
        if (tm.silverCount >= 10)
        {
            Instantiate(silverFactory, Vector3.zero, Quaternion.identity);
            tm.silverCount = tm.silverCount - 10;
            tm.silverText.text = $"Silver: {tm.silverCount}";
            tm.silverFactoryCount++;
        }
    }
}
