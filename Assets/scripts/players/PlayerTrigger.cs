using UnityEngine;
using UnityEngine.Rendering;

public class PlayerTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "door":
                UIcontroller.instance.panelDoorUI.SetActive(true);
                break;

            case "table":
                setdata("Tên : bàn liền ghế\r\nChiều dài tổng thể: 180 cm\r\nChiều sâu (rộng) tổng thể: 70 cm \r\nMặt ghế ngồi rộng: ~25 cm\r\nMặt bàn rộng: 40 cm\r\nChiều cao:\r\nTừ đất lên mặt ghế: 40 cm\r\nTừ đất lên mặt bàn: 75 cm ", "Bàn liền ghế");
                break;

            case "bench":
                setdata("Tên : ghế dài\r\nChiều dài: 180 cm \r\nChiều rộng (mặt ghế): 30 cm\r\nChiều cao (từ đất lên mặt ghế): 45 cm\r\n", "Ghế dài");
                break;

            case "cushion":
                setdata("Tên : Khối đệm bọc đế trụ bóng rổ\r\nChiều rộng (mặt trước): 100 cm \r\nChiều sâu (từ trước ra sau lưng): 120 \r\nChiều cao: 140 \r\n", "Khối đệm");
                break;

            case "basketballhoop":
                setdata("Tên : khung bóng rổ\r\n1. Bảng rổ (Backboard - phần bảng kính trong suốt)\r\nChiều rộng (ngang): 180 cm\r\nChiều cao (đứng): 105 cm\r\nĐộ dày: Thường từ 1 cm - 1.2 cm (đối với kính cường lực)\r\nKhung chữ nhật nhỏ bên trong: Rộng 59 cm x Cao 45 cm. Mép dưới của hình chữ nhật này nằm ngang bằng với vành rổ.\r\n\r\n2. Vành rổ \r\nĐường kính trong: 45 cm \r\nĐộ dày của thép ống (làm vành): 1.6 cm - 2 cm.\r\nKhoảng cách từ bảng rổ đến mép trong của vành rổ: 15 cm.\r\n3. Chiều cao lắp đặt tiêu chuẩn\r\n\r\nTừ mặt sân lên tới mép trên của vành rổ: Đúng 305 cm (3.05 mét).\r\n\r\nTừ mặt sân lên tới mép dưới của bảng rổ: 290 cm (2.9 mét). \r\n", "Khung bóng rổ");
                break;

            case "plasticchair":
                setdata("Tên : Ghế nhựa\r\nChiều rộng (ngang mặt ghế): 42 cm\r\nChiều sâu (từ mép trước ra mép sau): 45 cm\r\nChiều cao (từ đáy phần ngồi lên đỉnh tựa lưng): 18 cm \r\n", "Ghế nhựa");
                break;
            case "congtac":
                UIcontroller.instance.PanelFan.SetActive(true);
                break;
        }
    }

    public void setdata(string info, string name)
    {
        UIcontroller.instance.PanelInfor.SetActive(true);
        UIcontroller.instance.PanelInfor.GetComponent<Table>().strtxtInfor = info;
        UIcontroller.instance.PanelInfor.GetComponent<Table>().txtnameObject.text = "Thông tin " + name;
    }    


    private void OnTriggerExit(Collider other)
    {
        switch (other.tag)
        {
            case "door":
                UIcontroller.instance.panelDoorUI.SetActive(false);
                break;

            case "table":
                UIcontroller.instance.PanelInfor.SetActive(false);
                break;

            case "bench":
                UIcontroller.instance.PanelInfor.SetActive(false);
                break;

            case "cushion":
                UIcontroller.instance.PanelInfor.SetActive(false);
                break;

            case "basketballhoop":
                UIcontroller.instance.PanelInfor.SetActive(false);
                break;

            case "plasticchair":
                UIcontroller.instance.PanelInfor.SetActive(false);
                break;
            case "congtac":
                UIcontroller.instance.PanelFan.SetActive(false);
                break;
        }
    }
}
