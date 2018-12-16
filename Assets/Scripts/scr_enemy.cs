using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_enemy : MonoBehaviour {

    private Animator myAnimation;

    private bool attacked;
	// Use this for initialization
	void Start () {
        myAnimation = GetComponent<Animator>();
	}
  
    void FixedUpdate()
    {
        OnAttack();
        ResetValues();
    }
    void OnMouseDown()
    {
        Debug.Log("has clicked");
        attacked = true;
    }

    private void OnAttack() {
        if (attacked)
        {
            myAnimation.SetTrigger("attacked");
        }
    }

    private void ResetValues() {
        attacked = false;
    }

}
