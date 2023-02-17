using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAndOpen : MonoBehaviour
{

    public GameObject gObject;

    bool active;

    public void OpenAndClose()
    {
        if(active == false)
        {
            gObject.transform.gameObject.SetActive(true);

            active = true;
        }
        else
        {
            gObject.transform.gameObject.SetActive(false);

            active = false;
        }
    }

    public void CloseInput()
    {
        gObject.transform.gameObject.SetActive(false);
    }

}
