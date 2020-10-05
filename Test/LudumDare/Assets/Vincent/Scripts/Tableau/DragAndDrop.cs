using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class DragAndDrop : MonoBehaviour
{
    private List<Transform> emplacements;
    private bool selected;

    bool inTableau = false;
    bool inInventaire = true;

    Vector2 posInitiale;
    Vector2 posTableau;

    int nbrFull = 0;

    public int type = 0;

    private void Start()
    {
        posInitiale = transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        isMouseOver();

        if (selected)
        {
            Vector2 cursorPos = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = cursorPos;
        }
        if (Input.GetMouseButtonUp(0) && selected && inInventaire)
        {
            selected = false;
            ajoutMaterial();
        }
        else if(Input.GetMouseButtonUp(0) && selected && !inInventaire)
        { 
                selected = false;
            
            if (!inTableau ||nbrFull > 1 )
            {
                 ajoutMaterial();
            }
            else
            {
                transform.position = posTableau;
                FindObjectOfType<AudioManager>().Play("StatueGoodCristal");
            }
        }
    }

    private void isMouseOver()
    {
        Vector2 pos = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
        

        if (hit.transform == transform)
        {
            if (Input.GetMouseButtonDown(0))
            {
                selected = true;
                transform.parent = null;
                
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Tableau")
        {
            collision.gameObject.GetComponent<CaseTableau>().full++;
            nbrFull = collision.gameObject.GetComponent<CaseTableau>().full;
            inTableau = true;
            
            posTableau = collision.transform.position;
            transform.parent = collision.transform;
        }

        else if (collision.gameObject.tag == "Inventaire")
        {
            inInventaire = true;
           
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tableau")
        {
            collision.gameObject.GetComponent<CaseTableau>().full--;
            inTableau = false;
            transform.parent = null;
        }
        else if (collision.gameObject.tag == "Inventaire")
        {
            inInventaire = false;

        }
    }


    public void ajoutMaterial()
    {
        Inventaire inventaire = GameObject.FindGameObjectWithTag("Inventaire").GetComponent<Inventaire>();
        emplacements = inventaire.emplacements;
        for (int i = 0; i < emplacements.Count - 1; i++)
        {
            if (emplacements[i].childCount == 0)
            {
                transform.position = emplacements[i].transform.position;
                transform.parent = emplacements[i].transform;
                break;
            }
        }
    }
}
