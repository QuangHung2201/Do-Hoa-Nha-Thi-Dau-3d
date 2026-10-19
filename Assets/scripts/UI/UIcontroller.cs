using UnityEngine;

public class UIcontroller : MonoBehaviour
{
    public static UIcontroller instance;
    public GameObject panelDoorUI;
    public GameObject PanelInfor;
    public GameObject PanelFan;
    void Start()
    {
        instance = this;
    }

    private void OnDestroy()
    {
        instance = null;
    }

}
