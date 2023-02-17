using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements.Experimental;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine.AI;


public class CharacterController : MonoBehaviour
{

    private Camera mainCamera;

    private NavMeshAgent agent;

    public float MovementSpeed = 10;

    public bool Mouse;

    public bool KeyBoard;

    private Vector3 pointScreen;

    private Vector3 offset;




    void Start()
    {

/*        mainCamera = Camera.main;*/

        agent = GetComponent<NavMeshAgent>();

        Mouse = false;

        KeyBoard = false;

    }
    public void MouseInput()
    {

        Mouse = true;

        KeyBoard = false;


        //<---ÓÏÐÀÂËÅÍÈÅ Ñ ÌÛØÊÈ--->
        if (Input.GetMouseButtonDown(0))
        {

            /*            RaycastHit hit;

                        if (Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out hit))
                        {

                            CoinCol coin = hit.collider.gameObject.GetComponent<CoinCol>();

                            //<---Äåéñòâèÿ ïðè ïîïàäàíèè ïî òðàãåò îáúåêòó--->

                            if (coin != null)
                            {

                                agent.SetDestination(hit.point);


                            }
                        }*/
        }

    }
    

    public void KeyboardInput()
    {
        KeyBoard = true;

        Mouse = false;

        //<---ÓÏÐÀÂËÅÍÈÅ Ñ ÊËÀÂÈÀÒÓÐÛ--->
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        transform.position += direction * MovementSpeed * Time.deltaTime;

        transform.LookAt(transform.position + direction);
    }

    void Update()
            {
                if(KeyBoard == true)
                {
                    KeyboardInput();
                }
                if(Mouse == true)
                {
                    MouseInput();
                }
            }

    public void OnMouseDown()
    {
        if (KeyBoard == false)
        {
            pointScreen = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
        }

    }

    public void OnMouseDrag()
    {
        if (KeyBoard == false)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, pointScreen.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);

            transform.position = curPosition;
        }
    }
}


