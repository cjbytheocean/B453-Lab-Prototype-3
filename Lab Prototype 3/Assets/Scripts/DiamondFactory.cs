using UnityEngine;

public class DiamondFactory : MonoBehaviour
{
    public TycoonManager tm;
    public GameObject diamondFactory;
    public void BuildDiamondFactory()
    {
        if (tm.silverCount >= 30 && tm.goldCount >= 10)
        {
            Instantiate(diamondFactory, Vector3.zero, Quaternion.identity);
            tm.silverCount = tm.silverCount - 30;
            tm.goldCount = tm.goldCount - 10;
            tm.silverText.text = $"Silver: {tm.silverCount}";
            tm.goldText.text = $"Gold: {tm.goldCount}";
            tm.diamondFactoryCount++;
        }
    }
}
