using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisonEnter(Collison c)
    {
       if(Equals(c.GetContanct<Collider>().tag, "wall"))
       {
           // we hit a wall 
           // player takes damage
           // we restart level
       }
    }
}
