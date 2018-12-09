using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_quit : MonoBehaviour {
    public void doquit() {
        Debug.Log("has quit game");
        Application.Quit();
    }
}
