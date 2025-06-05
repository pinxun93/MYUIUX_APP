using UnityEngine;
using UnityEngine.SceneManagement;

public class 按鈕的動作 : MonoBehaviour
{
    public void 首頁()
    {
        SceneManager.LoadScene("首頁_1");
    }
    public void 採茶過程()
    {
        SceneManager.LoadScene("採茶過程_2");
    }
    public void 製茶過程()
    {
        SceneManager.LoadScene("製茶過程_3");
    }
    public void 包裝過程()
    {
        SceneManager.LoadScene("包裝過程_4");
    }
    public void 商品過程()
    {
        SceneManager.LoadScene("周邊商品_5");
    }
    public void 封面()
    {
        SceneManager.LoadScene("封面_0");
    }
}