using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ButtonFusion : MonoBehaviour
{
    public GameObject case1;
    public GameObject case2;
    public GameObject caseResult;
    private List<int> ressourcesType;

    //Prefabs results
    public GameObject result8;
    public GameObject result9;
    public GameObject result10;
    public GameObject poubelle;

    private void Start()
    {
        ressourcesType = new List<int>();
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(case1.transform.childCount != 0 && case2.transform.childCount != 0)
            {
                GameObject ressource1 = case1.transform.GetChild(0).gameObject;
                ressourcesType.Add(ressource1.GetComponent<DragAndDrop>().type);
                GameObject ressource2 = case2.transform.GetChild(0).gameObject;
                ressourcesType.Add(ressource2.GetComponent<DragAndDrop>().type);
                
                Fusion(ressource1, ressource2);
                ressourcesType.Clear();
            }
            else
            {
               print("you need 2 elements for create fusion");
               
            }
            return;
        }
    }



    void Fusion(GameObject ressource1, GameObject ressource2)
    {
        // RETURN OBJECT 8
        if(ressourcesType[0] == 1)
        {
            if(ressourcesType[1] == 2)
            {
                Destroy(ressource1);
                Destroy(ressource2);
                Instantiate(result8, caseResult.transform.position, transform.rotation);
            }
            else
            {
                Destroy(ressource1);
                Destroy(ressource2);
                Instantiate(poubelle, caseResult.transform.position, transform.rotation);
            }

        }
        else if (ressourcesType[0] == 2)
        {
            if (ressourcesType[1] == 2)
            {
                Destroy(ressource1);
                Destroy(ressource2);
                Instantiate(result8, caseResult.transform.position, transform.rotation);
            }
            else
            {
                Destroy(ressource1);
                Destroy(ressource2);
                Instantiate(poubelle, caseResult.transform.position, transform.rotation);
            }

        }
        // RETURN OBJECT 9
        else if (ressourcesType[0] == 4)
        {
            if (ressourcesType[1] == 5)
            {
                Destroy(ressource1);
                Destroy(ressource2);
                Instantiate(result9, caseResult.transform.position, transform.rotation);
            }
            else
            {
                Destroy(ressource1);
                Destroy(ressource2);
                Instantiate(poubelle, caseResult.transform.position, transform.rotation);
            }

        }
        else if (ressourcesType[0] == 5)
        {
            if (ressourcesType[1] == 4)
            {
                Destroy(ressource1);
                Destroy(ressource2);
                Instantiate(result9, caseResult.transform.position, transform.rotation);
            }
            else
            {
                Destroy(ressource1);
                Destroy(ressource2);
                Instantiate(poubelle, caseResult.transform.position, transform.rotation);
            }

        }

        // RETURN OBJECT 10

        else if (ressourcesType[0] == 8)
        {
            if (ressourcesType[1] == 9)
            {
                Destroy(ressource1);
                Destroy(ressource2);
                Instantiate(result10, caseResult.transform.position, transform.rotation);
            }
            else
            {
                Destroy(ressource1);
                Destroy(ressource2);
                Instantiate(poubelle, caseResult.transform.position, transform.rotation);
            }

        }
        else if (ressourcesType[0] == 9)
        {
            if (ressourcesType[1] == 8)
            {
                Destroy(ressource1);
                Destroy(ressource2);
                Instantiate(result10, caseResult.transform.position, transform.rotation);
            }
            else
            {
                Destroy(ressource1);
                Destroy(ressource2);
                Instantiate(poubelle, caseResult.transform.position, transform.rotation);
            }

        }

        

    }

}
