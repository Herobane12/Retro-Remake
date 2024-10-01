using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    public AudioMixer AudioMixer;
    public GameObject Music;

    private void Start()
    {
        DontDestroyOnLoad(Music);
    }

    public void Title()
    {
        SceneManager.LoadScene("Title");
    }
    public void Info()
    {
        SceneManager.LoadScene("Info");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Multiplayer()
    {
        SceneManager.LoadScene("Multiplayer");
    }
    public void Multiplayer2()
    {
        SceneManager.LoadScene("Multiplayer 2");
    }
    public void Endless()
    {
        SceneManager.LoadScene("Level 3 Endless");
    }
    public void Endless2()
    {
        SceneManager.LoadScene("Endless M");
    }
    public void BNLM()
    {
        SceneManager.LoadScene("BNLM");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void ChangedVolume(float value)
    {
        if (value <= 0.01f)
            AudioMixer.SetFloat("Volume", -80);
        else
            AudioMixer.SetFloat("Volume", Mathf.Log(value) * 20);
    }
}
