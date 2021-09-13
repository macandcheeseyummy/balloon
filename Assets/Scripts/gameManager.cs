using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject box;
    public GameObject gameOverTxt;

    public static gameManager I;

    public Text time;
    float alive = 0.0f;

    public Animator anim;
    public GameObject balloon;

    private void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeBox", 0, 0.5f);
    }

    void makeBox()
    {
        Instantiate(box);
    }

    // Update is called once per frame
    void Update()
    {
        alive += Time.deltaTime;
        time.text = alive.ToString("N2");
    }

    public void gameOver()
    {
        anim.SetBool("isDead", true);
        gameOverTxt.SetActive(true);
        Invoke("dead", 0.5f);
    }

    void dead()
    {
        Time.timeScale = 0.0f;
        Destroy(balloon);
    }
}
