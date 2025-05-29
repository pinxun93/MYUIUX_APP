using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 按鈕的動作 : MonoBehaviour
{
    public void 首頁()
    {
        SceneManager.LoadScene("01_首頁");
    }
    public void 採茶過程()
    {
        SceneManager.LoadScene("02_採茶過程");
    }
    public void 製茶過程()
    {
        SceneManager.LoadScene("03_製茶過程");
    }
    public void 包裝茶葉()
    {
        SceneManager.LoadScene("04_包裝茶葉");
    }
}
