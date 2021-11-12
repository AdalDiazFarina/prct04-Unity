using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camera : MonoBehaviour
{
    public int camIndex = 0;
    private WebCamTexture cam;
    public RawImage display;

    void Start() {
        WebCamDevice device = WebCamTexture.devices[camIndex];
        cam = new WebCamTexture(device.name);
    }

    public void Play() {
        
        display.texture = cam;
        cam.Play();
    }

    public void Stop() {
        display.texture = null;
        cam.Stop();
    }

    public void Pause() {
        cam.Stop();
    }
}