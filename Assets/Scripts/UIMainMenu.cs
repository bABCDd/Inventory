using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    public GameObject uIMainMenu;
    public GameObject uIStatus;
    public GameObject uIInventory;
    public TextMeshProUGUI IDText;
    public TextMeshProUGUI CurrentLv;
    public TextMeshProUGUI CurrentExp;
    public TextMeshProUGUI CurrentGold;
    public Image ExpImgFilled;
    public Button StatusBtn;
    public Button InventoryBtn;
    public Button CloseStatusbtn;
    public Button CloseInventorybtn;

    private void Start()
    {
        StatusBtn.onClick.AddListener(OpenStatus);
        InventoryBtn.onClick.AddListener(OpenInventory);
        CloseStatusbtn.onClick.AddListener(closeBtn);
        CloseInventorybtn.onClick.AddListener(closeBtn);
    }
/*    public void OpenMainMenu()
    {
        uIMainMenu.gameObject.SetActive(true);
    }*/

    public void OpenStatus()
    {
        UIManager.instance.UiStatus.gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        UIManager.instance.UiInventory.gameObject.SetActive(true);
    }

    public void closeBtn()
    {
        uIStatus.gameObject.SetActive(false);
        uIInventory.gameObject.SetActive(false);
    }
}
