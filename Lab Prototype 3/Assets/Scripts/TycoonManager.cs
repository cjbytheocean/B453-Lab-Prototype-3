using UnityEngine;
using UnityEngine.Rendering;
using TMPro;
using UnityEngine.Experimental.GlobalIllumination;

public class TycoonManager : MonoBehaviour
{
    public int silverCount = 0;
    public int goldCount = 0;
    public int diamondCount = 0;

    private float defaultSilverTimer = 0f;
    private float defaultGoldTimer = 0f;
    private float defaultDiamondTimer = 0f;

    private float builtSilverTimer = 0f;
    private float builtGoldTimer = 0f;
    private float builtDiamondTimer = 0f;

    public TextMeshProUGUI silverText;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI diamondText;

    public int silverFactoryCount = 0;
    public int goldFactoryCount = 0;
    public int diamondFactoryCount = 0;
    public int premiumFactoryCount = 0;

    void Update()
    {
        defaultSilverTimer += Time.deltaTime;
        if (defaultSilverTimer >= 1f)
        {
            silverCount++;
            silverText.text = $"Silver: {silverCount}";
            defaultSilverTimer = 0f;
        }

        defaultGoldTimer += Time.deltaTime;
        if (defaultGoldTimer >= 5f)
        {
            goldCount++;
            goldText.text = $"Gold: {goldCount}";
            defaultGoldTimer = 0f;
        }

        defaultDiamondTimer += Time.deltaTime;
        if (defaultDiamondTimer >= 10f)
        {
            diamondCount++;
            diamondText.text = $"Diamond: {diamondCount}";
            defaultDiamondTimer = 0f;
        }


    }
}
