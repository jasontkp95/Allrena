using UnityEngine;
using System.Collections;

public class DestroyHazard : MonoBehaviour {

    public float destroyTime = 3.0f;

    // Use this for initialization
    void Start () {
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update () {

    }
}
