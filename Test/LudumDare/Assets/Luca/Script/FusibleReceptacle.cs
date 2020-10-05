using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FusibleReceptacle : MonoBehaviour
{
    public int numberOfReceptacle;
    public GameObject me;
    public GameObject door;

    public bool isFuse;

    public Sprite WhitS;
    public Sprite Whitout;
    public SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        var fuse = me.GetComponent<PlayerIsHere>();
        var player = GameObject.Find("Player").GetComponent<Player>();
        var doorActu = door.GetComponent<BoxCollider2D>();
        var doorActuAnim = door.GetComponent<Animator>();
        var gen = GameObject.Find("Generator").GetComponent<Generator>();

        if(fuse.isPlayer){
            if(Input.GetKeyDown("e")){
                if(isFuse == false){

                if(numberOfReceptacle == 1){
                    if(player.fusible1 > 0){
                        Debug.Log("1ok");
                        player.fusible1--;
                        isFuse = true;
                    }else{
                        Debug.Log("need fuse 1");
                    }
                }
                else if(numberOfReceptacle == 2){
                    if(player.fusible2 > 0){
                        Debug.Log("2ok");
                        player.fusible2--;
                        isFuse = true;
                    }else{
                        Debug.Log("need fuse 2");
                    }
                }
                else if(numberOfReceptacle == 3){
                    if(player.fusible3 > 0){
                        Debug.Log("3ok");
                        player.fusible3--;
                        isFuse = true;
                    }else{
                        Debug.Log("need fuse 3");
                    }
                }
                    if(gen.GeneratorIsOn){
                        FindObjectOfType<AudioManager>().Play("Door");
                    }else{
                        FindObjectOfType<AudioManager>().Play("Fusible");
                    }
                }else{
                    if(numberOfReceptacle == 1){
                        player.fusible1++;
                        isFuse = false;
                }
                else if(numberOfReceptacle == 2){
                        player.fusible2++;
                        isFuse = false;
                }
                else if(numberOfReceptacle == 3){
                        player.fusible3++;
                        isFuse = false;
                }
                FindObjectOfType<AudioManager>().Play("Fusible");
                }
            }
        }

        if(isFuse){
            sr.sprite = WhitS;
            if(gen.GeneratorIsOn){
                doorActu.isTrigger = true;
                doorActuAnim.SetTrigger("Open");
            }

        }else{
            doorActu.isTrigger = false;
            doorActuAnim.SetTrigger("Close");
            sr.sprite = Whitout;
        }
    }
}
