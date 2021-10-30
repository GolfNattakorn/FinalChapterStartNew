using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public GameObject playButton;
    public GameObject loading;
    public Slider loadingSlider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void NextScene(int sceneIndex)
    {
        Time.timeScale = 1;

        StartCoroutine(LoadScene(sceneIndex));
    }

    IEnumerator LoadScene(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        playButton.SetActive(false);
        loading.SetActive(true);

        while (!operation.isDone)
        {
            //float progress = Mathf.Clamp01(operation.progress / 0.9f);

            loadingSlider.value =operation.progress;
            yield return null;
        }
    }

}
