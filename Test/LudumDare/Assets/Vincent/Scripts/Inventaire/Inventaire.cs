using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventaire : MonoBehaviour
{
    private List<Transform> emplacements;

    public BoolVariable isMaterial1;
    private bool lastMaterial1;
    public GameObject Mat1;

    public BoolVariable isMaterial2;
    private bool lastMaterial2;
    public GameObject Mat2;

    public BoolVariable isMaterial4;
    private bool lastMaterial4;
    public GameObject Mat4;

    public BoolVariable isMaterial5;
    private bool lastMaterial5;
    public GameObject Mat5;

    public BoolVariable isMaterial8;
    private bool lastMaterial8;
    public GameObject Mat8;

    public BoolVariable isMaterial9;
    private bool lastMaterial9;
    public GameObject Mat9;

    public BoolVariable isMaterial10;
    private bool lastMaterial10;
    public GameObject Mat10;

    private int place = 0;

    // Start is called before the first frame update
    void Start()
    {
        isMaterial1.Value = false;
        isMaterial2.Value = false;
        isMaterial4.Value = false;
        isMaterial5.Value = false;
        isMaterial8.Value = false;
        isMaterial9.Value = false;
        isMaterial10.Value = false;

        emplacements = new List<Transform>();
        foreach(Transform emplacement in transform)
        {
            emplacements.Add(emplacement);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //MAT1
        if(isMaterial1.Value != lastMaterial1)
        {
            if (isMaterial1.Value)
            {
                GameObject material = Instantiate(Mat1, emplacements[place].position, Mat1.transform.rotation);
                material.transform.parent = emplacements[place];
                place++;
            }
        }
        


        //MAT2
        else if (isMaterial2.Value != lastMaterial2)
        {
            if (isMaterial2.Value)
            {
                GameObject material = Instantiate(Mat2, emplacements[place].position, Mat2.transform.rotation);
                material.transform.parent = emplacements[place];
                place++;
            }
        }
        


        //MAT4
        else if (isMaterial4.Value != lastMaterial4)
        {
            if (isMaterial4.Value)
            {
                GameObject material = Instantiate(Mat4, emplacements[place].position, Mat4.transform.rotation);
                material.transform.parent = emplacements[place];
                place++;
            }
        }
        


        //MAT5
        else if (isMaterial5.Value != lastMaterial5)
        {
            if (isMaterial5.Value)
            {
                GameObject material = Instantiate(Mat5, emplacements[place].position, Mat5.transform.rotation);
                material.transform.parent = emplacements[place];
                place++;
            }
        }
        


        //MAT8
        if (isMaterial8.Value != lastMaterial8)
        {
            if (isMaterial8.Value)
            {
                GameObject material = Instantiate(Mat8, emplacements[place].position, Mat8.transform.rotation);
                material.transform.parent = emplacements[place];
                place++;
            }
        }
        


        //MAT9
        if (isMaterial9.Value != lastMaterial9)
        {
            if (isMaterial9.Value)
            {
                GameObject material = Instantiate(Mat9, emplacements[place].position, Mat9.transform.rotation);
                material.transform.parent = emplacements[place];
                place++;
            }
        }
        


        //MAT10
        if (isMaterial10.Value != lastMaterial10)
        {
            if (isMaterial10.Value)
            {
                GameObject material = Instantiate(Mat10, emplacements[place].position, Mat10.transform.rotation);
                material.transform.parent = emplacements[place];
                place++;
            }
        }
        

        lastMaterial1 = isMaterial1.Value;
        lastMaterial2 = isMaterial2.Value;
        lastMaterial4 = isMaterial4.Value;
        lastMaterial5 = isMaterial5.Value;
        lastMaterial8 = isMaterial8.Value;
        lastMaterial9 = isMaterial9.Value;
        lastMaterial10 = isMaterial10.Value;
    }
}
