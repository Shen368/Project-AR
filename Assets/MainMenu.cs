using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [Header("MenuFin")]
    public TextMeshProUGUI Win;
    public TextMeshProUGUI Lose;
    public Button buttonMenu;
    public Text Coin;
    public int nbCoin = 200;


    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quitter");
        Application.Quit();
    }

    public void EndGame()
    {
        Win.gameObject.SetActive(true);
        buttonMenu.gameObject.SetActive(true);
    }

    public void LoseGame()
    {
        Lose.gameObject.SetActive(true);
        buttonMenu.gameObject.SetActive(true);
    }

    void Start()
    {
        Win.gameObject.SetActive(false);
        Lose.gameObject.SetActive(false);
        buttonMenu.gameObject.SetActive(false);

        InvokeRepeating("gainCoin", 2, 2);

    }

    void Update()
    {
        Coin.text = nbCoin.ToString();
    }

    public void gainCoin()
    {
        nbCoin += 10;
    }
}
