using UnityEngine;

public class ToggleShop : MonoBehaviour
{
    public GameObject shop;

    public void Toggle()
    {
        shop.SetActive(!shop.activeSelf);
    }
}
