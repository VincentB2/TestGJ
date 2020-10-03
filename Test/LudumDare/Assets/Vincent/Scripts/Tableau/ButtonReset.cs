using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ButtonReset : MonoBehaviour
{
    public GameObject case1;
    public GameObject case2;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(case1.transform.childCount != 0)
            {
                Transform ressource = case1.transform.GetChild(0);
                ressource.parent = null;
                ressource.GetComponent<DragAndDrop>().ResetPosition();
            }
            if (case2.transform.childCount != 0)
            {
                Transform ressource = case2.transform.GetChild(0);
                ressource.parent = null;
                ressource.GetComponent<DragAndDrop>().ResetPosition();
            }
        }
    }

}
