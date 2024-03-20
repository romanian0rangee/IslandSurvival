using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_s : MonoBehaviour
{
    public Animator animator;

    public Slider HealthBar;
    public Slider HungerBar;
    public Slider ThirstBar;

    float timer = 0;

    public GameObject GameOver_canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("vertical", Input.GetAxis("Vertical"));
        animator.SetFloat("horizontal", Input.GetAxis("Horizontal"));

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            animator.SetTrigger("jump");
        }
        
        timer += Time.deltaTime;

        if (timer >= 1)
        {
            HungerBar.value -= 1;
            ThirstBar.value -= 3;

            if(HungerBar.value == 0 || ThirstBar.value == 0)
            {
                HealthBar.value -= 1;
            }

            if (HealthBar.value == 0)
            {
                 GameOver_canvas.SetActive(true);
            }

            timer = 0;
        }

        
    }
}
