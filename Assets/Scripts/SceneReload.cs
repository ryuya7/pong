using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReload : MonoBehaviour
{
    void Update(){
        if(OVRInput.GetDown(OVRInput.RawButton.Y) | OVRInput.GetDown(OVRInput.RawButton.B)){
            SceneManager.LoadScene("TestScene");
        }
    }
}
