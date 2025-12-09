using UnityEngine;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    public GameObject ProfilePanel;
    public GameObject ShopPanel;
    public GameObject InventoryPanel;
    public GameObject SettingPanel;
    void Start()
    {
        ProfilePanel.SetActive(false);
        ShopPanel.SetActive(false);
        InventoryPanel.SetActive(false);
        SettingPanel.SetActive(false);
    }

    public void OpenProfilePanel()
    {
        ProfilePanel.SetActive(true);
        ShopPanel.SetActive(false);
        InventoryPanel.SetActive(false);
        SettingPanel.SetActive(false);
    }

    public void OpenShopPanel()
    {
        ProfilePanel.SetActive(false);
        ShopPanel.SetActive(true);
        InventoryPanel.SetActive(false);
        SettingPanel.SetActive(false);
    }

    public void OpenInventoryPanel()
    {
        ProfilePanel.SetActive(false);
        ShopPanel.SetActive(false);
        InventoryPanel.SetActive(true);
        SettingPanel.SetActive(false);
    }

    public void Return()
    {
        ProfilePanel.SetActive(false);
        ShopPanel.SetActive(false);
        InventoryPanel.SetActive(false);
        SettingPanel.SetActive(false);
    }    
    public void settingPanel()
    {
        SettingPanel.SetActive(true);
        ProfilePanel.SetActive(false);
        ShopPanel.SetActive(false);
        InventoryPanel.SetActive(false);
    }
}
