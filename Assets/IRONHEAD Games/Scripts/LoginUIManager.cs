using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginUIManager : MonoBehaviour
{

    public GameObject ConnectOptionPanelGameObject;
    public GameObject ConnectWithNamePanelGameObject;
    // Start is called before the first frame update
    void Start()
    {
        ConnectOptionPanelGameObject.SetActive(true);
        ConnectWithNamePanelGameObject.SetActive(false);
    }
}
