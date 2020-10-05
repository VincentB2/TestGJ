using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carton : MonoBehaviour
{

    public GameObject me;
    public bool open;
    public bool good;
    public int fuseInside;

    public SpriteRenderer sr;
    public Sprite OpenS;
    public Sprite CloseS;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        var box = me.GetComponent<PlayerIsHere>();
        var player = GameObject.Find("Player").GetComponent<Player>();

        if(box.isPlayer){
            if(Input.GetKeyDown("e")){
                if(open == false){
                    open = true;
                    if(good == true){
                        FindObjectOfType<AudioManager>().Play("WinSoundEffect");
                        if (fuseInside == 1){
                            player.fusible1++;
                        }else if(fuseInside == 2){
                            player.fusible2++;
                        }else if(fuseInside == 3){
                            player.fusible3++;
                        }
                    }
                        FindObjectOfType<AudioManager>().Play("Carton");
                }
            }
        }


        if(open){
            sr.sprite = OpenS;
        }else{
            sr.sprite = CloseS;
        }
    }
}
