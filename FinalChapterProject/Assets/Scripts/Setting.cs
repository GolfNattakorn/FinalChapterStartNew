using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public Transform settingPanel;
    public CanvasGroup BG;
    public GameObject bg;
    public GameObject newGamePanel;
    public GameObject menuPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenSetting()
    {
        BG.alpha = 0;
        BG.LeanAlpha(1, 0.5f);
        bg.SetActive(true);
        settingPanel.LeanMoveLocalX(-50, 0.5f).setEaseOutExpo().delay = 0.1f;

        StartCoroutine(WaitTimeScale0());
    }

   public void CloseSetting()
    {
        BG.LeanAlpha(0, 0.5f);
        StartCoroutine(WaitCloseBG());
        settingPanel.LeanMoveLocalX(+Screen.width, 0.3f).setEaseInExpo();

        Time.timeScale = 1;
    }

    IEnumerator WaitCloseBG()
    {
        yield return new WaitForSeconds(0.3f);
        bg.SetActive(false);
    }

    IEnumerator WaitTimeScale0()
    {
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 0;
    }
 
    public void OpenNewGamePanel()
    {
        newGamePanel.SetActive(true);
    }

    public void OpenMenuPanel()
    {
        menuPanel.SetActive(true);
    }

    public void CloseNewGamePanel()
    {
        newGamePanel.SetActive(false);
    }
    public void CloseMenuPanel()
    {
        menuPanel.SetActive(false);
    }

}
