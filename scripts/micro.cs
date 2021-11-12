using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class micro : MonoBehaviour
{
    public int microIndex = 0;
    public AudioSource audioSource;
    private string selectDevice;
    // Start is called before the first frame update
    public void Recording() {
        selectDevice = Microphone.devices[0];
        audioSource = GameObject.Find("Audio Source").GetComponent<AudioSource>();
        audioSource.clip = Microphone.Start(selectDevice, true, 10, 44100);
    }

    public void StopRecording() {
        Microphone.End(selectDevice);
    }

    public void HearTheRecording() {
        audioSource.Play();
    }
}
