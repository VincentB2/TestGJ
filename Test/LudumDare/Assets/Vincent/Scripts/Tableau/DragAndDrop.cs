using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class DragAndDrop : MonoBehaviour
{

    private bool selected;

    bool inTableau = false;

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
        if (selected)
        {
            Vector2 cursorPos = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = cursorPos;
        }
        if (Input.GetMouseButtonUp(0))
        {
            selected = false;
            if (!inTableau ||nbrFull > 1)
            {
                ResetPosition();
            }
            else
            {
                transform.position = posTableau;
            }
        }
    }

    private void OnMouseOver()
    {
        Debug.Log("mouseOver");
        if (Input.GetMouseButtonDown(0))
        {
            selected = true;
            Debug.Log("hi");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Tableau")
        {
            collision.gameObject.GetComponent<CaseTableau>().full++;
            nbrFull = collision.gameObject.GetComponent<CaseTableau>().full;
            inTableau = true;
            Debug.Log("in");
            
            posTableau = collision.transform.position;
            transform.parent = collision.transform;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tableau")
        {
            collision.gameObject.GetComponent<CaseTableau>().full--;
            inTableau = false;
            Debug.Log("out");
            transform.parent = null;
        }
    }

    public void ResetPosition()
    {
        transform.position = posInitiale;
    }
}
