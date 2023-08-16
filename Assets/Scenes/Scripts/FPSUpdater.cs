using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSUpdater : MonoBehaviour
{
    float fps;
    float upDateTimer;
    [SerializeField] float updateFreq = 0.5f;
    [SerializeField] TextMeshProUGUI fpsTitle;
    [SerializeField] bool isDisplayed;

     
    void Start()
    {
        upDateTimer = updateFreq;
        fpsTitle.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        UpdatefpsDisplay();
        ToggleFPSDisplay();
    }

    private void UpdatefpsDisplay()
    {
        upDateTimer -=Time.deltaTime;
        if(upDateTimer <= 0f)
        {
            fps = 1 / Time.unscaledDeltaTime;
            fpsTitle.text = "FPS: " + Mathf.Round(fps);
            upDateTimer = updateFreq;
        }
    }

    private void ToggleFPSDisplay()
    {
        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            if(isDisplayed)
            {
                fpsTitle.enabled = false;
                isDisplayed = false;
            }
            else
            {
                fpsTitle.enabled = true;
                isDisplayed = true;
            }
        }
    }
}
