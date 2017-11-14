using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Stream : MonoBehaviour
{
    public GoalBox goalBox;

    void Start()
    {

    }
    
    void OnParticleCollision(GameObject other)
    {
        print(other.tag);
        if (other.transform.tag == "GoalBox")
        {
            print("filling");
            goalBox.Fill();
        }
        
    }
    
    
    void OnParticleTrigger()
    {
        goalBox.Fill();
    }
    
}
    
