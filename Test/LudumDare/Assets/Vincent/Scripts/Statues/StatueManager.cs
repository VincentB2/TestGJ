using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StatueManager : MonoBehaviour
{
    // Start is called before the first frame update
    private List<Transform> statues;
    public List<int> statueOrder;
    public List<int> requestedOrder;
    public GameObject particlesGreen;
    public GameObject particlesRed;

    bool called = false;

    public BoolVariable Statues;

    void Start()
    {
        Statues.Value = false;
        statues = new List<Transform>();
        statueOrder = new List<int>();
        foreach(Transform statue in transform)
        {
            statues.Add(statue);
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown("e") && !Statues.Value)
        {
            for(int i =0; i< statues.Count; i++)
            {
                if (statues[i].GetComponent<PlayerIsHere>().isPlayer)
                {
                    statueOrder.Add(i + 1);
                    for (int j = 0; j < statueOrder.Count; j++)
                    {

                        if(statueOrder[j] != requestedOrder[j])
                        {
                            Debug.Log("Wrong");
                            Instantiate(particlesRed, statues[i].transform.position, particlesRed.transform.rotation);
                            for(int k = 0; k < statueOrder.Count-1; k++)
                            {
                                Instantiate(particlesRed, statues[k].transform.position, particlesRed.transform.rotation);
                            }
                            statueOrder.Clear();

                        }

                        else if (statueOrder[j] == requestedOrder[j])
                        {
                            Debug.Log("Right number");
                            if (j == statueOrder.Count-1)
                            {
                                Instantiate(particlesGreen, statues[i].transform.position, particlesGreen.transform.rotation);
                            }

                            if(j == requestedOrder.Count - 1)
                            {
                                Statues.Value = true;
                                for(int l = 0; l< statues.Count; l++)
                                {
                                    Instantiate(particlesGreen, statues[l].transform.position, particlesGreen.transform.rotation);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
