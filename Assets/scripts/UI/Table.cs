using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Table : MonoBehaviour
{// bảng thông tin
    [SerializeField] private Button btnCheckinfor;
    [SerializeField] private GameObject panelInfor;
    [SerializeField] private Button btnClose;
    [SerializeField] private CanvasGroup CvG;
    public TextMeshProUGUI txtInfor;
    public TextMeshProUGUI txtnameObject;
    public string strtxtInfor;
    private void Start()
    {
    }

    private void OnEnable()
    {
        btnCheckinfor.onClick.AddListener(openInfor); 
        btnClose.onClick.AddListener(closepanel);
        fadestart();
    }
    private void OnDisable()
    {
        btnCheckinfor.gameObject.SetActive(true);
        panelInfor.gameObject.SetActive(false);
        btnCheckinfor.onClick.RemoveAllListeners();
        btnClose.onClick.RemoveAllListeners();
    }

    public void fadestart()
    {
        CvG.alpha = 0f;

        CvG.DOFade(0.6f,0.3f)
            .SetEase(Ease.OutQuad);
    }    
    public void openInfor()
    {
        txtInfor.text = strtxtInfor;
        btnCheckinfor.gameObject.SetActive(false);
        panelInfor.SetActive(true);

    }  
    public void closepanel()
    {
        gameObject.SetActive(false);
    }
}
