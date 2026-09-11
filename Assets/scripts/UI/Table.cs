using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Table : MonoBehaviour
{// bảng thông tin
    [SerializeField] private Button btnCheckinfor;
    [SerializeField] private GameObject panelInfor;
    [SerializeField] private Button btnClose;
    public TextMeshProUGUI txtInfor;
    public TextMeshProUGUI txtnameObject;
    public string strtxtInfor;
    private void Start()
    {
    }

    private void OnEnable()
    {
        btnCheckinfor.onClick.AddListener(openInfor); 
    }
    private void OnDisable()
    {
        btnCheckinfor.gameObject.SetActive(true);
        panelInfor.gameObject.SetActive(false);
        btnCheckinfor.onClick.RemoveAllListeners();
        btnClose.onClick.RemoveAllListeners();
    }
    public void openInfor()
    {
        txtInfor.text = strtxtInfor;
        btnCheckinfor.gameObject.SetActive(false);
        panelInfor.SetActive(true);
        btnClose.onClick.AddListener(closepanel);
    }  
    public void closepanel()
    {
        gameObject.SetActive(false);
    }
}
