using UnityEngine;

public class UIcontroller : MonoBehaviour
{
    public static UIcontroller instance;
    public GameObject panelDoorUI;
    public GameObject PanelInfor;

    void Start()
    {
        instance = this;
    }

    private void OnDestroy()
    {
        instance = null;
    }

}
