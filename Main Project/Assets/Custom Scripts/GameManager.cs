using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip birdClip;
    public AudioClip killBirdClip;
    public AudioClip slimeClip;
    public AudioClip KillSlimeClip;
    int counter;
    int killcount;

    public TextMeshProUGUI score;
    public TextMeshProUGUI kills;

    private void Start()
    {
        counter = 0;
        killcount = 0;
        score.text = "Score: " + counter.ToString();
        kills.text = "Kills: " + killcount.ToString();
    }
    /*public void Bird()
    {
        audioSource.PlayOneShot(birdClip);
    }
    public void KillBird()
    {
        audioSource.PlayOneShot(killBirdClip);
    }
    public void Slime()
    {
        audioSource.PlayOneShot(slimeClip);
    }
    public void killSlime()
    {
        audioSource.PlayOneShot(KillSlimeClip);
    }*/
    public void IncreaseScore()
    {
        counter += 1;
        score.text = "Score: " + counter.ToString();
    }

    public void IncreaseKills()
    {
        killcount += 1;
        kills.text = "Kills: " + killcount.ToString();
    }
    public void DecreaseScore()
    {
        counter -= 1;
        score.text = "Score: " + counter.ToString();
    }

    public void DecreaseKills()
    {
        killcount -= 1;
        kills.text = "Kills: " + killcount.ToString();
    }
    public void ScoreCheck()
    { 
        if (counter == -1)
            SceneManager.LoadScene(2);
    }

    public void KillCheck()
    {
        if (killcount == -1)
            SceneManager.LoadScene(2);
    }
}
