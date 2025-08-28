using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    public TextMeshProUGUI IDText;
    public TextMeshProUGUI CurrentLv;
    public TextMeshProUGUI CurrentExp;
    public TextMeshProUGUI CurrentGold;
    public TextMeshProUGUI Name;
    public Image ExpImgFilled;
    public Button StatusBtn;
    public Button InventoryBtn;
    public Button CloseStatusbtn;
    public Button CloseInventorybtn;
    public UIManager uiManager;

    private void Start()
    {
        // Ensure uiManager is assigned before using it
        uiManager = UIManager.instance;

        StatusBtn.onClick.AddListener(uiManager.OpenStatus);
        InventoryBtn.onClick.AddListener(uiManager.OpenInventory);
        CloseStatusbtn.onClick.AddListener(uiManager.closeBtn);
        CloseInventorybtn.onClick.AddListener(uiManager.closeBtn);
        SetPlayerInformation(GameManager.instance.Player);
    }

    public void SetPlayerInformation(Player p)
    {
        GameManager.instance.SetData();
        IDText.text = $"{GameManager.instance.Player.ID}";
        Name.text = $"{GameManager.instance.Player.Name}";
        CurrentLv.text = $"{GameManager.instance.Player.Level}";
        CurrentExp.text = $"{GameManager.instance.Player.Experience}";
        CurrentGold.text = $"{GameManager.instance.Player.Gold}";
    }

    /*    public void OpenStatus()
        {
            UIManager.instance.UiStatus.gameObject.SetActive(true);
        }

        public void OpenInventory()
        {
            UIManager.instance.UiInventory.gameObject.SetActive(true);
        }

        public void closeBtn()
        {
            UIManager.instance.UiStatus.gameObject.SetActive(false);
            UIManager.instance.UiInventory.gameObject.SetActive(false);
        }*/
}
