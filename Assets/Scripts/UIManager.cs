using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField] UIMainMenu uiMainMenu;
    [SerializeField] UIInventory uiInventory;
    [SerializeField] UIStatus uiStatus;

    public UIMainMenu UiMainMenu => uiMainMenu;
    public UIInventory UiInventory => uiInventory;
    public UIStatus UiStatus => uiStatus;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
/*        uiInventory.gameObject.SetActive(false);
        uiStatus.gameObject.SetActive(false);*/
        DontDestroyOnLoad(gameObject);
    }

    public void OpenStatus()
    {
        UiStatus.gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        UiInventory.gameObject.SetActive(true);
    }

    public void closeBtn()
    {
        UiStatus.gameObject.SetActive(false);
        UiInventory.gameObject.SetActive(false);
    }
}
